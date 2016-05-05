namespace Personal_Calendar
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.eventsList = new System.Windows.Forms.ListBox();
            this.addEventButton = new System.Windows.Forms.Button();
            this.removeEventButton = new System.Windows.Forms.Button();
            this.editEventButton = new System.Windows.Forms.Button();
            this.eventDetailsPanel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 18);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // eventsList
            // 
            this.eventsList.FormattingEnabled = true;
            this.eventsList.Location = new System.Drawing.Point(275, 18);
            this.eventsList.Name = "eventsList";
            this.eventsList.Size = new System.Drawing.Size(263, 160);
            this.eventsList.TabIndex = 1;
            this.eventsList.SelectedIndexChanged += new System.EventHandler(this.eventsList_SelectedIndexChanged);
            // 
            // addEventButton
            // 
            this.addEventButton.Location = new System.Drawing.Point(18, 192);
            this.addEventButton.Name = "addEventButton";
            this.addEventButton.Size = new System.Drawing.Size(75, 23);
            this.addEventButton.TabIndex = 2;
            this.addEventButton.Text = "Add Event";
            this.addEventButton.UseVisualStyleBackColor = true;
            this.addEventButton.Click += new System.EventHandler(this.addEventButton_Click);
            // 
            // removeEventButton
            // 
            this.removeEventButton.AccessibleName = "removeEventButton";
            this.removeEventButton.Enabled = false;
            this.removeEventButton.Location = new System.Drawing.Point(99, 192);
            this.removeEventButton.Name = "removeEventButton";
            this.removeEventButton.Size = new System.Drawing.Size(86, 23);
            this.removeEventButton.TabIndex = 3;
            this.removeEventButton.Text = "Remove Event";
            this.removeEventButton.UseVisualStyleBackColor = true;
            // 
            // editEventButton
            // 
            this.editEventButton.Location = new System.Drawing.Point(18, 222);
            this.editEventButton.Name = "editEventButton";
            this.editEventButton.Size = new System.Drawing.Size(75, 23);
            this.editEventButton.TabIndex = 4;
            this.editEventButton.Text = "Edit Event";
            this.editEventButton.UseVisualStyleBackColor = true;
            // 
            // eventDetailsPanel
            // 
            this.eventDetailsPanel.Location = new System.Drawing.Point(275, 194);
            this.eventDetailsPanel.Multiline = true;
            this.eventDetailsPanel.Name = "eventDetailsPanel";
            this.eventDetailsPanel.ReadOnly = true;
            this.eventDetailsPanel.Size = new System.Drawing.Size(263, 106);
            this.eventDetailsPanel.TabIndex = 5;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 370);
            this.Controls.Add(this.eventDetailsPanel);
            this.Controls.Add(this.editEventButton);
            this.Controls.Add(this.removeEventButton);
            this.Controls.Add(this.addEventButton);
            this.Controls.Add(this.eventsList);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "MainWindow";
            this.Text = "Personal Calendar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ListBox eventsList;
        private System.Windows.Forms.Button addEventButton;
        private System.Windows.Forms.Button removeEventButton;
        private System.Windows.Forms.Button editEventButton;
        private System.Windows.Forms.TextBox eventDetailsPanel;
    }
}

