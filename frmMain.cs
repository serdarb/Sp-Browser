using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using SpBrowser.Properties;
using System.Diagnostics;
using System.Drawing;

namespace SpBrowser
{
    public partial class frmMain : Form
    {


        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            FromLoadAction();
        }

        private void FromLoadAction()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT [name] FROM [master].[sys].[databases]", Settings.Default.cnnStr);

                da.SelectCommand.Connection.Open();
                if (da.SelectCommand.Connection.State == ConnectionState.Open)
                {
                    da.SelectCommand.Connection.Close();
                }

                DataTable dtDatabases = new DataTable();
                da.Fill(dtDatabases);

                cbDatabases.DataSource = dtDatabases;
                cbDatabases.DisplayMember = "name";
                cbDatabases.ValueMember = "name";
            }
            catch
            {
                MsgConnectionError();
            }
        }

        private void MsgConnectionError()
        {
            MessageBox.Show("Couldn't connect to db...", "Connection Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            frmSettings frm = new frmSettings();
            frm.ShowDialog();

            FromLoadAction();
        }

        private void cbDatabases_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox mycb = (ComboBox)sender;
            if (!string.IsNullOrEmpty(mycb.Text)
                && mycb.Text != "System.Data.DataRowView")
            {
                Works.RunIfDbExists(GetSPList, cbDatabases.Text.Trim());
            }
        }

        private void GetSPList()
        {
            SqlDataAdapter da = new SqlDataAdapter(
                string.Format(@"USE {0};
                                SELECT DISTINCT OBJECT_NAME(id) as ad,id  
                                    FROM syscomments                
                                    WHERE OBJECTPROPERTY(id, 'IsProcedure') = 1 
                                    AND OBJECT_NAME(id) LIKE '%{1}';",
                                    cbDatabases.Text.Trim(), GetMyFilter()), Settings.Default.cnnStr);

            DataTable dtProc = new DataTable();

            da.Fill(dtProc);

            lblSp.DataSource = dtProc;
            lblSp.DisplayMember = "ad";
            lblSp.ValueMember = "id";

            lblSpName.Text = string.Format("Stored Procedures ({0})", lblSp.Items.Count);
        }

        private string GetMyFilter()
        {
            string[] keywords = txtCriteria.Text.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string myFilter = string.Empty;
            for (int i = 0; i < keywords.Length; i++)
            {
                myFilter += keywords[i] + "%";
            }
            return myFilter;
        }

        private void GetSPContents()
        {
            SqlDataAdapter da = new SqlDataAdapter(
                                        string.Format(@"USE {0}; SELECT [text] 
                                                        FROM syscomments 
                                                        WHERE OBJECTPROPERTY(id, 'IsProcedure') = 1 AND OBJECT_NAME(id) = '{1}';",
                                                        cbDatabases.Text.Trim(), lblSp.Text), Settings.Default.cnnStr);

            DataTable myDt = new DataTable();
            da.Fill(myDt);

            txtSpText.Text = string.Empty;

            for (int i = 0; i < myDt.Rows.Count; i++)
            {
                txtSpText.Text += myDt.Rows[i][0].ToString();
            }


            try
            {
                txtSpText.Select(txtSpText.Text.IndexOf(txtCriteria.Text.Trim()), txtCriteria.Text.Trim().Length);
                txtSpText.SelectionBackColor = Color.Yellow;
                txtSpText.Select(0, 0);
            }
            catch { }





        }

        private void lbSp_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox myLb = (ListBox)lblSp;
            if (myLb.Text != "System.Data.DataRowView")
            {
                Works.RunIfDbExists(GetSPContents, cbDatabases.Text.Trim());
            }
        }

        private void txtCriteria_TextChanged(object sender, EventArgs e)
        {
            Works.RunIfDbExists(delegate()
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    string.Format(@"USE {0}; SELECT DISTINCT OBJECT_NAME(id) as ad,id 
                                            FROM syscomments 
                                            WHERE OBJECTPROPERTY(id, 'IsProcedure') = 1
                                                    AND (OBJECT_NAME(id) LIKE '%{1}' OR [text] LIKE '%{1}');",
                                    cbDatabases.Text.Trim(), GetMyFilter()), Settings.Default.cnnStr);

                DataTable dtProcedures = new DataTable();
                da.Fill(dtProcedures);

                lblSp.DataSource = dtProcedures;
                lblSp.DisplayMember = "ad";
                lblSp.ValueMember = "id";

                lblSpName.Text = string.Format("Stored Procedures ({0})", lblSp.Items.Count);
            }, cbDatabases.Text.Trim());


        }

        private void setConnectingStringsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSettings f = new frmSettings();
            f.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblOpenStudio_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SqlConnectionStringBuilder cnn = new SqlConnectionStringBuilder(Settings.Default.cnnStr);
            Process.Start("ssms.exe", String.Format("-nosplash -E -S {0} -d {1}", cnn.DataSource, cnn.InitialCatalog));


        }

        private void browseTablesColumnsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTables frm = new frmTables();
            frm.DbName = cbDatabases.Text.Trim();
            frm.ShowDialog();
        }
    }
}
