namespace SIFLess
{
    partial class SolrCreateProfile
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
            this.validateVersionLabel = new System.Windows.Forms.Label();
            this.validateUrlLabel = new System.Windows.Forms.Label();
            this.validateCoreFolderLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.corePathTextBox = new System.Windows.Forms.TextBox();
            this.setCorePathBox = new System.Windows.Forms.LinkLabel();
            this.serviceComboBox = new System.Windows.Forms.ComboBox();
            this.solrCorePathBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.validateServiceLabel = new System.Windows.Forms.Label();
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
            this.fileGroupBox.Controls.Add(this.validateServiceLabel);
            this.fileGroupBox.Controls.Add(this.validateVersionLabel);
            this.fileGroupBox.Controls.Add(this.validateUrlLabel);
            this.fileGroupBox.Controls.Add(this.validateCoreFolderLabel);
            this.fileGroupBox.Location = new System.Drawing.Point(15, 270);
            this.fileGroupBox.Name = "fileGroupBox";
            this.fileGroupBox.Size = new System.Drawing.Size(479, 153);
            this.fileGroupBox.TabIndex = 11;
            this.fileGroupBox.TabStop = false;
            this.fileGroupBox.Text = "Validation";
            // 
            // validateVersionLabel
            // 
            this.validateVersionLabel.AutoSize = true;
            this.validateVersionLabel.Location = new System.Drawing.Point(20, 76);
            this.validateVersionLabel.Name = "validateVersionLabel";
            this.validateVersionLabel.Size = new System.Drawing.Size(145, 17);
            this.validateVersionLabel.TabIndex = 0;
            this.validateVersionLabel.Text = "Solr is correct version";
            // 
            // validateUrlLabel
            // 
            this.validateUrlLabel.AutoSize = true;
            this.validateUrlLabel.Location = new System.Drawing.Point(20, 50);
            this.validateUrlLabel.Name = "validateUrlLabel";
            this.validateUrlLabel.Size = new System.Drawing.Size(70, 17);
            this.validateUrlLabel.TabIndex = 0;
            this.validateUrlLabel.Text = "Url Works";
            // 
            // validateCoreFolderLabel
            // 
            this.validateCoreFolderLabel.AutoSize = true;
            this.validateCoreFolderLabel.Location = new System.Drawing.Point(20, 33);
            this.validateCoreFolderLabel.Name = "validateCoreFolderLabel";
            this.validateCoreFolderLabel.Size = new System.Drawing.Size(175, 17);
            this.validateCoreFolderLabel.TabIndex = 0;
            this.validateCoreFolderLabel.Text = "Folder Is Valid Core Folder";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Solr Url (ends with /solr)";
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(38, 86);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(456, 22);
            this.urlTextBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Solr Service";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Solr Core Path";
            // 
            // corePathTextBox
            // 
            this.corePathTextBox.Location = new System.Drawing.Point(35, 222);
            this.corePathTextBox.Name = "corePathTextBox";
            this.corePathTextBox.Size = new System.Drawing.Size(456, 22);
            this.corePathTextBox.TabIndex = 3;
            // 
            // setCorePathBox
            // 
            this.setCorePathBox.AutoSize = true;
            this.setCorePathBox.Location = new System.Drawing.Point(109, 202);
            this.setCorePathBox.Name = "setCorePathBox";
            this.setCorePathBox.Size = new System.Drawing.Size(29, 17);
            this.setCorePathBox.TabIndex = 12;
            this.setCorePathBox.TabStop = true;
            this.setCorePathBox.Text = "Set";
            this.setCorePathBox.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.setCorePathBox_LinkClicked);
            // 
            // serviceComboBox
            // 
            this.serviceComboBox.FormattingEnabled = true;
            this.serviceComboBox.Location = new System.Drawing.Point(38, 152);
            this.serviceComboBox.Name = "serviceComboBox";
            this.serviceComboBox.Size = new System.Drawing.Size(456, 24);
            this.serviceComboBox.TabIndex = 13;
            // 
            // validateServiceLabel
            // 
            this.validateServiceLabel.AutoSize = true;
            this.validateServiceLabel.Location = new System.Drawing.Point(17, 104);
            this.validateServiceLabel.Name = "validateServiceLabel";
            this.validateServiceLabel.Size = new System.Drawing.Size(133, 17);
            this.validateServiceLabel.TabIndex = 0;
            this.validateServiceLabel.Text = "Services is Running";
            // 
            // SolrCreateProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 495);
            this.Controls.Add(this.serviceComboBox);
            this.Controls.Add(this.setCorePathBox);
            this.Controls.Add(this.fileGroupBox);
            this.Controls.Add(this.validateButton);
            this.Controls.Add(this.corePathTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.profileTextBox);
            this.Controls.Add(this.label2);
            this.Name = "SolrCreateProfile";
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
        private System.Windows.Forms.Label validateCoreFolderLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox corePathTextBox;
        private System.Windows.Forms.Label validateVersionLabel;
        private System.Windows.Forms.Label validateUrlLabel;
        private System.Windows.Forms.LinkLabel setCorePathBox;
        private System.Windows.Forms.ComboBox serviceComboBox;
        private System.Windows.Forms.FolderBrowserDialog solrCorePathBrowser;
        private System.Windows.Forms.Label validateServiceLabel;
    }
}