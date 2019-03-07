namespace SIFLess.Forms
{
    partial class CheckConfigs
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
            this.updateButton = new System.Windows.Forms.Button();
            this.fileCheckboxList = new SIFLess.Forms.CheckConfigs.CustomCheckListBox();
            this.fixButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(12, 415);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(179, 23);
            this.updateButton.TabIndex = 0;
            this.updateButton.Text = "Check for Updates";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // fileCheckboxList
            // 
            this.fileCheckboxList.FormattingEnabled = true;
            this.fileCheckboxList.Location = new System.Drawing.Point(12, 12);
            this.fileCheckboxList.Name = "fileCheckboxList";
            this.fileCheckboxList.Size = new System.Drawing.Size(379, 394);
            this.fileCheckboxList.TabIndex = 1;
            this.fileCheckboxList.SelectedIndexChanged += new System.EventHandler(this.fileCheckboxList_SelectedIndexChanged);
            // 
            // fixButton
            // 
            this.fixButton.Enabled = false;
            this.fixButton.Location = new System.Drawing.Point(197, 415);
            this.fixButton.Name = "fixButton";
            this.fixButton.Size = new System.Drawing.Size(194, 23);
            this.fixButton.TabIndex = 2;
            this.fixButton.Text = "Fix Selected";
            this.fixButton.UseVisualStyleBackColor = true;
            this.fixButton.Click += new System.EventHandler(this.fixButton_Click);
            // 
            // CheckConfigs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 450);
            this.Controls.Add(this.fixButton);
            this.Controls.Add(this.fileCheckboxList);
            this.Controls.Add(this.updateButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckConfigs";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Update Configs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button updateButton;
        private CustomCheckListBox fileCheckboxList;
        private System.Windows.Forms.Button fixButton;
    }
}