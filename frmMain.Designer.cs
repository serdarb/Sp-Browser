namespace SpBrowser
{
    partial class frmMain
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
            this.cbDatabases = new System.Windows.Forms.ComboBox();
            this.lblSp = new System.Windows.Forms.ListBox();
            this.txtCriteria = new System.Windows.Forms.TextBox();
            this.txtSpText = new System.Windows.Forms.RichTextBox();
            this.lblDbName = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblSpName = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setConnectingStringsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblOpenStudio = new System.Windows.Forms.LinkLabel();
            this.browseTablesColumnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbDatabases
            // 
            this.cbDatabases.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDatabases.FormattingEnabled = true;
            this.cbDatabases.Location = new System.Drawing.Point(22, 60);
            this.cbDatabases.Margin = new System.Windows.Forms.Padding(4);
            this.cbDatabases.Name = "cbDatabases";
            this.cbDatabases.Size = new System.Drawing.Size(408, 32);
            this.cbDatabases.TabIndex = 0;
            this.cbDatabases.SelectedIndexChanged += new System.EventHandler(this.cbDatabases_SelectedIndexChanged);
            // 
            // lblSp
            // 
            this.lblSp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSp.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSp.FormattingEnabled = true;
            this.lblSp.ItemHeight = 22;
            this.lblSp.Location = new System.Drawing.Point(22, 179);
            this.lblSp.Margin = new System.Windows.Forms.Padding(4);
            this.lblSp.Name = "lblSp";
            this.lblSp.Size = new System.Drawing.Size(408, 488);
            this.lblSp.TabIndex = 1;
            this.lblSp.SelectedIndexChanged += new System.EventHandler(this.lbSp_SelectedIndexChanged);
            // 
            // txtCriteria
            // 
            this.txtCriteria.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCriteria.Location = new System.Drawing.Point(22, 120);
            this.txtCriteria.Margin = new System.Windows.Forms.Padding(4);
            this.txtCriteria.Name = "txtCriteria";
            this.txtCriteria.Size = new System.Drawing.Size(408, 32);
            this.txtCriteria.TabIndex = 2;
            this.txtCriteria.TextChanged += new System.EventHandler(this.txtCriteria_TextChanged);
            // 
            // txtSpText
            // 
            this.txtSpText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSpText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpText.Location = new System.Drawing.Point(438, 60);
            this.txtSpText.Margin = new System.Windows.Forms.Padding(4);
            this.txtSpText.Name = "txtSpText";
            this.txtSpText.Size = new System.Drawing.Size(1165, 614);
            this.txtSpText.TabIndex = 3;
            this.txtSpText.Text = "";
            // 
            // lblDbName
            // 
            this.lblDbName.AutoSize = true;
            this.lblDbName.Location = new System.Drawing.Point(18, 37);
            this.lblDbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDbName.Name = "lblDbName";
            this.lblDbName.Size = new System.Drawing.Size(90, 19);
            this.lblDbName.TabIndex = 4;
            this.lblDbName.Text = "Databases";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(18, 97);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(99, 19);
            this.lblSearch.TabIndex = 5;
            this.lblSearch.Text = "Search all";
            // 
            // lblSpName
            // 
            this.lblSpName.AutoSize = true;
            this.lblSpName.Location = new System.Drawing.Point(18, 156);
            this.lblSpName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpName.Name = "lblSpName";
            this.lblSpName.Size = new System.Drawing.Size(162, 19);
            this.lblSpName.TabIndex = 6;
            this.lblSpName.Text = "Stored Procedures";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(434, 37);
            this.lblCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(45, 19);
            this.lblCode.TabIndex = 7;
            this.lblCode.Text = "Code";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1622, 25);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setConnectingStringsToolStripMenuItem,
            this.browseTablesColumnsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(61, 19);
            this.menuToolStripMenuItem.Text = "Options";
            // 
            // setConnectingStringsToolStripMenuItem
            // 
            this.setConnectingStringsToolStripMenuItem.Name = "setConnectingStringsToolStripMenuItem";
            this.setConnectingStringsToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.setConnectingStringsToolStripMenuItem.Text = "Set Connection String";
            this.setConnectingStringsToolStripMenuItem.Click += new System.EventHandler(this.setConnectingStringsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblOpenStudio
            // 
            this.lblOpenStudio.AutoSize = true;
            this.lblOpenStudio.Location = new System.Drawing.Point(1369, 37);
            this.lblOpenStudio.Name = "lblOpenStudio";
            this.lblOpenStudio.Size = new System.Drawing.Size(207, 19);
            this.lblOpenStudio.TabIndex = 12;
            this.lblOpenStudio.TabStop = true;
            this.lblOpenStudio.Text = "open management studio";
            this.lblOpenStudio.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblOpenStudio_LinkClicked);
            // 
            // browseTablesColumnsToolStripMenuItem
            // 
            this.browseTablesColumnsToolStripMenuItem.Name = "browseTablesColumnsToolStripMenuItem";
            this.browseTablesColumnsToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.browseTablesColumnsToolStripMenuItem.Text = "Browse Tables and Columns";
            this.browseTablesColumnsToolStripMenuItem.Click += new System.EventHandler(this.browseTablesColumnsToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1622, 696);
            this.Controls.Add(this.lblOpenStudio);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.lblSpName);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblDbName);
            this.Controls.Add(this.txtSpText);
            this.Controls.Add(this.txtCriteria);
            this.Controls.Add(this.lblSp);
            this.Controls.Add(this.cbDatabases);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "SpBrowser - Sql Server Stored Procedure Browser";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDatabases;
        private System.Windows.Forms.ListBox lblSp;
        private System.Windows.Forms.TextBox txtCriteria;
        private System.Windows.Forms.RichTextBox txtSpText;
        private System.Windows.Forms.Label lblDbName;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblSpName;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setConnectingStringsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.LinkLabel lblOpenStudio;
        private System.Windows.Forms.ToolStripMenuItem browseTablesColumnsToolStripMenuItem;
    }
}

