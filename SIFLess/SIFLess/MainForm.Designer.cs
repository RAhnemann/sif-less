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
            this.ezFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ezFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectConfigDialog
            // 
            this.selectConfigDialog.Filter = "JSON Files|*.json";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(700, 524);
            this.tabControl1.TabIndex = 2;
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
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(692, 498);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "EZ Mode";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ezGenOnlyCheckbox
            // 
            this.ezGenOnlyCheckbox.AutoSize = true;
            this.ezGenOnlyCheckbox.Checked = true;
            this.ezGenOnlyCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ezGenOnlyCheckbox.Location = new System.Drawing.Point(349, 439);
            this.ezGenOnlyCheckbox.Name = "ezGenOnlyCheckbox";
            this.ezGenOnlyCheckbox.Size = new System.Drawing.Size(113, 17);
            this.ezGenOnlyCheckbox.TabIndex = 140;
            this.ezGenOnlyCheckbox.Text = "Generate File Only";
            this.ezGenOnlyCheckbox.UseVisualStyleBackColor = true;
            // 
            // installButton
            // 
            this.installButton.Location = new System.Drawing.Point(25, 420);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(318, 52);
            this.installButton.TabIndex = 150;
            this.installButton.Text = "Install";
            this.installButton.UseVisualStyleBackColor = true;
            this.installButton.Click += new System.EventHandler(this.installButton_Click);
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(25, 362);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(318, 52);
            this.testButton.TabIndex = 130;
            this.testButton.Text = "Test";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // sqlPasswordLabel
            // 
            this.sqlPasswordLabel.AutoSize = true;
            this.sqlPasswordLabel.Location = new System.Drawing.Point(6, 332);
            this.sqlPasswordLabel.Name = "sqlPasswordLabel";
            this.sqlPasswordLabel.Size = new System.Drawing.Size(77, 13);
            this.sqlPasswordLabel.TabIndex = 2;
            this.sqlPasswordLabel.Text = "SQL Password";
            // 
            // sqlLoginLabel
            // 
            this.sqlLoginLabel.AutoSize = true;
            this.sqlLoginLabel.Location = new System.Drawing.Point(6, 306);
            this.sqlLoginLabel.Name = "sqlLoginLabel";
            this.sqlLoginLabel.Size = new System.Drawing.Size(57, 13);
            this.sqlLoginLabel.TabIndex = 2;
            this.sqlLoginLabel.Text = "SQL Login";
            // 
            // sqlServerLabel
            // 
            this.sqlServerLabel.AutoSize = true;
            this.sqlServerLabel.Location = new System.Drawing.Point(6, 280);
            this.sqlServerLabel.Name = "sqlServerLabel";
            this.sqlServerLabel.Size = new System.Drawing.Size(62, 13);
            this.sqlServerLabel.TabIndex = 2;
            this.sqlServerLabel.Text = "SQL Server";
            // 
            // solrServiceLabel
            // 
            this.solrServiceLabel.AutoSize = true;
            this.solrServiceLabel.Location = new System.Drawing.Point(6, 253);
            this.solrServiceLabel.Name = "solrServiceLabel";
            this.solrServiceLabel.Size = new System.Drawing.Size(64, 13);
            this.solrServiceLabel.TabIndex = 2;
            this.solrServiceLabel.Text = "Solr Service";
            // 
            // solrFolderLabel
            // 
            this.solrFolderLabel.AutoSize = true;
            this.solrFolderLabel.Location = new System.Drawing.Point(6, 227);
            this.solrFolderLabel.Name = "solrFolderLabel";
            this.solrFolderLabel.Size = new System.Drawing.Size(57, 13);
            this.solrFolderLabel.TabIndex = 2;
            this.solrFolderLabel.Text = "Solr Folder";
            // 
            // solrUrlLabel
            // 
            this.solrUrlLabel.AutoSize = true;
            this.solrUrlLabel.Location = new System.Drawing.Point(6, 201);
            this.solrUrlLabel.Name = "solrUrlLabel";
            this.solrUrlLabel.Size = new System.Drawing.Size(50, 13);
            this.solrUrlLabel.TabIndex = 2;
            this.solrUrlLabel.Text = "Solr URL";
            // 
            // xConnectSiteNameLabel
            // 
            this.xConnectSiteNameLabel.AutoSize = true;
            this.xConnectSiteNameLabel.Location = new System.Drawing.Point(6, 172);
            this.xConnectSiteNameLabel.Name = "xConnectSiteNameLabel";
            this.xConnectSiteNameLabel.Size = new System.Drawing.Size(83, 13);
            this.xConnectSiteNameLabel.TabIndex = 2;
            this.xConnectSiteNameLabel.Text = "xConnect Name";
            // 
            // siteNameLabel
            // 
            this.siteNameLabel.AutoSize = true;
            this.siteNameLabel.Location = new System.Drawing.Point(6, 146);
            this.siteNameLabel.Name = "siteNameLabel";
            this.siteNameLabel.Size = new System.Drawing.Size(56, 13);
            this.siteNameLabel.TabIndex = 2;
            this.siteNameLabel.Text = "Site Name";
            // 
            // installPrefixLabel
            // 
            this.installPrefixLabel.AutoSize = true;
            this.installPrefixLabel.Location = new System.Drawing.Point(6, 120);
            this.installPrefixLabel.Name = "installPrefixLabel";
            this.installPrefixLabel.Size = new System.Drawing.Size(63, 13);
            this.installPrefixLabel.TabIndex = 2;
            this.installPrefixLabel.Text = "Install Prefix";
            // 
            // xConnectPackageLabel
            // 
            this.xConnectPackageLabel.AutoSize = true;
            this.xConnectPackageLabel.Location = new System.Drawing.Point(6, 94);
            this.xConnectPackageLabel.Name = "xConnectPackageLabel";
            this.xConnectPackageLabel.Size = new System.Drawing.Size(98, 13);
            this.xConnectPackageLabel.TabIndex = 2;
            this.xConnectPackageLabel.Text = "xConnect Package";
            // 
            // scPackageLabel
            // 
            this.scPackageLabel.AutoSize = true;
            this.scPackageLabel.Location = new System.Drawing.Point(6, 68);
            this.scPackageLabel.Name = "scPackageLabel";
            this.scPackageLabel.Size = new System.Drawing.Size(92, 13);
            this.scPackageLabel.TabIndex = 2;
            this.scPackageLabel.Text = "Sitecore Package";
            // 
            // configLabel
            // 
            this.configLabel.AutoSize = true;
            this.configLabel.Location = new System.Drawing.Point(6, 42);
            this.configLabel.Name = "configLabel";
            this.configLabel.Size = new System.Drawing.Size(69, 13);
            this.configLabel.TabIndex = 2;
            this.configLabel.Text = "Config Folder";
            // 
            // sqlPasswordTextBox
            // 
            this.sqlPasswordTextBox.Location = new System.Drawing.Point(107, 327);
            this.sqlPasswordTextBox.Name = "sqlPasswordTextBox";
            this.sqlPasswordTextBox.Size = new System.Drawing.Size(236, 20);
            this.sqlPasswordTextBox.TabIndex = 120;
            // 
            // sqlLoginTextBox
            // 
            this.sqlLoginTextBox.Location = new System.Drawing.Point(107, 301);
            this.sqlLoginTextBox.Name = "sqlLoginTextBox";
            this.sqlLoginTextBox.Size = new System.Drawing.Size(236, 20);
            this.sqlLoginTextBox.TabIndex = 110;
            this.sqlLoginTextBox.Text = "sa";
            // 
            // sqlServerTextBox
            // 
            this.sqlServerTextBox.Location = new System.Drawing.Point(107, 275);
            this.sqlServerTextBox.Name = "sqlServerTextBox";
            this.sqlServerTextBox.Size = new System.Drawing.Size(236, 20);
            this.sqlServerTextBox.TabIndex = 100;
            this.sqlServerTextBox.Text = ".\\SQL2016";
            // 
            // solrServiceTextBox
            // 
            this.solrServiceTextBox.Location = new System.Drawing.Point(107, 248);
            this.solrServiceTextBox.Name = "solrServiceTextBox";
            this.solrServiceTextBox.Size = new System.Drawing.Size(236, 20);
            this.solrServiceTextBox.TabIndex = 90;
            this.solrServiceTextBox.Text = "Solr-6.6.1";
            // 
            // solrFolderTextBox
            // 
            this.solrFolderTextBox.Location = new System.Drawing.Point(107, 222);
            this.solrFolderTextBox.Name = "solrFolderTextBox";
            this.solrFolderTextBox.Size = new System.Drawing.Size(236, 20);
            this.solrFolderTextBox.TabIndex = 80;
            this.solrFolderTextBox.Text = "c:\\Solr-6.6.1\\";
            // 
            // solrURLTextBox
            // 
            this.solrURLTextBox.Location = new System.Drawing.Point(107, 196);
            this.solrURLTextBox.Name = "solrURLTextBox";
            this.solrURLTextBox.Size = new System.Drawing.Size(236, 20);
            this.solrURLTextBox.TabIndex = 70;
            this.solrURLTextBox.Text = "https://localhost:8989/solr";
            // 
            // xConnectName
            // 
            this.xConnectName.Location = new System.Drawing.Point(107, 167);
            this.xConnectName.Name = "xConnectName";
            this.xConnectName.Size = new System.Drawing.Size(236, 20);
            this.xConnectName.TabIndex = 60;
            this.xConnectName.Text = "xp0.xconnect";
            this.xConnectName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.xConnectName_KeyPress);
            // 
            // siteNameTextBox
            // 
            this.siteNameTextBox.Location = new System.Drawing.Point(107, 141);
            this.siteNameTextBox.Name = "siteNameTextBox";
            this.siteNameTextBox.Size = new System.Drawing.Size(236, 20);
            this.siteNameTextBox.TabIndex = 50;
            this.siteNameTextBox.Text = "xp0.sc";
            this.siteNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.siteNameTextBox_KeyPress);
            // 
            // prefixTextBox
            // 
            this.prefixTextBox.Location = new System.Drawing.Point(107, 115);
            this.prefixTextBox.Name = "prefixTextBox";
            this.prefixTextBox.Size = new System.Drawing.Size(236, 20);
            this.prefixTextBox.TabIndex = 40;
            this.prefixTextBox.Text = "xp0";
            this.prefixTextBox.TextChanged += new System.EventHandler(this.prefixTextBox_TextChanged);
            // 
            // xConnectPackageTextBox
            // 
            this.xConnectPackageTextBox.Location = new System.Drawing.Point(107, 89);
            this.xConnectPackageTextBox.Name = "xConnectPackageTextBox";
            this.xConnectPackageTextBox.Size = new System.Drawing.Size(236, 20);
            this.xConnectPackageTextBox.TabIndex = 30;
            // 
            // sitecorePackageTextBox
            // 
            this.sitecorePackageTextBox.Location = new System.Drawing.Point(107, 63);
            this.sitecorePackageTextBox.Name = "sitecorePackageTextBox";
            this.sitecorePackageTextBox.Size = new System.Drawing.Size(236, 20);
            this.sitecorePackageTextBox.TabIndex = 20;
            // 
            // solrFolderButton
            // 
            this.solrFolderButton.Location = new System.Drawing.Point(349, 222);
            this.solrFolderButton.Name = "solrFolderButton";
            this.solrFolderButton.Size = new System.Drawing.Size(30, 20);
            this.solrFolderButton.TabIndex = 0;
            this.solrFolderButton.Text = "...";
            this.solrFolderButton.UseVisualStyleBackColor = true;
            this.solrFolderButton.Click += new System.EventHandler(this.solrFolderButton_Click);
            // 
            // xConnectPackageButton
            // 
            this.xConnectPackageButton.Location = new System.Drawing.Point(349, 89);
            this.xConnectPackageButton.Name = "xConnectPackageButton";
            this.xConnectPackageButton.Size = new System.Drawing.Size(30, 20);
            this.xConnectPackageButton.TabIndex = 0;
            this.xConnectPackageButton.Text = "...";
            this.xConnectPackageButton.UseVisualStyleBackColor = true;
            this.xConnectPackageButton.Click += new System.EventHandler(this.xConnectPackageButton_Click);
            // 
            // configTextBox
            // 
            this.configTextBox.Location = new System.Drawing.Point(107, 37);
            this.configTextBox.Name = "configTextBox";
            this.configTextBox.Size = new System.Drawing.Size(236, 20);
            this.configTextBox.TabIndex = 10;
            // 
            // sitecorePackageButton
            // 
            this.sitecorePackageButton.Location = new System.Drawing.Point(349, 63);
            this.sitecorePackageButton.Name = "sitecorePackageButton";
            this.sitecorePackageButton.Size = new System.Drawing.Size(30, 20);
            this.sitecorePackageButton.TabIndex = 0;
            this.sitecorePackageButton.Text = "...";
            this.sitecorePackageButton.UseVisualStyleBackColor = true;
            this.sitecorePackageButton.Click += new System.EventHandler(this.sitecorePackage_Click);
            // 
            // licenseLabel
            // 
            this.licenseLabel.AutoSize = true;
            this.licenseLabel.Location = new System.Drawing.Point(6, 11);
            this.licenseLabel.Name = "licenseLabel";
            this.licenseLabel.Size = new System.Drawing.Size(69, 13);
            this.licenseLabel.TabIndex = 2;
            this.licenseLabel.Text = "License XML";
            // 
            // configFolderButton
            // 
            this.configFolderButton.Location = new System.Drawing.Point(349, 37);
            this.configFolderButton.Name = "configFolderButton";
            this.configFolderButton.Size = new System.Drawing.Size(30, 20);
            this.configFolderButton.TabIndex = 0;
            this.configFolderButton.Text = "...";
            this.configFolderButton.UseVisualStyleBackColor = true;
            this.configFolderButton.Click += new System.EventHandler(this.configFolderButton_Click);
            // 
            // licenseTextBox
            // 
            this.licenseTextBox.Location = new System.Drawing.Point(107, 6);
            this.licenseTextBox.Name = "licenseTextBox";
            this.licenseTextBox.Size = new System.Drawing.Size(236, 20);
            this.licenseTextBox.TabIndex = 1;
            // 
            // licenseFolderButton
            // 
            this.licenseFolderButton.Location = new System.Drawing.Point(349, 6);
            this.licenseFolderButton.Name = "licenseFolderButton";
            this.licenseFolderButton.Size = new System.Drawing.Size(30, 20);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(692, 498);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hardcore Mode";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // hcGenerateCheckbox
            // 
            this.hcGenerateCheckbox.AutoSize = true;
            this.hcGenerateCheckbox.Checked = true;
            this.hcGenerateCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hcGenerateCheckbox.Location = new System.Drawing.Point(542, 465);
            this.hcGenerateCheckbox.Name = "hcGenerateCheckbox";
            this.hcGenerateCheckbox.Size = new System.Drawing.Size(113, 17);
            this.hcGenerateCheckbox.TabIndex = 5;
            this.hcGenerateCheckbox.Text = "Generate File Only";
            this.hcGenerateCheckbox.UseVisualStyleBackColor = true;
            // 
            // mainFlowPanel
            // 
            this.mainFlowPanel.AutoScroll = true;
            this.mainFlowPanel.BackColor = System.Drawing.SystemColors.Control;
            this.mainFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.mainFlowPanel.Location = new System.Drawing.Point(6, 49);
            this.mainFlowPanel.Name = "mainFlowPanel";
            this.mainFlowPanel.Size = new System.Drawing.Size(680, 400);
            this.mainFlowPanel.TabIndex = 4;
            this.mainFlowPanel.WrapContents = false;
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(6, 455);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(529, 37);
            this.runButton.TabIndex = 2;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click_1);
            // 
            // selectFileButton
            // 
            this.selectFileButton.Location = new System.Drawing.Point(6, 6);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(680, 37);
            this.selectFileButton.TabIndex = 3;
            this.selectFileButton.Text = "Select a SIF JSON File";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click_1);
            // 
            // ezFolderDialog
            // 
            this.ezFolderDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 548);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "SIF-Less";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog selectConfigDialog;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label solrUrlLabel;
        private System.Windows.Forms.Label siteNameLabel;
        private System.Windows.Forms.Label installPrefixLabel;
        private System.Windows.Forms.Label scPackageLabel;
        private System.Windows.Forms.Label configLabel;
        private System.Windows.Forms.TextBox solrURLTextBox;
        private System.Windows.Forms.TextBox siteNameTextBox;
        private System.Windows.Forms.TextBox prefixTextBox;
        private System.Windows.Forms.TextBox sitecorePackageTextBox;
        private System.Windows.Forms.TextBox configTextBox;
        private System.Windows.Forms.Button sitecorePackageButton;
        private System.Windows.Forms.Label licenseLabel;
        private System.Windows.Forms.Button configFolderButton;
        private System.Windows.Forms.TextBox licenseTextBox;
        private System.Windows.Forms.Button licenseFolderButton;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.FlowLayoutPanel mainFlowPanel;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.Button installButton;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Label sqlPasswordLabel;
        private System.Windows.Forms.Label sqlLoginLabel;
        private System.Windows.Forms.Label sqlServerLabel;
        private System.Windows.Forms.Label solrFolderLabel;
        private System.Windows.Forms.Label xConnectSiteNameLabel;
        private System.Windows.Forms.TextBox sqlPasswordTextBox;
        private System.Windows.Forms.TextBox sqlLoginTextBox;
        private System.Windows.Forms.TextBox sqlServerTextBox;
        private System.Windows.Forms.TextBox solrFolderTextBox;
        private System.Windows.Forms.TextBox xConnectName;
        private System.Windows.Forms.Button solrFolderButton;
        private System.Windows.Forms.Label xConnectPackageLabel;
        private System.Windows.Forms.TextBox xConnectPackageTextBox;
        private System.Windows.Forms.Button xConnectPackageButton;
        private System.Windows.Forms.OpenFileDialog ezFileDialog;
        private System.Windows.Forms.FolderBrowserDialog ezFolderDialog;
        private System.Windows.Forms.Label solrServiceLabel;
        private System.Windows.Forms.TextBox solrServiceTextBox;
        private System.Windows.Forms.CheckBox ezGenOnlyCheckbox;
        private System.Windows.Forms.CheckBox hcGenerateCheckbox;
    }
}

