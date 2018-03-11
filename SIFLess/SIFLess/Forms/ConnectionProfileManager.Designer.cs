namespace SIFLess
{
    partial class ConnectionProfileManager
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
            this.profileGrid = new System.Windows.Forms.DataGridView();
            this.addProfileButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profileGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // profileGrid
            // 
            this.profileGrid.AllowUserToAddRows = false;
            this.profileGrid.AllowUserToResizeRows = false;
            this.profileGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.profileGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.profileGrid.Location = new System.Drawing.Point(12, 12);
            this.profileGrid.MultiSelect = false;
            this.profileGrid.Name = "profileGrid";
            this.profileGrid.RowTemplate.Height = 24;
            this.profileGrid.ShowEditingIcon = false;
            this.profileGrid.ShowRowErrors = false;
            this.profileGrid.Size = new System.Drawing.Size(728, 249);
            this.profileGrid.TabIndex = 0;
            this.profileGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.profileGrid_CellClick);
            // 
            // addProfileButton
            // 
            this.addProfileButton.Location = new System.Drawing.Point(12, 267);
            this.addProfileButton.Name = "addProfileButton";
            this.addProfileButton.Size = new System.Drawing.Size(728, 43);
            this.addProfileButton.TabIndex = 1;
            this.addProfileButton.Text = "Add Profile";
            this.addProfileButton.UseVisualStyleBackColor = true;
            this.addProfileButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConnectionProfileManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 322);
            this.Controls.Add(this.addProfileButton);
            this.Controls.Add(this.profileGrid);
            this.Name = "ConnectionProfileManager";
            this.Text = "SQL Profiles";
            ((System.ComponentModel.ISupportInitialize)(this.profileGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView profileGrid;
        private System.Windows.Forms.Button addProfileButton;
    }
}