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
            this.outputTabControl = new System.Windows.Forms.TabControl();
            this.allTab = new System.Windows.Forms.TabPage();
            this.errorTab = new System.Windows.Forms.TabPage();
            this.warningTab = new System.Windows.Forms.TabPage();
            this.infoTab = new System.Windows.Forms.TabPage();
            this.debugTab = new System.Windows.Forms.TabPage();
            this.allOutputTextbox = new System.Windows.Forms.RichTextBox();
            this.errorTextbox = new System.Windows.Forms.RichTextBox();
            this.warningTextbox = new System.Windows.Forms.RichTextBox();
            this.infoTextbox = new System.Windows.Forms.RichTextBox();
            this.debugTextbox = new System.Windows.Forms.RichTextBox();
            this.outputTabControl.SuspendLayout();
            this.allTab.SuspendLayout();
            this.errorTab.SuspendLayout();
            this.warningTab.SuspendLayout();
            this.infoTab.SuspendLayout();
            this.debugTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // outputTabControl
            // 
            this.outputTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputTabControl.Controls.Add(this.allTab);
            this.outputTabControl.Controls.Add(this.errorTab);
            this.outputTabControl.Controls.Add(this.warningTab);
            this.outputTabControl.Controls.Add(this.infoTab);
            this.outputTabControl.Controls.Add(this.debugTab);
            this.outputTabControl.Location = new System.Drawing.Point(12, 12);
            this.outputTabControl.Name = "outputTabControl";
            this.outputTabControl.SelectedIndex = 0;
            this.outputTabControl.Size = new System.Drawing.Size(997, 566);
            this.outputTabControl.TabIndex = 0;
            // 
            // allTab
            // 
            this.allTab.Controls.Add(this.allOutputTextbox);
            this.allTab.Location = new System.Drawing.Point(4, 22);
            this.allTab.Name = "allTab";
            this.allTab.Padding = new System.Windows.Forms.Padding(3);
            this.allTab.Size = new System.Drawing.Size(989, 540);
            this.allTab.TabIndex = 0;
            this.allTab.Text = "All Output";
            this.allTab.UseVisualStyleBackColor = true;
            // 
            // errorTab
            // 
            this.errorTab.Controls.Add(this.errorTextbox);
            this.errorTab.Location = new System.Drawing.Point(4, 22);
            this.errorTab.Name = "errorTab";
            this.errorTab.Padding = new System.Windows.Forms.Padding(3);
            this.errorTab.Size = new System.Drawing.Size(989, 540);
            this.errorTab.TabIndex = 1;
            this.errorTab.Text = "Errors";
            this.errorTab.UseVisualStyleBackColor = true;
            // 
            // warningTab
            // 
            this.warningTab.Controls.Add(this.warningTextbox);
            this.warningTab.Location = new System.Drawing.Point(4, 22);
            this.warningTab.Name = "warningTab";
            this.warningTab.Padding = new System.Windows.Forms.Padding(3);
            this.warningTab.Size = new System.Drawing.Size(989, 540);
            this.warningTab.TabIndex = 2;
            this.warningTab.Text = "Warnings";
            this.warningTab.UseVisualStyleBackColor = true;
            // 
            // infoTab
            // 
            this.infoTab.Controls.Add(this.infoTextbox);
            this.infoTab.Location = new System.Drawing.Point(4, 22);
            this.infoTab.Name = "infoTab";
            this.infoTab.Size = new System.Drawing.Size(989, 540);
            this.infoTab.TabIndex = 4;
            this.infoTab.Text = "Info";
            this.infoTab.UseVisualStyleBackColor = true;
            // 
            // debugTab
            // 
            this.debugTab.Controls.Add(this.debugTextbox);
            this.debugTab.Location = new System.Drawing.Point(4, 22);
            this.debugTab.Name = "debugTab";
            this.debugTab.Size = new System.Drawing.Size(989, 540);
            this.debugTab.TabIndex = 3;
            this.debugTab.Text = "Debug";
            this.debugTab.UseVisualStyleBackColor = true;
            // 
            // allOutputTextbox
            // 
            this.allOutputTextbox.BackColor = System.Drawing.Color.MidnightBlue;
            this.allOutputTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allOutputTextbox.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allOutputTextbox.Location = new System.Drawing.Point(3, 3);
            this.allOutputTextbox.Name = "allOutputTextbox";
            this.allOutputTextbox.Size = new System.Drawing.Size(983, 534);
            this.allOutputTextbox.TabIndex = 0;
            this.allOutputTextbox.Text = "";
            // 
            // errorTextbox
            // 
            this.errorTextbox.BackColor = System.Drawing.Color.MidnightBlue;
            this.errorTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.errorTextbox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorTextbox.Location = new System.Drawing.Point(3, 3);
            this.errorTextbox.Name = "errorTextbox";
            this.errorTextbox.Size = new System.Drawing.Size(983, 534);
            this.errorTextbox.TabIndex = 1;
            this.errorTextbox.Text = "";
            // 
            // warningTextbox
            // 
            this.warningTextbox.BackColor = System.Drawing.Color.MidnightBlue;
            this.warningTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.warningTextbox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningTextbox.Location = new System.Drawing.Point(3, 3);
            this.warningTextbox.Name = "warningTextbox";
            this.warningTextbox.Size = new System.Drawing.Size(983, 534);
            this.warningTextbox.TabIndex = 1;
            this.warningTextbox.Text = "";
            // 
            // infoTextbox
            // 
            this.infoTextbox.BackColor = System.Drawing.Color.MidnightBlue;
            this.infoTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoTextbox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoTextbox.Location = new System.Drawing.Point(0, 0);
            this.infoTextbox.Name = "infoTextbox";
            this.infoTextbox.Size = new System.Drawing.Size(989, 540);
            this.infoTextbox.TabIndex = 1;
            this.infoTextbox.Text = "";
            // 
            // debugTextbox
            // 
            this.debugTextbox.BackColor = System.Drawing.Color.MidnightBlue;
            this.debugTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.debugTextbox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debugTextbox.Location = new System.Drawing.Point(0, 0);
            this.debugTextbox.Name = "debugTextbox";
            this.debugTextbox.Size = new System.Drawing.Size(989, 540);
            this.debugTextbox.TabIndex = 1;
            this.debugTextbox.Text = "";
            // 
            // Execute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 590);
            this.Controls.Add(this.outputTabControl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Execute";
            this.Text = "ExecuteForm";
            this.outputTabControl.ResumeLayout(false);
            this.allTab.ResumeLayout(false);
            this.errorTab.ResumeLayout(false);
            this.warningTab.ResumeLayout(false);
            this.infoTab.ResumeLayout(false);
            this.debugTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl outputTabControl;
        private System.Windows.Forms.TabPage allTab;
        private System.Windows.Forms.TabPage warningTab;
        private System.Windows.Forms.TabPage debugTab;
        private System.Windows.Forms.TabPage errorTab;
        private System.Windows.Forms.TabPage infoTab;
        private System.Windows.Forms.RichTextBox allOutputTextbox;
        private System.Windows.Forms.RichTextBox errorTextbox;
        private System.Windows.Forms.RichTextBox warningTextbox;
        private System.Windows.Forms.RichTextBox infoTextbox;
        private System.Windows.Forms.RichTextBox debugTextbox;
    }
}