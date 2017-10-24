namespace SIFLess
{
    partial class TestWindow
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
            this.licenseLabel = new System.Windows.Forms.Label();
            this.xConnectCertJsonLabel = new System.Windows.Forms.Label();
            this.xConnectXPJsonLabel = new System.Windows.Forms.Label();
            this.xConnectSolrJsonLabel = new System.Windows.Forms.Label();
            this.sitecoreSolrJsonLabel = new System.Windows.Forms.Label();
            this.sitecoreXPJsonLabel = new System.Windows.Forms.Label();
            this.xConnectPackageLabel = new System.Windows.Forms.Label();
            this.sitecorePackageLabel = new System.Windows.Forms.Label();
            this.solrFolderLabel = new System.Windows.Forms.Label();
            this.solrURLLabel = new System.Windows.Forms.Label();
            this.sqlLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.solrServiceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // licenseLabel
            // 
            this.licenseLabel.AutoSize = true;
            this.licenseLabel.Location = new System.Drawing.Point(12, 17);
            this.licenseLabel.Name = "licenseLabel";
            this.licenseLabel.Size = new System.Drawing.Size(93, 13);
            this.licenseLabel.TabIndex = 0;
            this.licenseLabel.Text = "License File Exists";
            // 
            // xConnectCertJsonLabel
            // 
            this.xConnectCertJsonLabel.AutoSize = true;
            this.xConnectCertJsonLabel.Location = new System.Drawing.Point(12, 37);
            this.xConnectCertJsonLabel.Name = "xConnectCertJsonLabel";
            this.xConnectCertJsonLabel.Size = new System.Drawing.Size(154, 13);
            this.xConnectCertJsonLabel.TabIndex = 0;
            this.xConnectCertJsonLabel.Text = "xconnect-createcert.json Exists";
            // 
            // xConnectXPJsonLabel
            // 
            this.xConnectXPJsonLabel.AutoSize = true;
            this.xConnectXPJsonLabel.Location = new System.Drawing.Point(12, 57);
            this.xConnectXPJsonLabel.Name = "xConnectXPJsonLabel";
            this.xConnectXPJsonLabel.Size = new System.Drawing.Size(123, 13);
            this.xConnectXPJsonLabel.TabIndex = 0;
            this.xConnectXPJsonLabel.Text = "xconnect-xp0.json Exists";
            // 
            // xConnectSolrJsonLabel
            // 
            this.xConnectSolrJsonLabel.AutoSize = true;
            this.xConnectSolrJsonLabel.Location = new System.Drawing.Point(12, 77);
            this.xConnectSolrJsonLabel.Name = "xConnectSolrJsonLabel";
            this.xConnectSolrJsonLabel.Size = new System.Drawing.Size(122, 13);
            this.xConnectSolrJsonLabel.TabIndex = 0;
            this.xConnectSolrJsonLabel.Text = "xconnect-solr.json Exists";
            // 
            // sitecoreSolrJsonLabel
            // 
            this.sitecoreSolrJsonLabel.AutoSize = true;
            this.sitecoreSolrJsonLabel.Location = new System.Drawing.Point(12, 97);
            this.sitecoreSolrJsonLabel.Name = "sitecoreSolrJsonLabel";
            this.sitecoreSolrJsonLabel.Size = new System.Drawing.Size(115, 13);
            this.sitecoreSolrJsonLabel.TabIndex = 0;
            this.sitecoreSolrJsonLabel.Text = "sitecore-solr.json Exists";
            // 
            // sitecoreXPJsonLabel
            // 
            this.sitecoreXPJsonLabel.AutoSize = true;
            this.sitecoreXPJsonLabel.Location = new System.Drawing.Point(12, 117);
            this.sitecoreXPJsonLabel.Name = "sitecoreXPJsonLabel";
            this.sitecoreXPJsonLabel.Size = new System.Drawing.Size(119, 13);
            this.sitecoreXPJsonLabel.TabIndex = 0;
            this.sitecoreXPJsonLabel.Text = "sitecore-XP0.json Exists";
            // 
            // xConnectPackageLabel
            // 
            this.xConnectPackageLabel.AutoSize = true;
            this.xConnectPackageLabel.Location = new System.Drawing.Point(12, 137);
            this.xConnectPackageLabel.Name = "xConnectPackageLabel";
            this.xConnectPackageLabel.Size = new System.Drawing.Size(128, 13);
            this.xConnectPackageLabel.TabIndex = 0;
            this.xConnectPackageLabel.Text = "xConnect Package Exists";
            // 
            // sitecorePackageLabel
            // 
            this.sitecorePackageLabel.AutoSize = true;
            this.sitecorePackageLabel.Location = new System.Drawing.Point(12, 157);
            this.sitecorePackageLabel.Name = "sitecorePackageLabel";
            this.sitecorePackageLabel.Size = new System.Drawing.Size(122, 13);
            this.sitecorePackageLabel.TabIndex = 0;
            this.sitecorePackageLabel.Text = "Sitecore Package Exists";
            // 
            // solrFolderLabel
            // 
            this.solrFolderLabel.AutoSize = true;
            this.solrFolderLabel.Location = new System.Drawing.Point(13, 197);
            this.solrFolderLabel.Name = "solrFolderLabel";
            this.solrFolderLabel.Size = new System.Drawing.Size(87, 13);
            this.solrFolderLabel.TabIndex = 0;
            this.solrFolderLabel.Text = "Solr Folder Exists";
            // 
            // solrURLLabel
            // 
            this.solrURLLabel.AutoSize = true;
            this.solrURLLabel.Location = new System.Drawing.Point(12, 177);
            this.solrURLLabel.Name = "solrURLLabel";
            this.solrURLLabel.Size = new System.Drawing.Size(84, 13);
            this.solrURLLabel.TabIndex = 0;
            this.solrURLLabel.Text = "Solr URL Works";
            // 
            // sqlLabel
            // 
            this.sqlLabel.AutoSize = true;
            this.sqlLabel.Location = new System.Drawing.Point(12, 237);
            this.sqlLabel.Name = "sqlLabel";
            this.sqlLabel.Size = new System.Drawing.Size(116, 13);
            this.sqlLabel.TabIndex = 0;
            this.sqlLabel.Text = "SQL Connection works";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // solrServiceLabel
            // 
            this.solrServiceLabel.AutoSize = true;
            this.solrServiceLabel.Location = new System.Drawing.Point(13, 217);
            this.solrServiceLabel.Name = "solrServiceLabel";
            this.solrServiceLabel.Size = new System.Drawing.Size(94, 13);
            this.solrServiceLabel.TabIndex = 0;
            this.solrServiceLabel.Text = "Solr Service Exists";
            // 
            // TestWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 318);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sqlLabel);
            this.Controls.Add(this.solrURLLabel);
            this.Controls.Add(this.solrServiceLabel);
            this.Controls.Add(this.solrFolderLabel);
            this.Controls.Add(this.sitecorePackageLabel);
            this.Controls.Add(this.xConnectPackageLabel);
            this.Controls.Add(this.sitecoreXPJsonLabel);
            this.Controls.Add(this.sitecoreSolrJsonLabel);
            this.Controls.Add(this.xConnectSolrJsonLabel);
            this.Controls.Add(this.xConnectXPJsonLabel);
            this.Controls.Add(this.xConnectCertJsonLabel);
            this.Controls.Add(this.licenseLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TestWindow";
            this.Text = "Shhh. We\'re testing!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label licenseLabel;
        private System.Windows.Forms.Label xConnectCertJsonLabel;
        private System.Windows.Forms.Label xConnectXPJsonLabel;
        private System.Windows.Forms.Label xConnectSolrJsonLabel;
        private System.Windows.Forms.Label sitecoreSolrJsonLabel;
        private System.Windows.Forms.Label sitecoreXPJsonLabel;
        private System.Windows.Forms.Label xConnectPackageLabel;
        private System.Windows.Forms.Label sitecorePackageLabel;
        private System.Windows.Forms.Label solrFolderLabel;
        private System.Windows.Forms.Label solrURLLabel;
        private System.Windows.Forms.Label sqlLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label solrServiceLabel;
    }
}