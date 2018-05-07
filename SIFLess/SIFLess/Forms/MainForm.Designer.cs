namespace SIFLess
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.customFieldsGroupBox = new System.Windows.Forms.GroupBox();
            this.manageSolrLinkButtonsLink = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.prefixTextBox = new System.Windows.Forms.TextBox();
            this.manageConnectionProfileLink = new System.Windows.Forms.LinkLabel();
            this.solrListBox = new System.Windows.Forms.ComboBox();
            this.connectionListBox = new System.Windows.Forms.ComboBox();
            this.manageSitecoreProfilesLink = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.profileListBox = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.uninstallInstanceButton = new System.Windows.Forms.Button();
            this.instanceDateCreatedVLabel = new System.Windows.Forms.Label();
            this.instanceXConnectSiteNameVLabel = new System.Windows.Forms.Label();
            this.instanceSiteNameVLabel = new System.Windows.Forms.Label();
            this.instancePrefixVLabel = new System.Windows.Forms.Label();
            this.instanceDateCreatedLabel = new System.Windows.Forms.Label();
            this.instanceXConnectSiteNameLabel = new System.Windows.Forms.Label();
            this.instanceSiteNameLabel = new System.Windows.Forms.Label();
            this.instancePrefixLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.instancesListBox = new System.Windows.Forms.ListBox();
            this.generateScriptsButton = new System.Windows.Forms.Button();
            this.saveScriptDialog = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(16, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(679, 645);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.generateScriptsButton);
            this.tabPage4.Controls.Add(this.customFieldsGroupBox);
            this.tabPage4.Controls.Add(this.manageSolrLinkButtonsLink);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.prefixTextBox);
            this.tabPage4.Controls.Add(this.manageConnectionProfileLink);
            this.tabPage4.Controls.Add(this.solrListBox);
            this.tabPage4.Controls.Add(this.connectionListBox);
            this.tabPage4.Controls.Add(this.manageSitecoreProfilesLink);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.profileListBox);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(671, 616);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Install Sitecore";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // customFieldsGroupBox
            // 
            this.customFieldsGroupBox.Location = new System.Drawing.Point(254, 15);
            this.customFieldsGroupBox.Name = "customFieldsGroupBox";
            this.customFieldsGroupBox.Size = new System.Drawing.Size(390, 595);
            this.customFieldsGroupBox.TabIndex = 68;
            this.customFieldsGroupBox.TabStop = false;
            this.customFieldsGroupBox.Text = "Custom Fields";
            // 
            // manageSolrLinkButtonsLink
            // 
            this.manageSolrLinkButtonsLink.AutoSize = true;
            this.manageSolrLinkButtonsLink.Location = new System.Drawing.Point(178, 154);
            this.manageSolrLinkButtonsLink.Name = "manageSolrLinkButtonsLink";
            this.manageSolrLinkButtonsLink.Size = new System.Drawing.Size(59, 17);
            this.manageSolrLinkButtonsLink.TabIndex = 67;
            this.manageSolrLinkButtonsLink.TabStop = true;
            this.manageSolrLinkButtonsLink.Text = "Manage";
            this.manageSolrLinkButtonsLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.manageSolrLinkButtonsLink_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 210);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 63;
            this.label6.Text = "Install Prefix";
            // 
            // prefixTextBox
            // 
            this.prefixTextBox.Location = new System.Drawing.Point(42, 231);
            this.prefixTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.prefixTextBox.Name = "prefixTextBox";
            this.prefixTextBox.Size = new System.Drawing.Size(195, 22);
            this.prefixTextBox.TabIndex = 64;
            this.prefixTextBox.Text = "sitecore9";
            // 
            // manageConnectionProfileLink
            // 
            this.manageConnectionProfileLink.AutoSize = true;
            this.manageConnectionProfileLink.Location = new System.Drawing.Point(178, 98);
            this.manageConnectionProfileLink.Name = "manageConnectionProfileLink";
            this.manageConnectionProfileLink.Size = new System.Drawing.Size(59, 17);
            this.manageConnectionProfileLink.TabIndex = 5;
            this.manageConnectionProfileLink.TabStop = true;
            this.manageConnectionProfileLink.Text = "Manage";
            this.manageConnectionProfileLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.manageConnectionProfileLink_LinkClicked);
            // 
            // solrListBox
            // 
            this.solrListBox.FormattingEnabled = true;
            this.solrListBox.Location = new System.Drawing.Point(42, 174);
            this.solrListBox.Name = "solrListBox";
            this.solrListBox.Size = new System.Drawing.Size(195, 24);
            this.solrListBox.TabIndex = 4;
            // 
            // connectionListBox
            // 
            this.connectionListBox.FormattingEnabled = true;
            this.connectionListBox.Location = new System.Drawing.Point(42, 118);
            this.connectionListBox.Name = "connectionListBox";
            this.connectionListBox.Size = new System.Drawing.Size(195, 24);
            this.connectionListBox.TabIndex = 4;
            // 
            // manageSitecoreProfilesLink
            // 
            this.manageSitecoreProfilesLink.AutoSize = true;
            this.manageSitecoreProfilesLink.Location = new System.Drawing.Point(178, 21);
            this.manageSitecoreProfilesLink.Name = "manageSitecoreProfilesLink";
            this.manageSitecoreProfilesLink.Size = new System.Drawing.Size(59, 17);
            this.manageSitecoreProfilesLink.TabIndex = 3;
            this.manageSitecoreProfilesLink.TabStop = true;
            this.manageSitecoreProfilesLink.Text = "Manage";
            this.manageSitecoreProfilesLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.manageSitecoreProfilesLink_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Solr Profile";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Connection Profile";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sitecore Profile";
            // 
            // profileListBox
            // 
            this.profileListBox.FormattingEnabled = true;
            this.profileListBox.Location = new System.Drawing.Point(42, 41);
            this.profileListBox.Name = "profileListBox";
            this.profileListBox.Size = new System.Drawing.Size(195, 24);
            this.profileListBox.TabIndex = 0;
            this.profileListBox.SelectedIndexChanged += new System.EventHandler(this.profileListBox_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.uninstallInstanceButton);
            this.tabPage3.Controls.Add(this.instanceDateCreatedVLabel);
            this.tabPage3.Controls.Add(this.instanceXConnectSiteNameVLabel);
            this.tabPage3.Controls.Add(this.instanceSiteNameVLabel);
            this.tabPage3.Controls.Add(this.instancePrefixVLabel);
            this.tabPage3.Controls.Add(this.instanceDateCreatedLabel);
            this.tabPage3.Controls.Add(this.instanceXConnectSiteNameLabel);
            this.tabPage3.Controls.Add(this.instanceSiteNameLabel);
            this.tabPage3.Controls.Add(this.instancePrefixLabel);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.instancesListBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(671, 616);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Instance Manager";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // uninstallInstanceButton
            // 
            this.uninstallInstanceButton.Location = new System.Drawing.Point(255, 142);
            this.uninstallInstanceButton.Margin = new System.Windows.Forms.Padding(4);
            this.uninstallInstanceButton.Name = "uninstallInstanceButton";
            this.uninstallInstanceButton.Size = new System.Drawing.Size(100, 28);
            this.uninstallInstanceButton.TabIndex = 3;
            this.uninstallInstanceButton.Text = "Remove";
            this.uninstallInstanceButton.UseVisualStyleBackColor = true;
            // 
            // instanceDateCreatedVLabel
            // 
            this.instanceDateCreatedVLabel.AutoSize = true;
            this.instanceDateCreatedVLabel.Location = new System.Drawing.Point(400, 117);
            this.instanceDateCreatedVLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.instanceDateCreatedVLabel.Name = "instanceDateCreatedVLabel";
            this.instanceDateCreatedVLabel.Size = new System.Drawing.Size(0, 17);
            this.instanceDateCreatedVLabel.TabIndex = 2;
            // 
            // instanceXConnectSiteNameVLabel
            // 
            this.instanceXConnectSiteNameVLabel.AutoSize = true;
            this.instanceXConnectSiteNameVLabel.Location = new System.Drawing.Point(400, 92);
            this.instanceXConnectSiteNameVLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.instanceXConnectSiteNameVLabel.Name = "instanceXConnectSiteNameVLabel";
            this.instanceXConnectSiteNameVLabel.Size = new System.Drawing.Size(0, 17);
            this.instanceXConnectSiteNameVLabel.TabIndex = 2;
            // 
            // instanceSiteNameVLabel
            // 
            this.instanceSiteNameVLabel.AutoSize = true;
            this.instanceSiteNameVLabel.Location = new System.Drawing.Point(400, 68);
            this.instanceSiteNameVLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.instanceSiteNameVLabel.Name = "instanceSiteNameVLabel";
            this.instanceSiteNameVLabel.Size = new System.Drawing.Size(0, 17);
            this.instanceSiteNameVLabel.TabIndex = 2;
            // 
            // instancePrefixVLabel
            // 
            this.instancePrefixVLabel.AutoSize = true;
            this.instancePrefixVLabel.Location = new System.Drawing.Point(400, 43);
            this.instancePrefixVLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.instancePrefixVLabel.Name = "instancePrefixVLabel";
            this.instancePrefixVLabel.Size = new System.Drawing.Size(0, 17);
            this.instancePrefixVLabel.TabIndex = 2;
            // 
            // instanceDateCreatedLabel
            // 
            this.instanceDateCreatedLabel.AutoSize = true;
            this.instanceDateCreatedLabel.Location = new System.Drawing.Point(255, 117);
            this.instanceDateCreatedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.instanceDateCreatedLabel.Name = "instanceDateCreatedLabel";
            this.instanceDateCreatedLabel.Size = new System.Drawing.Size(96, 17);
            this.instanceDateCreatedLabel.TabIndex = 2;
            this.instanceDateCreatedLabel.Text = "Date Created:";
            // 
            // instanceXConnectSiteNameLabel
            // 
            this.instanceXConnectSiteNameLabel.AutoSize = true;
            this.instanceXConnectSiteNameLabel.Location = new System.Drawing.Point(255, 92);
            this.instanceXConnectSiteNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.instanceXConnectSiteNameLabel.Name = "instanceXConnectSiteNameLabel";
            this.instanceXConnectSiteNameLabel.Size = new System.Drawing.Size(143, 17);
            this.instanceXConnectSiteNameLabel.TabIndex = 2;
            this.instanceXConnectSiteNameLabel.Text = "xConnect Site Name: ";
            // 
            // instanceSiteNameLabel
            // 
            this.instanceSiteNameLabel.AutoSize = true;
            this.instanceSiteNameLabel.Location = new System.Drawing.Point(255, 68);
            this.instanceSiteNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.instanceSiteNameLabel.Name = "instanceSiteNameLabel";
            this.instanceSiteNameLabel.Size = new System.Drawing.Size(81, 17);
            this.instanceSiteNameLabel.TabIndex = 2;
            this.instanceSiteNameLabel.Text = "Site Name: ";
            // 
            // instancePrefixLabel
            // 
            this.instancePrefixLabel.AutoSize = true;
            this.instancePrefixLabel.Location = new System.Drawing.Point(255, 43);
            this.instancePrefixLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.instancePrefixLabel.Name = "instancePrefixLabel";
            this.instancePrefixLabel.Size = new System.Drawing.Size(51, 17);
            this.instancePrefixLabel.TabIndex = 2;
            this.instancePrefixLabel.Text = "Prefix: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Instances";
            // 
            // instancesListBox
            // 
            this.instancesListBox.ItemHeight = 16;
            this.instancesListBox.Location = new System.Drawing.Point(0, 0);
            this.instancesListBox.Name = "instancesListBox";
            this.instancesListBox.Size = new System.Drawing.Size(120, 84);
            this.instancesListBox.TabIndex = 4;
            // 
            // generateScriptsButton
            // 
            this.generateScriptsButton.Location = new System.Drawing.Point(19, 317);
            this.generateScriptsButton.Name = "generateScriptsButton";
            this.generateScriptsButton.Size = new System.Drawing.Size(218, 33);
            this.generateScriptsButton.TabIndex = 0;
            this.generateScriptsButton.Text = "Generate Scripts";
            this.generateScriptsButton.UseVisualStyleBackColor = true;
            this.generateScriptsButton.Click += new System.EventHandler(this.generateScriptsButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 674);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "SIF-less";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox instancesListBox;
        private System.Windows.Forms.Label instancePrefixLabel;
        private System.Windows.Forms.Label instanceSiteNameLabel;
        private System.Windows.Forms.Label instanceSiteNameVLabel;
        private System.Windows.Forms.Label instancePrefixVLabel;
        private System.Windows.Forms.Button uninstallInstanceButton;
        private System.Windows.Forms.Label instanceDateCreatedVLabel;
        private System.Windows.Forms.Label instanceXConnectSiteNameVLabel;
        private System.Windows.Forms.Label instanceDateCreatedLabel;
        private System.Windows.Forms.Label instanceXConnectSiteNameLabel;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ComboBox profileListBox;
        private System.Windows.Forms.LinkLabel manageSitecoreProfilesLink;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox connectionListBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox prefixTextBox;
        private System.Windows.Forms.LinkLabel manageConnectionProfileLink;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel manageSolrLinkButtonsLink;
        private System.Windows.Forms.ComboBox solrListBox;
        private System.Windows.Forms.GroupBox customFieldsGroupBox;
        private System.Windows.Forms.Button generateScriptsButton;
        private System.Windows.Forms.SaveFileDialog saveScriptDialog;
    }
}

