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
            this.label3 = new System.Windows.Forms.Label();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.corePathTextBox = new System.Windows.Forms.TextBox();
            this.setCorePathBox = new System.Windows.Forms.LinkLabel();
            this.serviceComboBox = new System.Windows.Forms.ComboBox();
            this.solrCorePathBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.validationPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.validateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.validationPanel.SuspendLayout();
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
            // validationPanel
            // 
            this.validationPanel.AutoSize = true;
            this.validationPanel.Controls.Add(this.validateButton);
            this.validationPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.validationPanel.Location = new System.Drawing.Point(28, 236);
            this.validationPanel.Name = "validationPanel";
            this.validationPanel.Size = new System.Drawing.Size(346, 50);
            this.validationPanel.TabIndex = 52;
            // 
            // validateButton
            // 
            this.validateButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.validateButton.Location = new System.Drawing.Point(2, 2);
            this.validateButton.Margin = new System.Windows.Forms.Padding(2);
            this.validateButton.Name = "validateButton";
            this.validateButton.Size = new System.Drawing.Size(342, 24);
            this.validateButton.TabIndex = 50;
            this.validateButton.Text = "Create Profile";
            this.validateButton.UseVisualStyleBackColor = true;
            this.validateButton.Click += new System.EventHandler(this.validateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 220);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Validation";
            // 
            // SolrCreateProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 402);
            this.Controls.Add(this.validationPanel);
            this.Controls.Add(this.serviceComboBox);
            this.Controls.Add(this.setCorePathBox);
            this.Controls.Add(this.corePathTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.profileTextBox);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SolrCreateProfile";
            this.Text = "Create Profile";
            this.validationPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox profileTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox corePathTextBox;
        private System.Windows.Forms.LinkLabel setCorePathBox;
        private System.Windows.Forms.ComboBox serviceComboBox;
        private System.Windows.Forms.FolderBrowserDialog solrCorePathBrowser;
        private System.Windows.Forms.FlowLayoutPanel validationPanel;
        private System.Windows.Forms.Button validateButton;
        private System.Windows.Forms.Label label1;
    }
}