namespace PIWebAPIPractice1
{
    partial class DeletePITagEvents
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.GetArchiveButton = new System.Windows.Forms.Button();
            this.StartTimeTextBox = new System.Windows.Forms.TextBox();
            this.EndTimeTextBox = new System.Windows.Forms.TextBox();
            this.StartTimeLabel = new System.Windows.Forms.Label();
            this.EndTimeLabel = new System.Windows.Forms.Label();
            this.piServerPicker1 = new OSIsoft.AF.UI.PIServerPicker();
            this.PITagSearchButton = new System.Windows.Forms.Button();
            this.TagList = new System.Windows.Forms.ListView();
            this.TagName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descriptor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TagClearButton = new System.Windows.Forms.Button();
            this.UpdateView = new System.Windows.Forms.ListView();
            this.TagName2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Timecolum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Valuecolum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DeleteValueTextBox = new System.Windows.Forms.TextBox();
            this.ResultsClearButton = new System.Windows.Forms.Button();
            this.DeleteAllTagsInAboveLabel = new System.Windows.Forms.Label();
            this.radioButton_AllEvents = new System.Windows.Forms.RadioButton();
            this.radioButton_SpecificEvents = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // GetArchiveButton
            // 
            this.GetArchiveButton.Location = new System.Drawing.Point(12, 300);
            this.GetArchiveButton.Name = "GetArchiveButton";
            this.GetArchiveButton.Size = new System.Drawing.Size(100, 23);
            this.GetArchiveButton.TabIndex = 3;
            this.GetArchiveButton.Text = "Delete Events";
            this.GetArchiveButton.UseVisualStyleBackColor = true;
            this.GetArchiveButton.Click += new System.EventHandler(this.DeleteEvents_Click);
            // 
            // StartTimeTextBox
            // 
            this.StartTimeTextBox.Location = new System.Drawing.Point(85, 276);
            this.StartTimeTextBox.Name = "StartTimeTextBox";
            this.StartTimeTextBox.Size = new System.Drawing.Size(72, 19);
            this.StartTimeTextBox.TabIndex = 42;
            this.StartTimeTextBox.Text = "*-2h";
            // 
            // EndTimeTextBox
            // 
            this.EndTimeTextBox.Location = new System.Drawing.Point(226, 276);
            this.EndTimeTextBox.Name = "EndTimeTextBox";
            this.EndTimeTextBox.Size = new System.Drawing.Size(72, 19);
            this.EndTimeTextBox.TabIndex = 43;
            this.EndTimeTextBox.Text = "*";
            // 
            // StartTimeLabel
            // 
            this.StartTimeLabel.AutoSize = true;
            this.StartTimeLabel.Location = new System.Drawing.Point(20, 279);
            this.StartTimeLabel.Name = "StartTimeLabel";
            this.StartTimeLabel.Size = new System.Drawing.Size(59, 12);
            this.StartTimeLabel.TabIndex = 44;
            this.StartTimeLabel.Text = "Start Time";
            // 
            // EndTimeLabel
            // 
            this.EndTimeLabel.AutoSize = true;
            this.EndTimeLabel.Location = new System.Drawing.Point(167, 279);
            this.EndTimeLabel.Name = "EndTimeLabel";
            this.EndTimeLabel.Size = new System.Drawing.Size(53, 12);
            this.EndTimeLabel.TabIndex = 45;
            this.EndTimeLabel.Text = "End Time";
            // 
            // piServerPicker1
            // 
            this.piServerPicker1.AccessibleDescription = "PI Serverの選択";
            this.piServerPicker1.AccessibleName = "PI Serverの選択";
            this.piServerPicker1.Caption = "エラー";
            this.piServerPicker1.Cursor = System.Windows.Forms.Cursors.Default;
            this.piServerPicker1.EnableBegin = false;
            this.piServerPicker1.EnableDelete = false;
            this.piServerPicker1.EnableEnd = false;
            this.piServerPicker1.EnableList = false;
            this.piServerPicker1.EnableNavigation = false;
            this.piServerPicker1.EnableNew = false;
            this.piServerPicker1.EnableNext = false;
            this.piServerPicker1.EnablePrevious = false;
            this.piServerPicker1.EnableProperties = false;
            this.piServerPicker1.Location = new System.Drawing.Point(12, 11);
            this.piServerPicker1.Name = "piServerPicker1";
            this.piServerPicker1.ShowBegin = false;
            this.piServerPicker1.ShowDelete = false;
            this.piServerPicker1.ShowEnd = false;
            this.piServerPicker1.ShowFind = false;
            this.piServerPicker1.ShowImages = false;
            this.piServerPicker1.ShowList = false;
            this.piServerPicker1.ShowNavigation = false;
            this.piServerPicker1.ShowNew = false;
            this.piServerPicker1.ShowNext = false;
            this.piServerPicker1.ShowNoEntries = false;
            this.piServerPicker1.ShowPrevious = false;
            this.piServerPicker1.ShowProperties = false;
            this.piServerPicker1.Size = new System.Drawing.Size(247, 20);
            this.piServerPicker1.TabIndex = 47;
            this.piServerPicker1.ConnectionChange += new OSIsoft.AF.UI.ConnectionChangeEventHandler(this.piServerPicker1_ConnectionChange);
            // 
            // PITagSearchButton
            // 
            this.PITagSearchButton.Location = new System.Drawing.Point(12, 41);
            this.PITagSearchButton.Name = "PITagSearchButton";
            this.PITagSearchButton.Size = new System.Drawing.Size(102, 23);
            this.PITagSearchButton.TabIndex = 48;
            this.PITagSearchButton.Text = "PITagSearch";
            this.PITagSearchButton.UseVisualStyleBackColor = true;
            this.PITagSearchButton.Click += new System.EventHandler(this.PITagSearch_Click);
            // 
            // TagList
            // 
            this.TagList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TagName,
            this.Descriptor});
            this.TagList.Location = new System.Drawing.Point(12, 70);
            this.TagList.MultiSelect = false;
            this.TagList.Name = "TagList";
            this.TagList.Size = new System.Drawing.Size(405, 131);
            this.TagList.TabIndex = 50;
            this.TagList.UseCompatibleStateImageBehavior = false;
            this.TagList.View = System.Windows.Forms.View.Details;
            this.TagList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.TagList_ItemSelectionChanged);
            // 
            // TagName
            // 
            this.TagName.Text = "TagName";
            this.TagName.Width = 181;
            // 
            // Descriptor
            // 
            this.Descriptor.Text = "Descriptor";
            this.Descriptor.Width = 194;
            // 
            // TagClearButton
            // 
            this.TagClearButton.Location = new System.Drawing.Point(120, 41);
            this.TagClearButton.Name = "TagClearButton";
            this.TagClearButton.Size = new System.Drawing.Size(75, 23);
            this.TagClearButton.TabIndex = 51;
            this.TagClearButton.Text = "Tag Clear";
            this.TagClearButton.UseVisualStyleBackColor = true;
            this.TagClearButton.Click += new System.EventHandler(this.TagClearButton_Click);
            // 
            // UpdateView
            // 
            this.UpdateView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TagName2,
            this.Timecolum,
            this.Valuecolum});
            this.UpdateView.Location = new System.Drawing.Point(12, 329);
            this.UpdateView.Name = "UpdateView";
            this.UpdateView.Size = new System.Drawing.Size(402, 208);
            this.UpdateView.TabIndex = 53;
            this.UpdateView.UseCompatibleStateImageBehavior = false;
            this.UpdateView.View = System.Windows.Forms.View.Details;
            // 
            // TagName2
            // 
            this.TagName2.Text = "TagName";
            this.TagName2.Width = 100;
            // 
            // Timecolum
            // 
            this.Timecolum.Text = "Timestamp";
            this.Timecolum.Width = 130;
            // 
            // Valuecolum
            // 
            this.Valuecolum.Text = "Value";
            this.Valuecolum.Width = 100;
            // 
            // DeleteValueTextBox
            // 
            this.DeleteValueTextBox.Location = new System.Drawing.Point(124, 251);
            this.DeleteValueTextBox.Name = "DeleteValueTextBox";
            this.DeleteValueTextBox.Size = new System.Drawing.Size(100, 19);
            this.DeleteValueTextBox.TabIndex = 54;
            this.DeleteValueTextBox.Text = "Shutdown";
            // 
            // ResultsClearButton
            // 
            this.ResultsClearButton.Location = new System.Drawing.Point(310, 300);
            this.ResultsClearButton.Name = "ResultsClearButton";
            this.ResultsClearButton.Size = new System.Drawing.Size(104, 23);
            this.ResultsClearButton.TabIndex = 55;
            this.ResultsClearButton.Text = "Results Clear";
            this.ResultsClearButton.UseVisualStyleBackColor = true;
            this.ResultsClearButton.Click += new System.EventHandler(this.ListClearButton_Click);
            // 
            // DeleteAllTagsInAboveLabel
            // 
            this.DeleteAllTagsInAboveLabel.AutoSize = true;
            this.DeleteAllTagsInAboveLabel.Location = new System.Drawing.Point(13, 208);
            this.DeleteAllTagsInAboveLabel.Name = "DeleteAllTagsInAboveLabel";
            this.DeleteAllTagsInAboveLabel.Size = new System.Drawing.Size(129, 12);
            this.DeleteAllTagsInAboveLabel.TabIndex = 56;
            this.DeleteAllTagsInAboveLabel.Text = "Delete all tags in above:";
            // 
            // radioButton_AllEvents
            // 
            this.radioButton_AllEvents.AutoSize = true;
            this.radioButton_AllEvents.Checked = true;
            this.radioButton_AllEvents.Location = new System.Drawing.Point(15, 229);
            this.radioButton_AllEvents.Name = "radioButton_AllEvents";
            this.radioButton_AllEvents.Size = new System.Drawing.Size(76, 16);
            this.radioButton_AllEvents.TabIndex = 57;
            this.radioButton_AllEvents.TabStop = true;
            this.radioButton_AllEvents.Text = "All Events";
            this.radioButton_AllEvents.UseVisualStyleBackColor = true;
            // 
            // radioButton_SpecificEvents
            // 
            this.radioButton_SpecificEvents.AutoSize = true;
            this.radioButton_SpecificEvents.Location = new System.Drawing.Point(15, 251);
            this.radioButton_SpecificEvents.Name = "radioButton_SpecificEvents";
            this.radioButton_SpecificEvents.Size = new System.Drawing.Size(103, 16);
            this.radioButton_SpecificEvents.TabIndex = 58;
            this.radioButton_SpecificEvents.Text = "Specific Events";
            this.radioButton_SpecificEvents.UseVisualStyleBackColor = true;
            // 
            // DeletePITagEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 546);
            this.Controls.Add(this.radioButton_SpecificEvents);
            this.Controls.Add(this.radioButton_AllEvents);
            this.Controls.Add(this.DeleteAllTagsInAboveLabel);
            this.Controls.Add(this.ResultsClearButton);
            this.Controls.Add(this.DeleteValueTextBox);
            this.Controls.Add(this.UpdateView);
            this.Controls.Add(this.TagClearButton);
            this.Controls.Add(this.TagList);
            this.Controls.Add(this.PITagSearchButton);
            this.Controls.Add(this.piServerPicker1);
            this.Controls.Add(this.EndTimeLabel);
            this.Controls.Add(this.StartTimeLabel);
            this.Controls.Add(this.EndTimeTextBox);
            this.Controls.Add(this.StartTimeTextBox);
            this.Controls.Add(this.GetArchiveButton);
            this.Name = "DeletePITagEvents";
            this.Text = "Delete PI Tag Events";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetArchiveButton;
        private System.Windows.Forms.TextBox StartTimeTextBox;
        private System.Windows.Forms.TextBox EndTimeTextBox;
        private System.Windows.Forms.Label StartTimeLabel;
        private System.Windows.Forms.Label EndTimeLabel;
        private OSIsoft.AF.UI.PIServerPicker piServerPicker1;
        private System.Windows.Forms.Button PITagSearchButton;
        private System.Windows.Forms.ListView TagList;
        private System.Windows.Forms.ColumnHeader TagName;
        private System.Windows.Forms.ColumnHeader Descriptor;
        private System.Windows.Forms.Button TagClearButton;
        private System.Windows.Forms.ListView UpdateView;
        private System.Windows.Forms.ColumnHeader Timecolum;
        private System.Windows.Forms.ColumnHeader Valuecolum;
        private System.Windows.Forms.ColumnHeader TagName2;
        private System.Windows.Forms.TextBox DeleteValueTextBox;
        private System.Windows.Forms.Button ResultsClearButton;
        private System.Windows.Forms.Label DeleteAllTagsInAboveLabel;
        private System.Windows.Forms.RadioButton radioButton_AllEvents;
        private System.Windows.Forms.RadioButton radioButton_SpecificEvents;
    }
}

