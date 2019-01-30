namespace UberCalendarUI.UI
{
    partial class CalendarForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addEventBTN = new System.Windows.Forms.Button();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.eventsLB = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addEventBTN);
            this.groupBox1.Controls.Add(this.calendar);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 345);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // addEventBTN
            // 
            this.addEventBTN.Location = new System.Drawing.Point(87, 199);
            this.addEventBTN.Name = "addEventBTN";
            this.addEventBTN.Size = new System.Drawing.Size(75, 23);
            this.addEventBTN.TabIndex = 1;
            this.addEventBTN.Text = "Add event";
            this.addEventBTN.UseVisualStyleBackColor = true;
            this.addEventBTN.Click += new System.EventHandler(this.addEventBTN_Click);
            // 
            // calendar
            // 
            this.calendar.Location = new System.Drawing.Point(12, 25);
            this.calendar.MaxSelectionCount = 1;
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 0;
            this.calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendar_DateChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.eventsLB);
            this.groupBox2.Location = new System.Drawing.Point(271, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 345);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // eventsLB
            // 
            this.eventsLB.FormattingEnabled = true;
            this.eventsLB.Location = new System.Drawing.Point(6, 25);
            this.eventsLB.Name = "eventsLB";
            this.eventsLB.Size = new System.Drawing.Size(327, 303);
            this.eventsLB.TabIndex = 0;
            // 
            // CalendarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 366);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CalendarForm";
            this.Text = "CalendarForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addEventBTN;
        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox eventsLB;
    }
}