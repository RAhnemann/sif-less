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
            this.validateServiceLabel = new System.Windows.Forms.Label();
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
            this.fileGroupBox.SuspendLayout();
            this.SuspendLayout();
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
            // validateButton
            // 
            this.validateButton.Location = new System.Drawing.Point(11, 368);
            this.validateButton.Margin = new System.Windows.Forms.Padding(2);
            this.validateButton.Name = "validateButton";
            this.validateButton.Size = new System.Drawing.Size(359, 24);
            this.validateButton.TabIndex = 40;
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
            this.fileGroupBox.Location = new System.Drawing.Point(11, 219);
            this.fileGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.fileGroupBox.Name = "fileGroupBox";
            this.fileGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.fileGroupBox.Size = new System.Drawing.Size(359, 124);
            this.fileGroupBox.TabIndex = 11;
            this.fileGroupBox.TabStop = false;
            this.fileGroupBox.Text = "Validation";
            // 
            // validateServiceLabel
            // 
            this.validateServiceLabel.AutoSize = true;
            this.validateServiceLabel.Location = new System.Drawing.Point(15, 45);
            this.validateServiceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.validateServiceLabel.Name = "validateServiceLabel";
            this.validateServiceLabel.Size = new System.Drawing.Size(101, 13);
            this.validateServiceLabel.TabIndex = 0;
            this.validateServiceLabel.Text = "Services is Running";
            // 
            // validateVersionLabel
            // 
            this.validateVersionLabel.AutoSize = true;
            this.validateVersionLabel.Location = new System.Drawing.Point(15, 65);
            this.validateVersionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.validateVersionLabel.Name = "validateVersionLabel";
            this.validateVersionLabel.Size = new System.Drawing.Size(108, 13);
            this.validateVersionLabel.TabIndex = 0;
            this.validateVersionLabel.Text = "Solr is correct version";
            // 
            // validateUrlLabel
            // 
            this.validateUrlLabel.AutoSize = true;
            this.validateUrlLabel.Location = new System.Drawing.Point(15, 85);
            this.validateUrlLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.validateUrlLabel.Name = "validateUrlLabel";
            this.validateUrlLabel.Size = new System.Drawing.Size(54, 13);
            this.validateUrlLabel.TabIndex = 0;
            this.validateUrlLabel.Text = "Url Works";
            // 
            // validateCoreFolderLabel
            // 
            this.validateCoreFolderLabel.AutoSize = true;
            this.validateCoreFolderLabel.Location = new System.Drawing.Point(15, 25);
            this.validateCoreFolderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.validateCoreFolderLabel.Name = "validateCoreFolderLabel";
            this.validateCoreFolderLabel.Size = new System.Drawing.Size(130, 13);
            this.validateCoreFolderLabel.TabIndex = 0;
            this.validateCoreFolderLabel.Text = "Folder Is Valid Core Folder";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Solr Url (ends with /solr)";
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(28, 70);
            this.urlTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(343, 20);
            this.urlTextBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Solr Service";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 164);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Solr Core Path";
            // 
            // corePathTextBox
            // 
            this.corePathTextBox.Location = new System.Drawing.Point(26, 180);
            this.corePathTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.corePathTextBox.Name = "corePathTextBox";
            this.corePathTextBox.Size = new System.Drawing.Size(343, 20);
            this.corePathTextBox.TabIndex = 30;
            // 
            // setCorePathBox
            // 
            this.setCorePathBox.AutoSize = true;
            this.setCorePathBox.Location = new System.Drawing.Point(82, 164);
            this.setCorePathBox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.setCorePathBox.Name = "setCorePathBox";
            this.setCorePathBox.Size = new System.Drawing.Size(23, 13);
            this.setCorePathBox.TabIndex = 35;
            this.setCorePathBox.TabStop = true;
            this.setCorePathBox.Text = "Set";
            this.setCorePathBox.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.setCorePathBox_LinkClicked);
            // 
            // serviceComboBox
            // 
            this.serviceComboBox.FormattingEnabled = true;
            this.serviceComboBox.Location = new System.Drawing.Point(28, 124);
            this.serviceComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.serviceComboBox.Name = "serviceComboBox";
            this.serviceComboBox.Size = new System.Drawing.Size(343, 21);
            this.serviceComboBox.TabIndex = 20;
            // 
            // SolrCreateProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 402);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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