namespace UberCalendarUI.UI
{
    partial class LogInForm
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
            this.emailTB = new System.Windows.Forms.TextBox();
            this.logInBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.registerBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(15, 25);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(100, 20);
            this.emailTB.TabIndex = 1;
            // 
            // logInBTN
            // 
            this.logInBTN.Location = new System.Drawing.Point(81, 51);
            this.logInBTN.Name = "logInBTN";
            this.logInBTN.Size = new System.Drawing.Size(75, 23);
            this.logInBTN.TabIndex = 3;
            this.logInBTN.Text = "Log In";
            this.logInBTN.UseVisualStyleBackColor = true;
            this.logInBTN.Click += new System.EventHandler(this.logInBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(124, 25);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '*';
            this.passwordTB.Size = new System.Drawing.Size(100, 20);
            this.passwordTB.TabIndex = 2;
            // 
            // registerBTN
            // 
            this.registerBTN.Location = new System.Drawing.Point(81, 81);
            this.registerBTN.Name = "registerBTN";
            this.registerBTN.Size = new System.Drawing.Size(75, 23);
            this.registerBTN.TabIndex = 4;
            this.registerBTN.Text = "Register";
            this.registerBTN.UseVisualStyleBackColor = true;
            this.registerBTN.Click += new System.EventHandler(this.registerBTN_Click);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 113);
            this.Controls.Add(this.registerBTN);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logInBTN);
            this.Controls.Add(this.emailTB);
            this.Name = "LogInForm";
            this.Text = "LogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.Button logInBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Button registerBTN;
    }
}