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
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.installTab = new System.Windows.Forms.TabPage();
            this.generateScriptsButton = new System.Windows.Forms.Button();
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
            this.instanceTab = new System.Windows.Forms.TabPage();
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
            this.saveScriptDialog = new System.Windows.Forms.SaveFileDialog();
            this.mainTabControl.SuspendLayout();
            this.installTab.SuspendLayout();
            this.instanceTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.installTab);
            this.mainTabControl.Controls.Add(this.instanceTab);
            this.mainTabControl.Location = new System.Drawing.Point(12, 12);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(509, 524);
            this.mainTabControl.TabIndex = 2;
            // 
            // installTab
            // 
            this.installTab.Controls.Add(this.generateScriptsButton);
            this.installTab.Controls.Add(this.customFieldsGroupBox);
            this.installTab.Controls.Add(this.manageSolrLinkButtonsLink);
            this.installTab.Controls.Add(this.label6);
            this.installTab.Controls.Add(this.prefixTextBox);
            this.installTab.Controls.Add(this.manageConnectionProfileLink);
            this.installTab.Controls.Add(this.solrListBox);
            this.installTab.Controls.Add(this.connectionListBox);
            this.installTab.Controls.Add(this.manageSitecoreProfilesLink);
            this.installTab.Controls.Add(this.label7);
            this.installTab.Controls.Add(this.label3);
            this.installTab.Controls.Add(this.label2);
            this.installTab.Controls.Add(this.profileListBox);
            this.installTab.Location = new System.Drawing.Point(4, 22);
            this.installTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.installTab.Name = "installTab";
            this.installTab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.installTab.Size = new System.Drawing.Size(501, 498);
            this.installTab.TabIndex = 3;
            this.installTab.Text = "Install Sitecore";
            this.installTab.UseVisualStyleBackColor = true;
            // 
            // generateScriptsButton
            // 
            this.generateScriptsButton.Location = new System.Drawing.Point(14, 258);
            this.generateScriptsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.generateScriptsButton.Name = "generateScriptsButton";
            this.generateScriptsButton.Size = new System.Drawing.Size(164, 27);
            this.generateScriptsButton.TabIndex = 40;
            this.generateScriptsButton.Text = "Generate Scripts";
            this.generateScriptsButton.UseVisualStyleBackColor = true;
            this.generateScriptsButton.Click += new System.EventHandler(this.generateScriptsButton_Click);
            // 
            // customFieldsGroupBox
            // 
            this.customFieldsGroupBox.Location = new System.Drawing.Point(190, 12);
            this.customFieldsGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.customFieldsGroupBox.Name = "customFieldsGroupBox";
            this.customFieldsGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.customFieldsGroupBox.Size = new System.Drawing.Size(292, 483);
            this.customFieldsGroupBox.TabIndex = 68;
            this.customFieldsGroupBox.TabStop = false;
            this.customFieldsGroupBox.Text = "Custom Fields";
            // 
            // manageSolrLinkButtonsLink
            // 
            this.manageSolrLinkButtonsLink.AutoSize = true;
            this.manageSolrLinkButtonsLink.Location = new System.Drawing.Point(134, 125);
            this.manageSolrLinkButtonsLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.manageSolrLinkButtonsLink.Name = "manageSolrLinkButtonsLink";
            this.manageSolrLinkButtonsLink.Size = new System.Drawing.Size(46, 13);
            this.manageSolrLinkButtonsLink.TabIndex = 25;
            this.manageSolrLinkButtonsLink.TabStop = true;
            this.manageSolrLinkButtonsLink.Text = "Manage";
            this.manageSolrLinkButtonsLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.manageSolrLinkButtonsLink_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 63;
            this.label6.Text = "Install Prefix";
            // 
            // prefixTextBox
            // 
            this.prefixTextBox.Location = new System.Drawing.Point(32, 188);
            this.prefixTextBox.Name = "prefixTextBox";
            this.prefixTextBox.Size = new System.Drawing.Size(147, 20);
            this.prefixTextBox.TabIndex = 30;
            this.prefixTextBox.Text = "sitecore9";
            // 
            // manageConnectionProfileLink
            // 
            this.manageConnectionProfileLink.AutoSize = true;
            this.manageConnectionProfileLink.Location = new System.Drawing.Point(134, 80);
            this.manageConnectionProfileLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.manageConnectionProfileLink.Name = "manageConnectionProfileLink";
            this.manageConnectionProfileLink.Size = new System.Drawing.Size(46, 13);
            this.manageConnectionProfileLink.TabIndex = 15;
            this.manageConnectionProfileLink.TabStop = true;
            this.manageConnectionProfileLink.Text = "Manage";
            this.manageConnectionProfileLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.manageConnectionProfileLink_LinkClicked);
            // 
            // solrListBox
            // 
            this.solrListBox.FormattingEnabled = true;
            this.solrListBox.Location = new System.Drawing.Point(32, 141);
            this.solrListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.solrListBox.Name = "solrListBox";
            this.solrListBox.Size = new System.Drawing.Size(147, 21);
            this.solrListBox.TabIndex = 20;
            // 
            // connectionListBox
            // 
            this.connectionListBox.FormattingEnabled = true;
            this.connectionListBox.Location = new System.Drawing.Point(32, 96);
            this.connectionListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.connectionListBox.Name = "connectionListBox";
            this.connectionListBox.Size = new System.Drawing.Size(147, 21);
            this.connectionListBox.TabIndex = 10;
            // 
            // manageSitecoreProfilesLink
            // 
            this.manageSitecoreProfilesLink.AutoSize = true;
            this.manageSitecoreProfilesLink.Location = new System.Drawing.Point(134, 17);
            this.manageSitecoreProfilesLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.manageSitecoreProfilesLink.Name = "manageSitecoreProfilesLink";
            this.manageSitecoreProfilesLink.Size = new System.Drawing.Size(46, 13);
            this.manageSitecoreProfilesLink.TabIndex = 5;
            this.manageSitecoreProfilesLink.TabStop = true;
            this.manageSitecoreProfilesLink.Text = "Manage";
            this.manageSitecoreProfilesLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.manageSitecoreProfilesLink_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 125);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Solr Profile";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Connection Profile";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sitecore Profile";
            // 
            // profileListBox
            // 
            this.profileListBox.FormattingEnabled = true;
            this.profileListBox.Location = new System.Drawing.Point(32, 33);
            this.profileListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.profileListBox.Name = "profileListBox";
            this.profileListBox.Size = new System.Drawing.Size(147, 21);
            this.profileListBox.TabIndex = 0;
            this.profileListBox.SelectedIndexChanged += new System.EventHandler(this.profileListBox_SelectedIndexChanged);
            // 
            // instanceTab
            // 
            this.instanceTab.Controls.Add(this.uninstallInstanceButton);
            this.instanceTab.Controls.Add(this.instanceDateCreatedVLabel);
            this.instanceTab.Controls.Add(this.instanceXConnectSiteNameVLabel);
            this.instanceTab.Controls.Add(this.instanceSiteNameVLabel);
            this.instanceTab.Controls.Add(this.instancePrefixVLabel);
            this.instanceTab.Controls.Add(this.instanceDateCreatedLabel);
            this.instanceTab.Controls.Add(this.instanceXConnectSiteNameLabel);
            this.instanceTab.Controls.Add(this.instanceSiteNameLabel);
            this.instanceTab.Controls.Add(this.instancePrefixLabel);
            this.instanceTab.Controls.Add(this.label1);
            this.instanceTab.Controls.Add(this.instancesListBox);
            this.instanceTab.Location = new System.Drawing.Point(4, 22);
            this.instanceTab.Name = "instanceTab";
            this.instanceTab.Size = new System.Drawing.Size(501, 498);
            this.instanceTab.TabIndex = 2;
            this.instanceTab.Text = "Instance Manager";
            this.instanceTab.UseVisualStyleBackColor = true;
            // 
            // uninstallInstanceButton
            // 
            this.uninstallInstanceButton.Location = new System.Drawing.Point(191, 115);
            this.uninstallInstanceButton.Name = "uninstallInstanceButton";
            this.uninstallInstanceButton.Size = new System.Drawing.Size(75, 23);
            this.uninstallInstanceButton.TabIndex = 3;
            this.uninstallInstanceButton.Text = "Remove";
            this.uninstallInstanceButton.UseVisualStyleBackColor = true;
            // 
            // instanceDateCreatedVLabel
            // 
            this.instanceDateCreatedVLabel.AutoSize = true;
            this.instanceDateCreatedVLabel.Location = new System.Drawing.Point(300, 95);
            this.instanceDateCreatedVLabel.Name = "instanceDateCreatedVLabel";
            this.instanceDateCreatedVLabel.Size = new System.Drawing.Size(0, 13);
            this.instanceDateCreatedVLabel.TabIndex = 2;
            // 
            // instanceXConnectSiteNameVLabel
            // 
            this.instanceXConnectSiteNameVLabel.AutoSize = true;
            this.instanceXConnectSiteNameVLabel.Location = new System.Drawing.Point(300, 75);
            this.instanceXConnectSiteNameVLabel.Name = "instanceXConnectSiteNameVLabel";
            this.instanceXConnectSiteNameVLabel.Size = new System.Drawing.Size(0, 13);
            this.instanceXConnectSiteNameVLabel.TabIndex = 2;
            // 
            // instanceSiteNameVLabel
            // 
            this.instanceSiteNameVLabel.AutoSize = true;
            this.instanceSiteNameVLabel.Location = new System.Drawing.Point(300, 55);
            this.instanceSiteNameVLabel.Name = "instanceSiteNameVLabel";
            this.instanceSiteNameVLabel.Size = new System.Drawing.Size(0, 13);
            this.instanceSiteNameVLabel.TabIndex = 2;
            // 
            // instancePrefixVLabel
            // 
            this.instancePrefixVLabel.AutoSize = true;
            this.instancePrefixVLabel.Location = new System.Drawing.Point(300, 35);
            this.instancePrefixVLabel.Name = "instancePrefixVLabel";
            this.instancePrefixVLabel.Size = new System.Drawing.Size(0, 13);
            this.instancePrefixVLabel.TabIndex = 2;
            // 
            // instanceDateCreatedLabel
            // 
            this.instanceDateCreatedLabel.AutoSize = true;
            this.instanceDateCreatedLabel.Location = new System.Drawing.Point(191, 95);
            this.instanceDateCreatedLabel.Name = "instanceDateCreatedLabel";
            this.instanceDateCreatedLabel.Size = new System.Drawing.Size(73, 13);
            this.instanceDateCreatedLabel.TabIndex = 2;
            this.instanceDateCreatedLabel.Text = "Date Created:";
            // 
            // instanceXConnectSiteNameLabel
            // 
            this.instanceXConnectSiteNameLabel.AutoSize = true;
            this.instanceXConnectSiteNameLabel.Location = new System.Drawing.Point(191, 75);
            this.instanceXConnectSiteNameLabel.Name = "instanceXConnectSiteNameLabel";
            this.instanceXConnectSiteNameLabel.Size = new System.Drawing.Size(110, 13);
            this.instanceXConnectSiteNameLabel.TabIndex = 2;
            this.instanceXConnectSiteNameLabel.Text = "xConnect Site Name: ";
            // 
            // instanceSiteNameLabel
            // 
            this.instanceSiteNameLabel.AutoSize = true;
            this.instanceSiteNameLabel.Location = new System.Drawing.Point(191, 55);
            this.instanceSiteNameLabel.Name = "instanceSiteNameLabel";
            this.instanceSiteNameLabel.Size = new System.Drawing.Size(62, 13);
            this.instanceSiteNameLabel.TabIndex = 2;
            this.instanceSiteNameLabel.Text = "Site Name: ";
            // 
            // instancePrefixLabel
            // 
            this.instancePrefixLabel.AutoSize = true;
            this.instancePrefixLabel.Location = new System.Drawing.Point(191, 35);
            this.instancePrefixLabel.Name = "instancePrefixLabel";
            this.instancePrefixLabel.Size = new System.Drawing.Size(39, 13);
            this.instancePrefixLabel.TabIndex = 2;
            this.instancePrefixLabel.Text = "Prefix: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Instances";
            // 
            // instancesListBox
            // 
            this.instancesListBox.Location = new System.Drawing.Point(0, 0);
            this.instancesListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.instancesListBox.Name = "instancesListBox";
            this.instancesListBox.Size = new System.Drawing.Size(91, 69);
            this.instancesListBox.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 548);
            this.Controls.Add(this.mainTabControl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "SIF-less";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainTabControl.ResumeLayout(false);
            this.installTab.ResumeLayout(false);
            this.installTab.PerformLayout();
            this.instanceTab.ResumeLayout(false);
            this.instanceTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage instanceTab;
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
        private System.Windows.Forms.TabPage installTab;
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

