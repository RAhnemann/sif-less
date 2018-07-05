namespace SIFLess
{
    partial class SitecoreCreateProfile
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.profileTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.configList = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.repoBrowerDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.validateButton = new System.Windows.Forms.Button();
            this.fileGroupBox = new System.Windows.Forms.GroupBox();
            this.topologyList = new System.Windows.Forms.ComboBox();
            this.versionList = new System.Windows.Forms.ComboBox();
            this.dataRepoTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.setLicenseLabel = new System.Windows.Forms.LinkLabel();
            this.licenseFileTextBox = new System.Windows.Forms.TextBox();
            this.licenseSelectDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Version";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Profile Name";
            // 
            // profileTextBox
            // 
            this.profileTextBox.Location = new System.Drawing.Point(28, 24);
            this.profileTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.profileTextBox.Name = "profileTextBox";
            this.profileTextBox.Size = new System.Drawing.Size(343, 20);
            this.profileTextBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Topolgy";
            // 
            // configList
            // 
            this.configList.Enabled = false;
            this.configList.FormattingEnabled = true;
            this.configList.Location = new System.Drawing.Point(28, 259);
            this.configList.Margin = new System.Windows.Forms.Padding(2);
            this.configList.Name = "configList";
            this.configList.Size = new System.Drawing.Size(343, 69);
            this.configList.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(9, 243);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Additional Config Files";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 188);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Data File Repository";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(116, 188);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(23, 13);
            this.linkLabel1.TabIndex = 45;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Set";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // validateButton
            // 
            this.validateButton.Location = new System.Drawing.Point(9, 557);
            this.validateButton.Margin = new System.Windows.Forms.Padding(2);
            this.validateButton.Name = "validateButton";
            this.validateButton.Size = new System.Drawing.Size(359, 24);
            this.validateButton.TabIndex = 50;
            this.validateButton.Text = "Create Profile";
            this.validateButton.UseVisualStyleBackColor = true;
            this.validateButton.Click += new System.EventHandler(this.validateButton_Click);
            // 
            // fileGroupBox
            // 
            this.fileGroupBox.Location = new System.Drawing.Point(11, 378);
            this.fileGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.fileGroupBox.Name = "fileGroupBox";
            this.fileGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.fileGroupBox.Size = new System.Drawing.Size(359, 175);
            this.fileGroupBox.TabIndex = 11;
            this.fileGroupBox.TabStop = false;
            this.fileGroupBox.Text = "Required Files";
            // 
            // topologyList
            // 
            this.topologyList.FormattingEnabled = true;
            this.topologyList.Location = new System.Drawing.Point(28, 116);
            this.topologyList.Margin = new System.Windows.Forms.Padding(2);
            this.topologyList.Name = "topologyList";
            this.topologyList.Size = new System.Drawing.Size(343, 21);
            this.topologyList.TabIndex = 20;
            this.topologyList.SelectedIndexChanged += new System.EventHandler(this.topologyList_SelectedIndexChanged);
            // 
            // versionList
            // 
            this.versionList.FormattingEnabled = true;
            this.versionList.Location = new System.Drawing.Point(28, 69);
            this.versionList.Margin = new System.Windows.Forms.Padding(2);
            this.versionList.Name = "versionList";
            this.versionList.Size = new System.Drawing.Size(343, 21);
            this.versionList.TabIndex = 10;
            this.versionList.SelectedIndexChanged += new System.EventHandler(this.versionList_SelectedIndexChanged);
            // 
            // dataRepoTextBox
            // 
            this.dataRepoTextBox.Location = new System.Drawing.Point(28, 205);
            this.dataRepoTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.dataRepoTextBox.Name = "dataRepoTextBox";
            this.dataRepoTextBox.Size = new System.Drawing.Size(343, 20);
            this.dataRepoTextBox.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 148);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "License";
            // 
            // setLicenseLabel
            // 
            this.setLicenseLabel.AutoSize = true;
            this.setLicenseLabel.Location = new System.Drawing.Point(56, 148);
            this.setLicenseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.setLicenseLabel.Name = "setLicenseLabel";
            this.setLicenseLabel.Size = new System.Drawing.Size(23, 13);
            this.setLicenseLabel.TabIndex = 35;
            this.setLicenseLabel.TabStop = true;
            this.setLicenseLabel.Text = "Set";
            this.setLicenseLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.setLicenseLabel_LinkClicked);
            // 
            // licenseFileTextBox
            // 
            this.licenseFileTextBox.Location = new System.Drawing.Point(28, 164);
            this.licenseFileTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.licenseFileTextBox.Name = "licenseFileTextBox";
            this.licenseFileTextBox.Size = new System.Drawing.Size(343, 20);
            this.licenseFileTextBox.TabIndex = 30;
            // 
            // licenseSelectDialog
            // 
            this.licenseSelectDialog.FileName = "openFileDialog1";
            this.licenseSelectDialog.Filter = "License files (license.xml)|license.xml";
            // 
            // SitecoreCreateProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 591);
            this.Controls.Add(this.licenseFileTextBox);
            this.Controls.Add(this.setLicenseLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataRepoTextBox);
            this.Controls.Add(this.versionList);
            this.Controls.Add(this.topologyList);
            this.Controls.Add(this.fileGroupBox);
            this.Controls.Add(this.validateButton);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.configList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.profileTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SitecoreCreateProfile";
            this.Text = "Create Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox profileTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox configList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FolderBrowserDialog repoBrowerDialog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button validateButton;
        private System.Windows.Forms.GroupBox fileGroupBox;
        private System.Windows.Forms.ComboBox topologyList;
        private System.Windows.Forms.ComboBox versionList;
        private System.Windows.Forms.TextBox dataRepoTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel setLicenseLabel;
        private System.Windows.Forms.TextBox licenseFileTextBox;
        private System.Windows.Forms.OpenFileDialog licenseSelectDialog;
    }
}