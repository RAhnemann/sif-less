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
            this.selectConfigDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.manageSolrLinkButtonsLink = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.manageConnectionProfileLink = new System.Windows.Forms.LinkLabel();
            this.solrListBox = new System.Windows.Forms.ComboBox();
            this.connectionListBox = new System.Windows.Forms.ComboBox();
            this.manageSitecoreProfilesLink = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.profileListBox = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ezGenOnlyCheckbox = new System.Windows.Forms.CheckBox();
            this.installButton = new System.Windows.Forms.Button();
            this.testButton = new System.Windows.Forms.Button();
            this.sqlPasswordLabel = new System.Windows.Forms.Label();
            this.sqlLoginLabel = new System.Windows.Forms.Label();
            this.sqlServerLabel = new System.Windows.Forms.Label();
            this.solrServiceLabel = new System.Windows.Forms.Label();
            this.solrFolderLabel = new System.Windows.Forms.Label();
            this.solrUrlLabel = new System.Windows.Forms.Label();
            this.xConnectSiteNameLabel = new System.Windows.Forms.Label();
            this.siteNameLabel = new System.Windows.Forms.Label();
            this.installPrefixLabel = new System.Windows.Forms.Label();
            this.xConnectPackageLabel = new System.Windows.Forms.Label();
            this.scPackageLabel = new System.Windows.Forms.Label();
            this.configLabel = new System.Windows.Forms.Label();
            this.sqlPasswordTextBox = new System.Windows.Forms.TextBox();
            this.sqlLoginTextBox = new System.Windows.Forms.TextBox();
            this.sqlServerTextBox = new System.Windows.Forms.TextBox();
            this.solrServiceTextBox = new System.Windows.Forms.TextBox();
            this.solrFolderTextBox = new System.Windows.Forms.TextBox();
            this.solrURLTextBox = new System.Windows.Forms.TextBox();
            this.xConnectName = new System.Windows.Forms.TextBox();
            this.siteNameTextBox = new System.Windows.Forms.TextBox();
            this.prefixTextBox = new System.Windows.Forms.TextBox();
            this.xConnectPackageTextBox = new System.Windows.Forms.TextBox();
            this.sitecorePackageTextBox = new System.Windows.Forms.TextBox();
            this.solrFolderButton = new System.Windows.Forms.Button();
            this.xConnectPackageButton = new System.Windows.Forms.Button();
            this.configTextBox = new System.Windows.Forms.TextBox();
            this.sitecorePackageButton = new System.Windows.Forms.Button();
            this.licenseLabel = new System.Windows.Forms.Label();
            this.configFolderButton = new System.Windows.Forms.Button();
            this.licenseTextBox = new System.Windows.Forms.TextBox();
            this.licenseFolderButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.hcGenerateCheckbox = new System.Windows.Forms.CheckBox();
            this.mainFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.runButton = new System.Windows.Forms.Button();
            this.selectFileButton = new System.Windows.Forms.Button();
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
            this.ezFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ezFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.instanceListWatcher = new System.IO.FileSystemWatcher();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.instanceListWatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // selectConfigDialog
            // 
            this.selectConfigDialog.Filter = "JSON Files|*.json";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(16, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(933, 645);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.manageSolrLinkButtonsLink);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.textBox1);
            this.tabPage4.Controls.Add(this.textBox2);
            this.tabPage4.Controls.Add(this.textBox3);
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
            this.tabPage4.Size = new System.Drawing.Size(925, 616);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Install Sitecore";
            this.tabPage4.UseVisualStyleBackColor = true;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 350);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 61;
            this.label4.Text = "xConnect Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 284);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 62;
            this.label5.Text = "Site Name";
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(42, 371);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 22);
            this.textBox1.TabIndex = 66;
            this.textBox1.Text = "sitecore9.xconnect";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(42, 305);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(195, 22);
            this.textBox2.TabIndex = 65;
            this.textBox2.Text = "sitecore9.sc";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(42, 231);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(195, 22);
            this.textBox3.TabIndex = 64;
            this.textBox3.Text = "sitecore9";
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
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ezGenOnlyCheckbox);
            this.tabPage1.Controls.Add(this.installButton);
            this.tabPage1.Controls.Add(this.testButton);
            this.tabPage1.Controls.Add(this.sqlPasswordLabel);
            this.tabPage1.Controls.Add(this.sqlLoginLabel);
            this.tabPage1.Controls.Add(this.sqlServerLabel);
            this.tabPage1.Controls.Add(this.solrServiceLabel);
            this.tabPage1.Controls.Add(this.solrFolderLabel);
            this.tabPage1.Controls.Add(this.solrUrlLabel);
            this.tabPage1.Controls.Add(this.xConnectSiteNameLabel);
            this.tabPage1.Controls.Add(this.siteNameLabel);
            this.tabPage1.Controls.Add(this.installPrefixLabel);
            this.tabPage1.Controls.Add(this.xConnectPackageLabel);
            this.tabPage1.Controls.Add(this.scPackageLabel);
            this.tabPage1.Controls.Add(this.configLabel);
            this.tabPage1.Controls.Add(this.sqlPasswordTextBox);
            this.tabPage1.Controls.Add(this.sqlLoginTextBox);
            this.tabPage1.Controls.Add(this.sqlServerTextBox);
            this.tabPage1.Controls.Add(this.solrServiceTextBox);
            this.tabPage1.Controls.Add(this.solrFolderTextBox);
            this.tabPage1.Controls.Add(this.solrURLTextBox);
            this.tabPage1.Controls.Add(this.xConnectName);
            this.tabPage1.Controls.Add(this.siteNameTextBox);
            this.tabPage1.Controls.Add(this.prefixTextBox);
            this.tabPage1.Controls.Add(this.xConnectPackageTextBox);
            this.tabPage1.Controls.Add(this.sitecorePackageTextBox);
            this.tabPage1.Controls.Add(this.solrFolderButton);
            this.tabPage1.Controls.Add(this.xConnectPackageButton);
            this.tabPage1.Controls.Add(this.configTextBox);
            this.tabPage1.Controls.Add(this.sitecorePackageButton);
            this.tabPage1.Controls.Add(this.licenseLabel);
            this.tabPage1.Controls.Add(this.configFolderButton);
            this.tabPage1.Controls.Add(this.licenseTextBox);
            this.tabPage1.Controls.Add(this.licenseFolderButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(925, 616);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "EZ Mode";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ezGenOnlyCheckbox
            // 
            this.ezGenOnlyCheckbox.AutoSize = true;
            this.ezGenOnlyCheckbox.Checked = true;
            this.ezGenOnlyCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ezGenOnlyCheckbox.Location = new System.Drawing.Point(465, 540);
            this.ezGenOnlyCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.ezGenOnlyCheckbox.Name = "ezGenOnlyCheckbox";
            this.ezGenOnlyCheckbox.Size = new System.Drawing.Size(156, 21);
            this.ezGenOnlyCheckbox.TabIndex = 140;
            this.ezGenOnlyCheckbox.Text = "Generate Files Only";
            this.ezGenOnlyCheckbox.UseVisualStyleBackColor = true;
            this.ezGenOnlyCheckbox.CheckedChanged += new System.EventHandler(this.ezGenOnlyCheckbox_CheckedChanged);
            // 
            // installButton
            // 
            this.installButton.Location = new System.Drawing.Point(33, 517);
            this.installButton.Margin = new System.Windows.Forms.Padding(4);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(424, 64);
            this.installButton.TabIndex = 150;
            this.installButton.Text = "Generate Files";
            this.installButton.UseVisualStyleBackColor = true;
            this.installButton.Click += new System.EventHandler(this.installButton_Click);
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(33, 446);
            this.testButton.Margin = new System.Windows.Forms.Padding(4);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(424, 64);
            this.testButton.TabIndex = 130;
            this.testButton.Text = "Test";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // sqlPasswordLabel
            // 
            this.sqlPasswordLabel.AutoSize = true;
            this.sqlPasswordLabel.Location = new System.Drawing.Point(8, 409);
            this.sqlPasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sqlPasswordLabel.Name = "sqlPasswordLabel";
            this.sqlPasswordLabel.Size = new System.Drawing.Size(101, 17);
            this.sqlPasswordLabel.TabIndex = 2;
            this.sqlPasswordLabel.Text = "SQL Password";
            // 
            // sqlLoginLabel
            // 
            this.sqlLoginLabel.AutoSize = true;
            this.sqlLoginLabel.Location = new System.Drawing.Point(8, 377);
            this.sqlLoginLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sqlLoginLabel.Name = "sqlLoginLabel";
            this.sqlLoginLabel.Size = new System.Drawing.Size(75, 17);
            this.sqlLoginLabel.TabIndex = 2;
            this.sqlLoginLabel.Text = "SQL Login";
            // 
            // sqlServerLabel
            // 
            this.sqlServerLabel.AutoSize = true;
            this.sqlServerLabel.Location = new System.Drawing.Point(8, 345);
            this.sqlServerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sqlServerLabel.Name = "sqlServerLabel";
            this.sqlServerLabel.Size = new System.Drawing.Size(82, 17);
            this.sqlServerLabel.TabIndex = 2;
            this.sqlServerLabel.Text = "SQL Server";
            // 
            // solrServiceLabel
            // 
            this.solrServiceLabel.AutoSize = true;
            this.solrServiceLabel.Location = new System.Drawing.Point(8, 311);
            this.solrServiceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.solrServiceLabel.Name = "solrServiceLabel";
            this.solrServiceLabel.Size = new System.Drawing.Size(84, 17);
            this.solrServiceLabel.TabIndex = 2;
            this.solrServiceLabel.Text = "Solr Service";
            // 
            // solrFolderLabel
            // 
            this.solrFolderLabel.AutoSize = true;
            this.solrFolderLabel.Location = new System.Drawing.Point(8, 279);
            this.solrFolderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.solrFolderLabel.Name = "solrFolderLabel";
            this.solrFolderLabel.Size = new System.Drawing.Size(77, 17);
            this.solrFolderLabel.TabIndex = 2;
            this.solrFolderLabel.Text = "Solr Folder";
            // 
            // solrUrlLabel
            // 
            this.solrUrlLabel.AutoSize = true;
            this.solrUrlLabel.Location = new System.Drawing.Point(8, 247);
            this.solrUrlLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.solrUrlLabel.Name = "solrUrlLabel";
            this.solrUrlLabel.Size = new System.Drawing.Size(65, 17);
            this.solrUrlLabel.TabIndex = 2;
            this.solrUrlLabel.Text = "Solr URL";
            // 
            // xConnectSiteNameLabel
            // 
            this.xConnectSiteNameLabel.AutoSize = true;
            this.xConnectSiteNameLabel.Location = new System.Drawing.Point(8, 212);
            this.xConnectSiteNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.xConnectSiteNameLabel.Name = "xConnectSiteNameLabel";
            this.xConnectSiteNameLabel.Size = new System.Drawing.Size(107, 17);
            this.xConnectSiteNameLabel.TabIndex = 2;
            this.xConnectSiteNameLabel.Text = "xConnect Name";
            // 
            // siteNameLabel
            // 
            this.siteNameLabel.AutoSize = true;
            this.siteNameLabel.Location = new System.Drawing.Point(8, 180);
            this.siteNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.siteNameLabel.Name = "siteNameLabel";
            this.siteNameLabel.Size = new System.Drawing.Size(73, 17);
            this.siteNameLabel.TabIndex = 2;
            this.siteNameLabel.Text = "Site Name";
            // 
            // installPrefixLabel
            // 
            this.installPrefixLabel.AutoSize = true;
            this.installPrefixLabel.Location = new System.Drawing.Point(8, 148);
            this.installPrefixLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.installPrefixLabel.Name = "installPrefixLabel";
            this.installPrefixLabel.Size = new System.Drawing.Size(83, 17);
            this.installPrefixLabel.TabIndex = 2;
            this.installPrefixLabel.Text = "Install Prefix";
            // 
            // xConnectPackageLabel
            // 
            this.xConnectPackageLabel.AutoSize = true;
            this.xConnectPackageLabel.Location = new System.Drawing.Point(8, 116);
            this.xConnectPackageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.xConnectPackageLabel.Name = "xConnectPackageLabel";
            this.xConnectPackageLabel.Size = new System.Drawing.Size(125, 17);
            this.xConnectPackageLabel.TabIndex = 2;
            this.xConnectPackageLabel.Text = "xConnect Package";
            // 
            // scPackageLabel
            // 
            this.scPackageLabel.AutoSize = true;
            this.scPackageLabel.Location = new System.Drawing.Point(8, 84);
            this.scPackageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scPackageLabel.Name = "scPackageLabel";
            this.scPackageLabel.Size = new System.Drawing.Size(119, 17);
            this.scPackageLabel.TabIndex = 2;
            this.scPackageLabel.Text = "Sitecore Package";
            // 
            // configLabel
            // 
            this.configLabel.AutoSize = true;
            this.configLabel.Location = new System.Drawing.Point(8, 52);
            this.configLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.configLabel.Name = "configLabel";
            this.configLabel.Size = new System.Drawing.Size(92, 17);
            this.configLabel.TabIndex = 2;
            this.configLabel.Text = "Config Folder";
            // 
            // sqlPasswordTextBox
            // 
            this.sqlPasswordTextBox.Location = new System.Drawing.Point(143, 402);
            this.sqlPasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.sqlPasswordTextBox.Name = "sqlPasswordTextBox";
            this.sqlPasswordTextBox.PasswordChar = '*';
            this.sqlPasswordTextBox.Size = new System.Drawing.Size(313, 22);
            this.sqlPasswordTextBox.TabIndex = 120;
            // 
            // sqlLoginTextBox
            // 
            this.sqlLoginTextBox.Location = new System.Drawing.Point(143, 370);
            this.sqlLoginTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.sqlLoginTextBox.Name = "sqlLoginTextBox";
            this.sqlLoginTextBox.Size = new System.Drawing.Size(313, 22);
            this.sqlLoginTextBox.TabIndex = 110;
            this.sqlLoginTextBox.Text = "sa";
            // 
            // sqlServerTextBox
            // 
            this.sqlServerTextBox.Location = new System.Drawing.Point(143, 338);
            this.sqlServerTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.sqlServerTextBox.Name = "sqlServerTextBox";
            this.sqlServerTextBox.Size = new System.Drawing.Size(313, 22);
            this.sqlServerTextBox.TabIndex = 100;
            this.sqlServerTextBox.Text = ".\\SQL2016";
            // 
            // solrServiceTextBox
            // 
            this.solrServiceTextBox.Location = new System.Drawing.Point(143, 305);
            this.solrServiceTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.solrServiceTextBox.Name = "solrServiceTextBox";
            this.solrServiceTextBox.Size = new System.Drawing.Size(313, 22);
            this.solrServiceTextBox.TabIndex = 90;
            this.solrServiceTextBox.Text = "Solr-6.6.1";
            // 
            // solrFolderTextBox
            // 
            this.solrFolderTextBox.Location = new System.Drawing.Point(143, 273);
            this.solrFolderTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.solrFolderTextBox.Name = "solrFolderTextBox";
            this.solrFolderTextBox.Size = new System.Drawing.Size(313, 22);
            this.solrFolderTextBox.TabIndex = 80;
            this.solrFolderTextBox.Text = "c:\\Solr-6.6.1\\";
            // 
            // solrURLTextBox
            // 
            this.solrURLTextBox.Location = new System.Drawing.Point(143, 241);
            this.solrURLTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.solrURLTextBox.Name = "solrURLTextBox";
            this.solrURLTextBox.Size = new System.Drawing.Size(313, 22);
            this.solrURLTextBox.TabIndex = 70;
            this.solrURLTextBox.Text = "https://localhost:8989/solr";
            // 
            // xConnectName
            // 
            this.xConnectName.Location = new System.Drawing.Point(143, 206);
            this.xConnectName.Margin = new System.Windows.Forms.Padding(4);
            this.xConnectName.Name = "xConnectName";
            this.xConnectName.Size = new System.Drawing.Size(313, 22);
            this.xConnectName.TabIndex = 60;
            this.xConnectName.Text = "xp0.xconnect";
            this.xConnectName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.xConnectName_KeyPress);
            // 
            // siteNameTextBox
            // 
            this.siteNameTextBox.Location = new System.Drawing.Point(143, 174);
            this.siteNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.siteNameTextBox.Name = "siteNameTextBox";
            this.siteNameTextBox.Size = new System.Drawing.Size(313, 22);
            this.siteNameTextBox.TabIndex = 50;
            this.siteNameTextBox.Text = "xp0.sc";
            this.siteNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.siteNameTextBox_KeyPress);
            // 
            // prefixTextBox
            // 
            this.prefixTextBox.Location = new System.Drawing.Point(143, 142);
            this.prefixTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.prefixTextBox.Name = "prefixTextBox";
            this.prefixTextBox.Size = new System.Drawing.Size(313, 22);
            this.prefixTextBox.TabIndex = 40;
            this.prefixTextBox.Text = "xp0";
            this.prefixTextBox.TextChanged += new System.EventHandler(this.prefixTextBox_TextChanged);
            // 
            // xConnectPackageTextBox
            // 
            this.xConnectPackageTextBox.Location = new System.Drawing.Point(143, 110);
            this.xConnectPackageTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.xConnectPackageTextBox.Name = "xConnectPackageTextBox";
            this.xConnectPackageTextBox.Size = new System.Drawing.Size(313, 22);
            this.xConnectPackageTextBox.TabIndex = 30;
            // 
            // sitecorePackageTextBox
            // 
            this.sitecorePackageTextBox.Location = new System.Drawing.Point(143, 78);
            this.sitecorePackageTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.sitecorePackageTextBox.Name = "sitecorePackageTextBox";
            this.sitecorePackageTextBox.Size = new System.Drawing.Size(313, 22);
            this.sitecorePackageTextBox.TabIndex = 20;
            // 
            // solrFolderButton
            // 
            this.solrFolderButton.Location = new System.Drawing.Point(465, 273);
            this.solrFolderButton.Margin = new System.Windows.Forms.Padding(4);
            this.solrFolderButton.Name = "solrFolderButton";
            this.solrFolderButton.Size = new System.Drawing.Size(40, 25);
            this.solrFolderButton.TabIndex = 0;
            this.solrFolderButton.Text = "...";
            this.solrFolderButton.UseVisualStyleBackColor = true;
            this.solrFolderButton.Click += new System.EventHandler(this.solrFolderButton_Click);
            // 
            // xConnectPackageButton
            // 
            this.xConnectPackageButton.Location = new System.Drawing.Point(465, 110);
            this.xConnectPackageButton.Margin = new System.Windows.Forms.Padding(4);
            this.xConnectPackageButton.Name = "xConnectPackageButton";
            this.xConnectPackageButton.Size = new System.Drawing.Size(40, 25);
            this.xConnectPackageButton.TabIndex = 0;
            this.xConnectPackageButton.Text = "...";
            this.xConnectPackageButton.UseVisualStyleBackColor = true;
            this.xConnectPackageButton.Click += new System.EventHandler(this.xConnectPackageButton_Click);
            // 
            // configTextBox
            // 
            this.configTextBox.Location = new System.Drawing.Point(143, 46);
            this.configTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.configTextBox.Name = "configTextBox";
            this.configTextBox.Size = new System.Drawing.Size(313, 22);
            this.configTextBox.TabIndex = 10;
            // 
            // sitecorePackageButton
            // 
            this.sitecorePackageButton.Location = new System.Drawing.Point(465, 78);
            this.sitecorePackageButton.Margin = new System.Windows.Forms.Padding(4);
            this.sitecorePackageButton.Name = "sitecorePackageButton";
            this.sitecorePackageButton.Size = new System.Drawing.Size(40, 25);
            this.sitecorePackageButton.TabIndex = 0;
            this.sitecorePackageButton.Text = "...";
            this.sitecorePackageButton.UseVisualStyleBackColor = true;
            this.sitecorePackageButton.Click += new System.EventHandler(this.sitecorePackage_Click);
            // 
            // licenseLabel
            // 
            this.licenseLabel.AutoSize = true;
            this.licenseLabel.Location = new System.Drawing.Point(8, 14);
            this.licenseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.licenseLabel.Name = "licenseLabel";
            this.licenseLabel.Size = new System.Drawing.Size(89, 17);
            this.licenseLabel.TabIndex = 2;
            this.licenseLabel.Text = "License XML";
            // 
            // configFolderButton
            // 
            this.configFolderButton.Location = new System.Drawing.Point(465, 46);
            this.configFolderButton.Margin = new System.Windows.Forms.Padding(4);
            this.configFolderButton.Name = "configFolderButton";
            this.configFolderButton.Size = new System.Drawing.Size(40, 25);
            this.configFolderButton.TabIndex = 0;
            this.configFolderButton.Text = "...";
            this.configFolderButton.UseVisualStyleBackColor = true;
            this.configFolderButton.Click += new System.EventHandler(this.configFolderButton_Click);
            // 
            // licenseTextBox
            // 
            this.licenseTextBox.Location = new System.Drawing.Point(143, 7);
            this.licenseTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.licenseTextBox.Name = "licenseTextBox";
            this.licenseTextBox.Size = new System.Drawing.Size(313, 22);
            this.licenseTextBox.TabIndex = 1;
            // 
            // licenseFolderButton
            // 
            this.licenseFolderButton.Location = new System.Drawing.Point(465, 7);
            this.licenseFolderButton.Margin = new System.Windows.Forms.Padding(4);
            this.licenseFolderButton.Name = "licenseFolderButton";
            this.licenseFolderButton.Size = new System.Drawing.Size(40, 25);
            this.licenseFolderButton.TabIndex = 0;
            this.licenseFolderButton.Text = "...";
            this.licenseFolderButton.UseVisualStyleBackColor = true;
            this.licenseFolderButton.Click += new System.EventHandler(this.licenseFolderButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.hcGenerateCheckbox);
            this.tabPage2.Controls.Add(this.mainFlowPanel);
            this.tabPage2.Controls.Add(this.runButton);
            this.tabPage2.Controls.Add(this.selectFileButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(925, 616);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hardcore Mode";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // hcGenerateCheckbox
            // 
            this.hcGenerateCheckbox.AutoSize = true;
            this.hcGenerateCheckbox.Checked = true;
            this.hcGenerateCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hcGenerateCheckbox.Location = new System.Drawing.Point(723, 572);
            this.hcGenerateCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.hcGenerateCheckbox.Name = "hcGenerateCheckbox";
            this.hcGenerateCheckbox.Size = new System.Drawing.Size(149, 21);
            this.hcGenerateCheckbox.TabIndex = 5;
            this.hcGenerateCheckbox.Text = "Generate File Only";
            this.hcGenerateCheckbox.UseVisualStyleBackColor = true;
            // 
            // mainFlowPanel
            // 
            this.mainFlowPanel.AutoScroll = true;
            this.mainFlowPanel.BackColor = System.Drawing.SystemColors.Control;
            this.mainFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.mainFlowPanel.Location = new System.Drawing.Point(8, 60);
            this.mainFlowPanel.Margin = new System.Windows.Forms.Padding(4);
            this.mainFlowPanel.Name = "mainFlowPanel";
            this.mainFlowPanel.Size = new System.Drawing.Size(907, 492);
            this.mainFlowPanel.TabIndex = 4;
            this.mainFlowPanel.WrapContents = false;
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(8, 560);
            this.runButton.Margin = new System.Windows.Forms.Padding(4);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(705, 46);
            this.runButton.TabIndex = 2;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click_1);
            // 
            // selectFileButton
            // 
            this.selectFileButton.Location = new System.Drawing.Point(8, 7);
            this.selectFileButton.Margin = new System.Windows.Forms.Padding(4);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(907, 46);
            this.selectFileButton.TabIndex = 3;
            this.selectFileButton.Text = "Select a SIF JSON File";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click_1);
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
            this.tabPage3.Size = new System.Drawing.Size(925, 616);
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
            this.instancesListBox.FormattingEnabled = true;
            this.instancesListBox.ItemHeight = 16;
            this.instancesListBox.Location = new System.Drawing.Point(17, 43);
            this.instancesListBox.Margin = new System.Windows.Forms.Padding(4);
            this.instancesListBox.Name = "instancesListBox";
            this.instancesListBox.Size = new System.Drawing.Size(180, 324);
            this.instancesListBox.TabIndex = 0;
            this.instancesListBox.SelectedValueChanged += new System.EventHandler(this.instancesListBox_SelectedValueChanged);
            // 
            // ezFolderDialog
            // 
            this.ezFolderDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // instanceListWatcher
            // 
            this.instanceListWatcher.EnableRaisingEvents = true;
            this.instanceListWatcher.SynchronizingObject = this;
            this.instanceListWatcher.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 674);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "SIF-less";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.instanceListWatcher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog selectConfigDialog;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.FlowLayoutPanel mainFlowPanel;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.OpenFileDialog ezFileDialog;
        private System.Windows.Forms.FolderBrowserDialog ezFolderDialog;
        private System.Windows.Forms.CheckBox hcGenerateCheckbox;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox instancesListBox;
        private System.Windows.Forms.Label instancePrefixLabel;
        private System.IO.FileSystemWatcher instanceListWatcher;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.LinkLabel manageConnectionProfileLink;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox ezGenOnlyCheckbox;
        private System.Windows.Forms.Button installButton;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Label sqlPasswordLabel;
        private System.Windows.Forms.Label sqlLoginLabel;
        private System.Windows.Forms.Label sqlServerLabel;
        private System.Windows.Forms.Label solrServiceLabel;
        private System.Windows.Forms.Label solrFolderLabel;
        private System.Windows.Forms.Label solrUrlLabel;
        private System.Windows.Forms.Label xConnectSiteNameLabel;
        private System.Windows.Forms.Label siteNameLabel;
        private System.Windows.Forms.Label installPrefixLabel;
        private System.Windows.Forms.Label xConnectPackageLabel;
        private System.Windows.Forms.Label scPackageLabel;
        private System.Windows.Forms.Label configLabel;
        private System.Windows.Forms.TextBox sqlPasswordTextBox;
        private System.Windows.Forms.TextBox sqlLoginTextBox;
        private System.Windows.Forms.TextBox sqlServerTextBox;
        private System.Windows.Forms.TextBox solrServiceTextBox;
        private System.Windows.Forms.TextBox solrFolderTextBox;
        private System.Windows.Forms.TextBox solrURLTextBox;
        private System.Windows.Forms.TextBox xConnectName;
        private System.Windows.Forms.TextBox siteNameTextBox;
        private System.Windows.Forms.TextBox prefixTextBox;
        private System.Windows.Forms.TextBox xConnectPackageTextBox;
        private System.Windows.Forms.TextBox sitecorePackageTextBox;
        private System.Windows.Forms.Button solrFolderButton;
        private System.Windows.Forms.Button xConnectPackageButton;
        private System.Windows.Forms.TextBox configTextBox;
        private System.Windows.Forms.Button sitecorePackageButton;
        private System.Windows.Forms.Label licenseLabel;
        private System.Windows.Forms.Button configFolderButton;
        private System.Windows.Forms.TextBox licenseTextBox;
        private System.Windows.Forms.Button licenseFolderButton;
        private System.Windows.Forms.LinkLabel manageSolrLinkButtonsLink;
        private System.Windows.Forms.ComboBox solrListBox;
    }
}

