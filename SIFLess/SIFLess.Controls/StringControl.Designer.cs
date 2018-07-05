namespace SIFLess.Controls
{
    partial class StringControl
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.fieldLabel = new System.Windows.Forms.Label();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.fieldTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // fieldLabel
            // 
            this.fieldLabel.AutoSize = true;
            this.fieldLabel.Location = new System.Drawing.Point(3, 5);
            this.fieldLabel.Name = "fieldLabel";
            this.fieldLabel.Size = new System.Drawing.Size(35, 13);
            this.fieldLabel.TabIndex = 0;
            this.fieldLabel.Text = "label1";
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(114, 2);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(143, 20);
            this.valueTextBox.TabIndex = 1;
            this.valueTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valueTextBox_KeyPress);
            // 
            // StringControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.valueTextBox);
            this.Controls.Add(this.fieldLabel);
            this.Name = "StringControl";
            this.Size = new System.Drawing.Size(270, 24);
            this.Load += new System.EventHandler(this.StringControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fieldLabel;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.ToolTip fieldTip;
    }
}
