namespace SpBrowser
{
    partial class frmSettings
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
            this.lblConStr = new System.Windows.Forms.Label();
            this.txtConString = new System.Windows.Forms.TextBox();
            this.chbAut = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblConStr
            // 
            this.lblConStr.AutoSize = true;
            this.lblConStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblConStr.Location = new System.Drawing.Point(22, 9);
            this.lblConStr.Name = "lblConStr";
            this.lblConStr.Size = new System.Drawing.Size(108, 13);
            this.lblConStr.TabIndex = 0;
            this.lblConStr.Text = "Connection String";
            // 
            // txtConString
            // 
            this.txtConString.Location = new System.Drawing.Point(25, 60);
            this.txtConString.Multiline = true;
            this.txtConString.Name = "txtConString";
            this.txtConString.Size = new System.Drawing.Size(257, 104);
            this.txtConString.TabIndex = 1;
            // 
            // chbAut
            // 
            this.chbAut.AutoSize = true;
            this.chbAut.Location = new System.Drawing.Point(25, 37);
            this.chbAut.Name = "chbAut";
            this.chbAut.Size = new System.Drawing.Size(141, 17);
            this.chbAut.TabIndex = 2;
            this.chbAut.Text = "Windows Authentication";
            this.chbAut.UseVisualStyleBackColor = true;
            this.chbAut.CheckedChanged += new System.EventHandler(this.chbAut_CheckedChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(25, 170);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(105, 34);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 216);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.chbAut);
            this.Controls.Add(this.txtConString);
            this.Controls.Add(this.lblConStr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Set Connecting String";
            this.Load += new System.EventHandler(this.frmConstrcs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConStr;
        private System.Windows.Forms.TextBox txtConString;
        private System.Windows.Forms.CheckBox chbAut;
        private System.Windows.Forms.Button btnSubmit;
    }
}