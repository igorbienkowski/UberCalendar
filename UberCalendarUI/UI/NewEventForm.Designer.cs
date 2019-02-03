namespace UberCalendarUI.UI
{
    partial class NewEventForm
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
            this.eventDatePicker = new System.Windows.Forms.DateTimePicker();
            this.descriptionTB = new System.Windows.Forms.TextBox();
            this.eventTypeCB = new System.Windows.Forms.ComboBox();
            this.eventTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addEventBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // eventDatePicker
            // 
            this.eventDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.eventDatePicker.Location = new System.Drawing.Point(12, 12);
            this.eventDatePicker.Name = "eventDatePicker";
            this.eventDatePicker.Size = new System.Drawing.Size(82, 20);
            this.eventDatePicker.TabIndex = 0;
            // 
            // descriptionTB
            // 
            this.descriptionTB.AllowDrop = true;
            this.descriptionTB.Location = new System.Drawing.Point(13, 39);
            this.descriptionTB.MaxLength = 300;
            this.descriptionTB.Multiline = true;
            this.descriptionTB.Name = "descriptionTB";
            this.descriptionTB.Size = new System.Drawing.Size(330, 156);
            this.descriptionTB.TabIndex = 1;
            this.descriptionTB.Text = "Please write description for the event here. (Max 300 characters)";
            // 
            // eventTypeCB
            // 
            this.eventTypeCB.FormattingEnabled = true;
            this.eventTypeCB.Location = new System.Drawing.Point(257, 11);
            this.eventTypeCB.Name = "eventTypeCB";
            this.eventTypeCB.Size = new System.Drawing.Size(86, 21);
            this.eventTypeCB.TabIndex = 2;
            // 
            // eventTimePicker
            // 
            this.eventTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.eventTimePicker.Location = new System.Drawing.Point(100, 12);
            this.eventTimePicker.Name = "eventTimePicker";
            this.eventTimePicker.ShowUpDown = true;
            this.eventTimePicker.Size = new System.Drawing.Size(67, 20);
            this.eventTimePicker.TabIndex = 3;
            // 
            // addEventBTN
            // 
            this.addEventBTN.Location = new System.Drawing.Point(133, 201);
            this.addEventBTN.Name = "addEventBTN";
            this.addEventBTN.Size = new System.Drawing.Size(75, 23);
            this.addEventBTN.TabIndex = 4;
            this.addEventBTN.Text = "Add Event";
            this.addEventBTN.UseVisualStyleBackColor = true;
            this.addEventBTN.Click += new System.EventHandler(this.addEventBTN_Click);
            // 
            // NewEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 230);
            this.Controls.Add(this.addEventBTN);
            this.Controls.Add(this.eventTimePicker);
            this.Controls.Add(this.eventTypeCB);
            this.Controls.Add(this.descriptionTB);
            this.Controls.Add(this.eventDatePicker);
            this.Name = "NewEventForm";
            this.Text = "Add Event";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker eventDatePicker;
        private System.Windows.Forms.TextBox descriptionTB;
        private System.Windows.Forms.ComboBox eventTypeCB;
        private System.Windows.Forms.DateTimePicker eventTimePicker;
        private System.Windows.Forms.Button addEventBTN;
    }
}