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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Version";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Topolgy";
            // 
            // configList
            // 
            this.configList.Enabled = false;
            this.configList.FormattingEnabled = true;
            this.configList.ItemHeight = 16;
            this.configList.Location = new System.Drawing.Point(46, 319);
            this.configList.Name = "configList";
            this.configList.Size = new System.Drawing.Size(448, 84);
            this.configList.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(12, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Additional Config Files";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Data File Repository";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(154, 232);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(29, 17);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Set";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // validateButton
            // 
            this.validateButton.Location = new System.Drawing.Point(12, 686);
            this.validateButton.Name = "validateButton";
            this.validateButton.Size = new System.Drawing.Size(479, 29);
            this.validateButton.TabIndex = 10;
            this.validateButton.Text = "Create Profile";
            this.validateButton.UseVisualStyleBackColor = true;
            this.validateButton.Click += new System.EventHandler(this.validateButton_Click);
            // 
            // fileGroupBox
            // 
            this.fileGroupBox.Location = new System.Drawing.Point(15, 465);
            this.fileGroupBox.Name = "fileGroupBox";
            this.fileGroupBox.Size = new System.Drawing.Size(479, 215);
            this.fileGroupBox.TabIndex = 11;
            this.fileGroupBox.TabStop = false;
            this.fileGroupBox.Text = "Required Files";
            // 
            // topologyList
            // 
            this.topologyList.FormattingEnabled = true;
            this.topologyList.Location = new System.Drawing.Point(38, 85);
            this.topologyList.Name = "topologyList";
            this.topologyList.Size = new System.Drawing.Size(456, 24);
            this.topologyList.TabIndex = 12;
            this.topologyList.SelectedIndexChanged += new System.EventHandler(this.topologyList_SelectedIndexChanged);
            // 
            // versionList
            // 
            this.versionList.FormattingEnabled = true;
            this.versionList.Location = new System.Drawing.Point(38, 171);
            this.versionList.Name = "versionList";
            this.versionList.Size = new System.Drawing.Size(456, 24);
            this.versionList.TabIndex = 12;
            this.versionList.SelectedIndexChanged += new System.EventHandler(this.versionList_SelectedIndexChanged);
            // 
            // dataRepoTextBox
            // 
            this.dataRepoTextBox.Location = new System.Drawing.Point(38, 252);
            this.dataRepoTextBox.Name = "dataRepoTextBox";
            this.dataRepoTextBox.Size = new System.Drawing.Size(456, 22);
            this.dataRepoTextBox.TabIndex = 13;
            // 
            // SitecoreCreateProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 727);
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
    }
}