namespace SIFLess.Forms
{
    partial class Execute
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
            this.components = new System.ComponentModel.Container();
            this.outputTabControl = new System.Windows.Forms.TabControl();
            this.parameterTabPage = new System.Windows.Forms.TabPage();
            this.paramInfoLabel = new System.Windows.Forms.Label();
            this.parameterCheckBoxList = new System.Windows.Forms.CheckedListBox();
            this.runButton = new System.Windows.Forms.Button();
            this.allTab = new System.Windows.Forms.TabPage();
            this.allOutputTextBox = new System.Windows.Forms.RichTextBox();
            this.errorTab = new System.Windows.Forms.TabPage();
            this.errorTextBox = new System.Windows.Forms.RichTextBox();
            this.warningTab = new System.Windows.Forms.TabPage();
            this.warningTextBox = new System.Windows.Forms.RichTextBox();
            this.infoTab = new System.Windows.Forms.TabPage();
            this.infoTextBox = new System.Windows.Forms.RichTextBox();
            this.debugTab = new System.Windows.Forms.TabPage();
            this.debugTextBox = new System.Windows.Forms.RichTextBox();
            this.verboseTab = new System.Windows.Forms.TabPage();
            this.verboseTextBox = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.parameterToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.outputTabControl.SuspendLayout();
            this.parameterTabPage.SuspendLayout();
            this.allTab.SuspendLayout();
            this.errorTab.SuspendLayout();
            this.warningTab.SuspendLayout();
            this.infoTab.SuspendLayout();
            this.debugTab.SuspendLayout();
            this.verboseTab.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // outputTabControl
            // 
            this.outputTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputTabControl.Controls.Add(this.parameterTabPage);
            this.outputTabControl.Controls.Add(this.allTab);
            this.outputTabControl.Controls.Add(this.errorTab);
            this.outputTabControl.Controls.Add(this.warningTab);
            this.outputTabControl.Controls.Add(this.infoTab);
            this.outputTabControl.Controls.Add(this.debugTab);
            this.outputTabControl.Controls.Add(this.verboseTab);
            this.outputTabControl.Location = new System.Drawing.Point(5, 13);
            this.outputTabControl.Name = "outputTabControl";
            this.outputTabControl.SelectedIndex = 0;
            this.outputTabControl.Size = new System.Drawing.Size(1004, 651);
            this.outputTabControl.TabIndex = 2;
            // 
            // parameterTabPage
            // 
            this.parameterTabPage.Controls.Add(this.paramInfoLabel);
            this.parameterTabPage.Controls.Add(this.parameterCheckBoxList);
            this.parameterTabPage.Controls.Add(this.runButton);
            this.parameterTabPage.Location = new System.Drawing.Point(4, 22);
            this.parameterTabPage.Name = "parameterTabPage";
            this.parameterTabPage.Size = new System.Drawing.Size(996, 625);
            this.parameterTabPage.TabIndex = 5;
            this.parameterTabPage.Text = "Parameters";
            this.parameterTabPage.UseVisualStyleBackColor = true;
            // 
            // paramInfoLabel
            // 
            this.paramInfoLabel.Location = new System.Drawing.Point(394, 106);
            this.paramInfoLabel.Name = "paramInfoLabel";
            this.paramInfoLabel.Size = new System.Drawing.Size(186, 53);
            this.paramInfoLabel.TabIndex = 2;
            this.paramInfoLabel.Text = "The following switch parameters were detected in the supplied file.  Check the pa" +
    "rameter to pass it in.";
            this.paramInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // parameterCheckBoxList
            // 
            this.parameterCheckBoxList.FormattingEnabled = true;
            this.parameterCheckBoxList.Location = new System.Drawing.Point(420, 162);
            this.parameterCheckBoxList.Name = "parameterCheckBoxList";
            this.parameterCheckBoxList.Size = new System.Drawing.Size(120, 124);
            this.parameterCheckBoxList.TabIndex = 1;
            this.parameterCheckBoxList.MouseMove += new System.Windows.Forms.MouseEventHandler(this.parameterCheckBoxList_MouseMove);
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(420, 292);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(120, 23);
            this.runButton.TabIndex = 0;
            this.runButton.Text = "Run it!";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // allTab
            // 
            this.allTab.Controls.Add(this.allOutputTextBox);
            this.allTab.Location = new System.Drawing.Point(4, 22);
            this.allTab.Name = "allTab";
            this.allTab.Padding = new System.Windows.Forms.Padding(3);
            this.allTab.Size = new System.Drawing.Size(996, 625);
            this.allTab.TabIndex = 0;
            this.allTab.Text = "All Output";
            this.allTab.UseVisualStyleBackColor = true;
            // 
            // allOutputTextBox
            // 
            this.allOutputTextBox.BackColor = System.Drawing.Color.MidnightBlue;
            this.allOutputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allOutputTextBox.Font = new System.Drawing.Font("Lucida Console", 11F);
            this.allOutputTextBox.Location = new System.Drawing.Point(3, 3);
            this.allOutputTextBox.Name = "allOutputTextBox";
            this.allOutputTextBox.Size = new System.Drawing.Size(990, 619);
            this.allOutputTextBox.TabIndex = 0;
            this.allOutputTextBox.Text = "";
            // 
            // errorTab
            // 
            this.errorTab.Controls.Add(this.errorTextBox);
            this.errorTab.Location = new System.Drawing.Point(4, 22);
            this.errorTab.Name = "errorTab";
            this.errorTab.Padding = new System.Windows.Forms.Padding(3);
            this.errorTab.Size = new System.Drawing.Size(996, 625);
            this.errorTab.TabIndex = 1;
            this.errorTab.Text = "Errors";
            this.errorTab.UseVisualStyleBackColor = true;
            // 
            // errorTextBox
            // 
            this.errorTextBox.BackColor = System.Drawing.Color.MidnightBlue;
            this.errorTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.errorTextBox.Font = new System.Drawing.Font("Lucida Console", 11F);
            this.errorTextBox.Location = new System.Drawing.Point(3, 3);
            this.errorTextBox.Name = "errorTextBox";
            this.errorTextBox.Size = new System.Drawing.Size(990, 619);
            this.errorTextBox.TabIndex = 1;
            this.errorTextBox.Text = "";
            // 
            // warningTab
            // 
            this.warningTab.Controls.Add(this.warningTextBox);
            this.warningTab.Location = new System.Drawing.Point(4, 22);
            this.warningTab.Name = "warningTab";
            this.warningTab.Padding = new System.Windows.Forms.Padding(3);
            this.warningTab.Size = new System.Drawing.Size(996, 625);
            this.warningTab.TabIndex = 2;
            this.warningTab.Text = "Warnings";
            this.warningTab.UseVisualStyleBackColor = true;
            // 
            // warningTextBox
            // 
            this.warningTextBox.BackColor = System.Drawing.Color.MidnightBlue;
            this.warningTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.warningTextBox.Font = new System.Drawing.Font("Lucida Console", 11F);
            this.warningTextBox.Location = new System.Drawing.Point(3, 3);
            this.warningTextBox.Name = "warningTextBox";
            this.warningTextBox.Size = new System.Drawing.Size(990, 619);
            this.warningTextBox.TabIndex = 1;
            this.warningTextBox.Text = "";
            // 
            // infoTab
            // 
            this.infoTab.Controls.Add(this.infoTextBox);
            this.infoTab.Location = new System.Drawing.Point(4, 22);
            this.infoTab.Name = "infoTab";
            this.infoTab.Size = new System.Drawing.Size(996, 625);
            this.infoTab.TabIndex = 4;
            this.infoTab.Text = "Info";
            this.infoTab.UseVisualStyleBackColor = true;
            // 
            // infoTextBox
            // 
            this.infoTextBox.BackColor = System.Drawing.Color.MidnightBlue;
            this.infoTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoTextBox.Font = new System.Drawing.Font("Lucida Console", 11F);
            this.infoTextBox.Location = new System.Drawing.Point(0, 0);
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.Size = new System.Drawing.Size(996, 625);
            this.infoTextBox.TabIndex = 1;
            this.infoTextBox.Text = "";
            // 
            // debugTab
            // 
            this.debugTab.Controls.Add(this.debugTextBox);
            this.debugTab.Location = new System.Drawing.Point(4, 22);
            this.debugTab.Name = "debugTab";
            this.debugTab.Size = new System.Drawing.Size(996, 625);
            this.debugTab.TabIndex = 3;
            this.debugTab.Text = "Debug";
            this.debugTab.UseVisualStyleBackColor = true;
            // 
            // debugTextBox
            // 
            this.debugTextBox.BackColor = System.Drawing.Color.MidnightBlue;
            this.debugTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.debugTextBox.Font = new System.Drawing.Font("Lucida Console", 11F);
            this.debugTextBox.Location = new System.Drawing.Point(0, 0);
            this.debugTextBox.Name = "debugTextBox";
            this.debugTextBox.Size = new System.Drawing.Size(996, 625);
            this.debugTextBox.TabIndex = 1;
            this.debugTextBox.Text = "";
            // 
            // verboseTab
            // 
            this.verboseTab.Controls.Add(this.verboseTextBox);
            this.verboseTab.Location = new System.Drawing.Point(4, 22);
            this.verboseTab.Name = "verboseTab";
            this.verboseTab.Padding = new System.Windows.Forms.Padding(3);
            this.verboseTab.Size = new System.Drawing.Size(996, 625);
            this.verboseTab.TabIndex = 6;
            this.verboseTab.Text = "Verbose";
            this.verboseTab.UseVisualStyleBackColor = true;
            // 
            // verboseTextBox
            // 
            this.verboseTextBox.BackColor = System.Drawing.Color.MidnightBlue;
            this.verboseTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.verboseTextBox.Font = new System.Drawing.Font("Lucida Console", 11F);
            this.verboseTextBox.Location = new System.Drawing.Point(3, 3);
            this.verboseTextBox.Name = "verboseTextBox";
            this.verboseTextBox.Size = new System.Drawing.Size(990, 619);
            this.verboseTextBox.TabIndex = 2;
            this.verboseTextBox.Text = "";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 667);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1021, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(200, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(89, 17);
            this.toolStripStatusLabel1.Text = "Waiting to Start";
            // 
            // Execute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 689);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.outputTabControl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Execute";
            this.Text = "SIF-less Executor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Execute_FormClosing);
            this.Load += new System.EventHandler(this.Execute_Load);
            this.outputTabControl.ResumeLayout(false);
            this.parameterTabPage.ResumeLayout(false);
            this.allTab.ResumeLayout(false);
            this.errorTab.ResumeLayout(false);
            this.warningTab.ResumeLayout(false);
            this.infoTab.ResumeLayout(false);
            this.debugTab.ResumeLayout(false);
            this.verboseTab.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl outputTabControl;
        private System.Windows.Forms.TabPage parameterTabPage;
        private System.Windows.Forms.Label paramInfoLabel;
        private System.Windows.Forms.CheckedListBox parameterCheckBoxList;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.TabPage allTab;
        private System.Windows.Forms.RichTextBox allOutputTextBox;
        private System.Windows.Forms.TabPage errorTab;
        private System.Windows.Forms.RichTextBox errorTextBox;
        private System.Windows.Forms.TabPage warningTab;
        private System.Windows.Forms.RichTextBox warningTextBox;
        private System.Windows.Forms.TabPage infoTab;
        private System.Windows.Forms.RichTextBox infoTextBox;
        private System.Windows.Forms.TabPage debugTab;
        private System.Windows.Forms.RichTextBox debugTextBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabPage verboseTab;
        private System.Windows.Forms.RichTextBox verboseTextBox;
        private System.Windows.Forms.ToolTip parameterToolTip;
    }
}