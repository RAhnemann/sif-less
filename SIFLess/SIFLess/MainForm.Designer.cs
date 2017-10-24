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
            this.installButton = new System.Windows.Forms.Button();
            this.testButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.label1 = new System.Windows.Forms.Label();
            this.configFolderButton = new System.Windows.Forms.Button();
            this.licenseTextBox = new System.Windows.Forms.TextBox();
            this.licenseFolderButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.mainFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.runButton = new System.Windows.Forms.Button();
            this.selectFileButton = new System.Windows.Forms.Button();
            this.ezFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ezFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.ezGenOnlyCheckbox = new System.Windows.Forms.CheckBox();
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
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
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
            this.tabPage1.Controls.Add(this.label1);
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
            // installButton
            // 
            this.installButton.Location = new System.Drawing.Point(25, 420);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(318, 52);
            this.installButton.TabIndex = 3;
            this.installButton.Text = "Install";
            this.installButton.UseVisualStyleBackColor = true;
            this.installButton.Click += new System.EventHandler(this.installButton_Click);
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(25, 362);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(318, 52);
            this.testButton.TabIndex = 3;
            this.testButton.Text = "Test";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 332);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "SQL Password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 306);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "SQL Login";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "SQL Server";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 253);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Solr Service";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Solr Folder";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Solr URL";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "xConnect Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Site Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Install Prefix";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "xConnect Package";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sitecore Package";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Config Folder";
            // 
            // sqlPasswordTextBox
            // 
            this.sqlPasswordTextBox.Location = new System.Drawing.Point(107, 327);
            this.sqlPasswordTextBox.Name = "sqlPasswordTextBox";
            this.sqlPasswordTextBox.Size = new System.Drawing.Size(236, 20);
            this.sqlPasswordTextBox.TabIndex = 1;
            // 
            // sqlLoginTextBox
            // 
            this.sqlLoginTextBox.Location = new System.Drawing.Point(107, 301);
            this.sqlLoginTextBox.Name = "sqlLoginTextBox";
            this.sqlLoginTextBox.Size = new System.Drawing.Size(236, 20);
            this.sqlLoginTextBox.TabIndex = 1;
            this.sqlLoginTextBox.Text = "sa";
            // 
            // sqlServerTextBox
            // 
            this.sqlServerTextBox.Location = new System.Drawing.Point(107, 275);
            this.sqlServerTextBox.Name = "sqlServerTextBox";
            this.sqlServerTextBox.Size = new System.Drawing.Size(236, 20);
            this.sqlServerTextBox.TabIndex = 1;
            this.sqlServerTextBox.Text = ".\\SQL2016";
            // 
            // solrServiceTextBox
            // 
            this.solrServiceTextBox.Location = new System.Drawing.Point(107, 248);
            this.solrServiceTextBox.Name = "solrServiceTextBox";
            this.solrServiceTextBox.Size = new System.Drawing.Size(236, 20);
            this.solrServiceTextBox.TabIndex = 1;
            this.solrServiceTextBox.Text = "Solr-6.6.1";
            // 
            // solrFolderTextBox
            // 
            this.solrFolderTextBox.Location = new System.Drawing.Point(107, 222);
            this.solrFolderTextBox.Name = "solrFolderTextBox";
            this.solrFolderTextBox.Size = new System.Drawing.Size(236, 20);
            this.solrFolderTextBox.TabIndex = 1;
            this.solrFolderTextBox.Text = "c:\\Solr-6.6.1\\";
            // 
            // solrURLTextBox
            // 
            this.solrURLTextBox.Location = new System.Drawing.Point(107, 196);
            this.solrURLTextBox.Name = "solrURLTextBox";
            this.solrURLTextBox.Size = new System.Drawing.Size(236, 20);
            this.solrURLTextBox.TabIndex = 1;
            this.solrURLTextBox.Text = "https://localhost:8989/solr";
            // 
            // xConnectName
            // 
            this.xConnectName.Location = new System.Drawing.Point(107, 167);
            this.xConnectName.Name = "xConnectName";
            this.xConnectName.Size = new System.Drawing.Size(236, 20);
            this.xConnectName.TabIndex = 1;
            this.xConnectName.Text = "xp0.xconnect";
            this.xConnectName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.xConnectName_KeyPress);
            // 
            // siteNameTextBox
            // 
            this.siteNameTextBox.Location = new System.Drawing.Point(107, 141);
            this.siteNameTextBox.Name = "siteNameTextBox";
            this.siteNameTextBox.Size = new System.Drawing.Size(236, 20);
            this.siteNameTextBox.TabIndex = 1;
            this.siteNameTextBox.Text = "xp0.sc";
            this.siteNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.siteNameTextBox_KeyPress);
            // 
            // prefixTextBox
            // 
            this.prefixTextBox.Location = new System.Drawing.Point(107, 115);
            this.prefixTextBox.Name = "prefixTextBox";
            this.prefixTextBox.Size = new System.Drawing.Size(236, 20);
            this.prefixTextBox.TabIndex = 1;
            this.prefixTextBox.Text = "xp0";
            this.prefixTextBox.TextChanged += new System.EventHandler(this.prefixTextBox_TextChanged);
            // 
            // xConnectPackageTextBox
            // 
            this.xConnectPackageTextBox.Location = new System.Drawing.Point(107, 89);
            this.xConnectPackageTextBox.Name = "xConnectPackageTextBox";
            this.xConnectPackageTextBox.Size = new System.Drawing.Size(236, 20);
            this.xConnectPackageTextBox.TabIndex = 1;
            // 
            // sitecorePackageTextBox
            // 
            this.sitecorePackageTextBox.Location = new System.Drawing.Point(107, 63);
            this.sitecorePackageTextBox.Name = "sitecorePackageTextBox";
            this.sitecorePackageTextBox.Size = new System.Drawing.Size(236, 20);
            this.sitecorePackageTextBox.TabIndex = 1;
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
            this.configTextBox.TabIndex = 1;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "License XML";
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
            this.runButton.Size = new System.Drawing.Size(680, 37);
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
            this.selectFileButton.Text = "Select a File";
            this.selectFileButton.UseVisualStyleBackColor = true;
            // 
            // ezFolderDialog
            // 
            this.ezFolderDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // ezGenOnlyCheckbox
            // 
            this.ezGenOnlyCheckbox.AutoSize = true;
            this.ezGenOnlyCheckbox.Location = new System.Drawing.Point(349, 439);
            this.ezGenOnlyCheckbox.Name = "ezGenOnlyCheckbox";
            this.ezGenOnlyCheckbox.Size = new System.Drawing.Size(113, 17);
            this.ezGenOnlyCheckbox.TabIndex = 4;
            this.ezGenOnlyCheckbox.Text = "Generate File Only";
            this.ezGenOnlyCheckbox.UseVisualStyleBackColor = true;
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
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog selectConfigDialog;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox solrURLTextBox;
        private System.Windows.Forms.TextBox siteNameTextBox;
        private System.Windows.Forms.TextBox prefixTextBox;
        private System.Windows.Forms.TextBox sitecorePackageTextBox;
        private System.Windows.Forms.TextBox configTextBox;
        private System.Windows.Forms.Button sitecorePackageButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button configFolderButton;
        private System.Windows.Forms.TextBox licenseTextBox;
        private System.Windows.Forms.Button licenseFolderButton;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.FlowLayoutPanel mainFlowPanel;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.Button installButton;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox sqlPasswordTextBox;
        private System.Windows.Forms.TextBox sqlLoginTextBox;
        private System.Windows.Forms.TextBox sqlServerTextBox;
        private System.Windows.Forms.TextBox solrFolderTextBox;
        private System.Windows.Forms.TextBox xConnectName;
        private System.Windows.Forms.Button solrFolderButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox xConnectPackageTextBox;
        private System.Windows.Forms.Button xConnectPackageButton;
        private System.Windows.Forms.OpenFileDialog ezFileDialog;
        private System.Windows.Forms.FolderBrowserDialog ezFolderDialog;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox solrServiceTextBox;
        private System.Windows.Forms.CheckBox ezGenOnlyCheckbox;
    }
}

