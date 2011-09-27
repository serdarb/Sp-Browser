namespace SpBrowser
{
    partial class frmTables
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
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtCriteria = new System.Windows.Forms.TextBox();
            this.lblSpName = new System.Windows.Forms.Label();
            this.lstTables = new System.Windows.Forms.ListBox();
            this.lstColumns = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkColumns = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(9, 16);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(54, 13);
            this.lblSearch.TabIndex = 7;
            this.lblSearch.Text = "Search all";
            // 
            // txtCriteria
            // 
            this.txtCriteria.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCriteria.Location = new System.Drawing.Point(13, 39);
            this.txtCriteria.Margin = new System.Windows.Forms.Padding(4);
            this.txtCriteria.Name = "txtCriteria";
            this.txtCriteria.Size = new System.Drawing.Size(347, 32);
            this.txtCriteria.TabIndex = 6;
            this.txtCriteria.TextChanged += new System.EventHandler(this.txtCriteria_TextChanged);
            // 
            // lblSpName
            // 
            this.lblSpName.AutoSize = true;
            this.lblSpName.Location = new System.Drawing.Point(8, 84);
            this.lblSpName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpName.Name = "lblSpName";
            this.lblSpName.Size = new System.Drawing.Size(39, 13);
            this.lblSpName.TabIndex = 9;
            this.lblSpName.Text = "Tables";
            // 
            // lstTables
            // 
            this.lstTables.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstTables.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstTables.FormattingEnabled = true;
            this.lstTables.ItemHeight = 22;
            this.lstTables.Location = new System.Drawing.Point(12, 107);
            this.lstTables.Margin = new System.Windows.Forms.Padding(4);
            this.lstTables.Name = "lstTables";
            this.lstTables.Size = new System.Drawing.Size(348, 466);
            this.lstTables.TabIndex = 8;
            this.lstTables.SelectedIndexChanged += new System.EventHandler(this.lstTables_SelectedIndexChanged);
            // 
            // lstColumns
            // 
            this.lstColumns.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstColumns.FormattingEnabled = true;
            this.lstColumns.ItemHeight = 22;
            this.lstColumns.Location = new System.Drawing.Point(379, 107);
            this.lstColumns.Margin = new System.Windows.Forms.Padding(4);
            this.lstColumns.Name = "lstColumns";
            this.lstColumns.Size = new System.Drawing.Size(548, 466);
            this.lstColumns.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(376, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Columns";
            // 
            // chkColumns
            // 
            this.chkColumns.AutoSize = true;
            this.chkColumns.Location = new System.Drawing.Point(379, 39);
            this.chkColumns.Name = "chkColumns";
            this.chkColumns.Size = new System.Drawing.Size(170, 17);
            this.chkColumns.TabIndex = 12;
            this.chkColumns.Text = "Search Only In Column Names";
            this.chkColumns.UseVisualStyleBackColor = true;
            // 
            // frmTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 597);
            this.Controls.Add(this.chkColumns);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstColumns);
            this.Controls.Add(this.lblSpName);
            this.Controls.Add(this.lstTables);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtCriteria);
            this.Name = "frmTables";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Tables & Columns";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtCriteria;
        private System.Windows.Forms.Label lblSpName;
        private System.Windows.Forms.ListBox lstTables;
        private System.Windows.Forms.ListBox lstColumns;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkColumns;
    }
}