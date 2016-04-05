using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OSIsoft.AF;
using OSIsoft.AF.UI;
using OSIsoft.AF.Time;
using OSIsoft.AF.Asset;
using OSIsoft.AF.Data;
using OSIsoft.AF.PI;

namespace DeleteTagEvents
{

    public partial class DeletePITagEvents : Form
    {
        public AFDatabase myAFDatabase;
        public PISystem myAFServer;
        public AFElement myElement;
        public PIServer myPIServer;

        public DeletePITagEvents()
        {
            InitializeComponent();
        }

        private void piServerPicker1_ConnectionChange(object sender, SelectionChangeEventArgs e)
        {
            myPIServer = (PIServer)piServerPicker1.AFSelection;
        }

        private void PITagSearch_Click(object sender, EventArgs e)
        {
            try 
            {
                myPIServer = (PIServer)piServerPicker1.AFSelection;
                List<PIPoint> ptlist = AFOperations.FindPIPoints(this, myPIServer.Name, "", true, false);
                if (ptlist != null)
                {
                    foreach (PIPoint pt in ptlist)
                    {
                        string[] displayvalues = new string[2];
                        displayvalues[0] = pt.Name;
                        displayvalues[1] = pt.GetAttribute("Descriptor").ToString();
                        ListViewItem lvi = new ListViewItem(displayvalues);
                        TagList.Items.Add(lvi);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " : Have not connected PI Data Archive");
            }
        }

        private void TagClearButton_Click(object sender, EventArgs e)
        {
            TagList.Items.Clear();
        }

        private void DeleteEvents_Click(object sender, EventArgs e)
        {
            //Check TagList's count
            Int32 pointnumber = TagList.Items.Count;
            if (pointnumber < 1)
            {
                MessageBox.Show("Please search PI tags");
                return;
            }
            else
            {
                if (radioButton_AllEvents.Checked)
                {
                    //Delete all events
                    for (int i = 1; i <= pointnumber; ++i)
                    {
                        PIPoint pt = PIPoint.FindPIPoint(myPIServer, TagList.Items[i - 1].Text);
                        AFTimeRange timerange = new AFTimeRange();
                        timerange.StartTime = new AFTime(StartTimeTextBox.Text);
                        timerange.EndTime = new AFTime(EndTimeTextBox.Text);
                        AFValues vals = pt.RecordedValues(timerange, OSIsoft.AF.Data.AFBoundaryType.Inside, "", true);
                        
                        //delete all events within AFValues object
                        if (vals.Count > 0)
                        {
                            pt.UpdateValues(vals, AFUpdateOption.Remove);
                            string[] displayvalues = new string[3];
                            displayvalues[0] = pt.Name;
                            displayvalues[1] = timerange.ToString();
                            displayvalues[2] = "-";
                            ListViewItem lvi = new ListViewItem(displayvalues);
                            UpdateView.Items.Add(lvi);
                        }
                    }
                }
                else
                {
                    //Delete specific events
                    String deletestring = DeleteValueTextBox.Text.ToString();
                    for (int i = 1; i <= pointnumber; ++i)
                    {
                        PIPoint pt = PIPoint.FindPIPoint(myPIServer, TagList.Items[i - 1].Text);
                        AFTimeRange timerange = new AFTimeRange();
                        timerange.StartTime = new AFTime(StartTimeTextBox.Text);
                        timerange.EndTime = new AFTime(EndTimeTextBox.Text);
                        AFValues vals = pt.RecordedValues(timerange, OSIsoft.AF.Data.AFBoundaryType.Inside, "", true);
                        String Checktime = null;
                        String Checkvalue = null;
                        foreach (AFValue val in vals)
                        {
                            Checktime = val.Timestamp.LocalTime.ToString();
                            Checkvalue = ReadPIValueString(val);
                            if (Checkvalue == deletestring)
                            {
                                pt.UpdateValue(val, AFUpdateOption.Remove);
                                string[] displayvalues = new string[3];
                                displayvalues[0] = pt.Name;
                                displayvalues[1] = Checktime;
                                displayvalues[2] = Checkvalue;
                                ListViewItem lvi = new ListViewItem(displayvalues);
                                UpdateView.Items.Add(lvi);
                            }
                        }
                    }
                }
            }
            
        }
        private string ReadPIValueString(AFValue value)
        {
            String stringvalue;
            stringvalue = value.Value.ToString();
            return stringvalue;
        }

        private void ListClearButton_Click(object sender, EventArgs e)
        {
            UpdateView.Items.Clear();
        }

        private void TagList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            //TagList is not selectable
            if (e.IsSelected)
            {
                e.Item.Selected = false; // Cancell selected item
            }
        }
    }
}