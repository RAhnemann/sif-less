namespace SIFLess
{
    partial class ConnectionCreateProfile
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
            this.label2 = new System.Windows.Forms.Label();
            this.profileTextBox = new System.Windows.Forms.TextBox();
            this.validateButton = new System.Windows.Forms.Button();
            this.fileGroupBox = new System.Windows.Forms.GroupBox();
            this.validateDBCreateLabel = new System.Windows.Forms.Label();
            this.validateVersionLabel = new System.Windows.Forms.Label();
            this.validateLoginLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.connectionNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.fileGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Profile Name";
            // 
            // profileTextBox
            // 
            this.profileTextBox.Location = new System.Drawing.Point(38, 29);
            this.profileTextBox.Name = "profileTextBox";
            this.profileTextBox.Size = new System.Drawing.Size(456, 22);
            this.profileTextBox.TabIndex = 3;
            // 
            // validateButton
            // 
            this.validateButton.Location = new System.Drawing.Point(15, 453);
            this.validateButton.Name = "validateButton";
            this.validateButton.Size = new System.Drawing.Size(479, 29);
            this.validateButton.TabIndex = 10;
            this.validateButton.Text = "Create Profile";
            this.validateButton.UseVisualStyleBackColor = true;
            this.validateButton.Click += new System.EventHandler(this.validateButton_Click);
            // 
            // fileGroupBox
            // 
            this.fileGroupBox.Controls.Add(this.validateDBCreateLabel);
            this.fileGroupBox.Controls.Add(this.validateVersionLabel);
            this.fileGroupBox.Controls.Add(this.validateLoginLabel);
            this.fileGroupBox.Location = new System.Drawing.Point(15, 270);
            this.fileGroupBox.Name = "fileGroupBox";
            this.fileGroupBox.Size = new System.Drawing.Size(479, 153);
            this.fileGroupBox.TabIndex = 11;
            this.fileGroupBox.TabStop = false;
            this.fileGroupBox.Text = "Validation";
            // 
            // validateDBCreateLabel
            // 
            this.validateDBCreateLabel.AutoSize = true;
            this.validateDBCreateLabel.Location = new System.Drawing.Point(17, 111);
            this.validateDBCreateLabel.Name = "validateDBCreateLabel";
            this.validateDBCreateLabel.Size = new System.Drawing.Size(146, 17);
            this.validateDBCreateLabel.TabIndex = 0;
            this.validateDBCreateLabel.Text = "DB Create Permission";
            // 
            // validateVersionLabel
            // 
            this.validateVersionLabel.AutoSize = true;
            this.validateVersionLabel.Location = new System.Drawing.Point(17, 68);
            this.validateVersionLabel.Name = "validateVersionLabel";
            this.validateVersionLabel.Size = new System.Drawing.Size(160, 17);
            this.validateVersionLabel.TabIndex = 0;
            this.validateVersionLabel.Text = "Correct Version (2016+)";
            // 
            // validateLoginLabel
            // 
            this.validateLoginLabel.AutoSize = true;
            this.validateLoginLabel.Location = new System.Drawing.Point(20, 33);
            this.validateLoginLabel.Name = "validateLoginLabel";
            this.validateLoginLabel.Size = new System.Drawing.Size(87, 17);
            this.validateLoginLabel.TabIndex = 0;
            this.validateLoginLabel.Text = "Login Works";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Server";
            // 
            // connectionNameTextBox
            // 
            this.connectionNameTextBox.Location = new System.Drawing.Point(38, 86);
            this.connectionNameTextBox.Name = "connectionNameTextBox";
            this.connectionNameTextBox.Size = new System.Drawing.Size(456, 22);
            this.connectionNameTextBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Login";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(38, 151);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(456, 22);
            this.loginTextBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(35, 222);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(456, 22);
            this.passwordTextBox.TabIndex = 3;
            // 
            // ConnectionCreateProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 495);
            this.Controls.Add(this.fileGroupBox);
            this.Controls.Add(this.validateButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.connectionNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.profileTextBox);
            this.Controls.Add(this.label2);
            this.Name = "ConnectionCreateProfile";
            this.Text = "Create Profile";
            this.fileGroupBox.ResumeLayout(false);
            this.fileGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox profileTextBox;
        private System.Windows.Forms.Button validateButton;
        private System.Windows.Forms.GroupBox fileGroupBox;
        private System.Windows.Forms.Label validateLoginLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox connectionNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label validateDBCreateLabel;
        private System.Windows.Forms.Label validateVersionLabel;
    }
}