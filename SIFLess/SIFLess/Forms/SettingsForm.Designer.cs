namespace SIFLess.Forms
{
    partial class SettingsForm
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
            this.updateSettingsCheckbox = new System.Windows.Forms.CheckBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // updateSettingsCheckbox
            // 
            this.updateSettingsCheckbox.AutoSize = true;
            this.updateSettingsCheckbox.Location = new System.Drawing.Point(12, 12);
            this.updateSettingsCheckbox.Name = "updateSettingsCheckbox";
            this.updateSettingsCheckbox.Size = new System.Drawing.Size(167, 17);
            this.updateSettingsCheckbox.TabIndex = 0;
            this.updateSettingsCheckbox.Text = "Check for Updates on Startup";
            this.updateSettingsCheckbox.UseVisualStyleBackColor = true;
            this.updateSettingsCheckbox.CheckedChanged += new System.EventHandler(this.updateSettingsCheckbox_CheckedChanged);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(12, 43);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(176, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 78);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.updateSettingsCheckbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox updateSettingsCheckbox;
        private System.Windows.Forms.Button closeButton;
    }
}