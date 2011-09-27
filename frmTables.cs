using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SpBrowser.Properties;

namespace SpBrowser
{
    public partial class frmTables : Form
    {
        public frmTables()
        {
            InitializeComponent();

        }

        public string DbName { get; set; }

        private void txtCriteria_TextChanged(object sender, EventArgs e)
        {
            if (chkColumns.Checked)
            {
                lstTables.Items.Clear();

                Works.RunIfDbExists(delegate()
                {
                    SqlDataAdapter da = new SqlDataAdapter(
                        string.Format(@"USE {0}; SELECT c.name +' ('+t.name+')' ad FROM sys.tables AS t INNER JOIN sys.columns c ON t.OBJECT_ID = c.OBJECT_ID WHERE c.name LIKE '%{1}';",
                                        DbName, GetMyFilter()), Settings.Default.cnnStr);

                    DataTable dtTables = new DataTable();
                    da.Fill(dtTables);

                    lstColumns.DataSource = dtTables;
                    lstColumns.DisplayMember = "ad";
                    lstColumns.ValueMember = "ad";

                    label1.Text = string.Format("Columns ({0})", lstColumns.Items.Count);
                }, DbName);
            }
            else
            {
                Works.RunIfDbExists(delegate()
                {
                    SqlDataAdapter da = new SqlDataAdapter(
                        string.Format(@"USE {0}; SELECT name ad 
                                                        FROM sys.objects 
                                                        WHERE type = 'U' and name like '%{1}';",
                                        DbName, GetMyFilter()), Settings.Default.cnnStr);

                    DataTable dtTables = new DataTable();
                    da.Fill(dtTables);

                    lstTables.DataSource = dtTables;
                    lstTables.DisplayMember = "ad";
                    lstTables.ValueMember = "ad";

                    lblSpName.Text = string.Format("Tables ({0})", lstTables.Items.Count);
                }, DbName);
            }


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

        private void lstTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!lblSearch.Text.Contains("("))
                lblSearch.Text += " ( in " + DbName + " )";

            ListBox myLb = (ListBox)lstTables;
            if (myLb.Text != "System.Data.DataRowView")
            {
                Works.RunIfDbExists(GetColumnsByTable, DbName);
            }
        }

        private void GetColumnsByTable()
        {
            SqlDataAdapter da = new SqlDataAdapter(
                     string.Format(@"USE {0}; SELECT name ad FROM sys.columns
                                    WHERE OBJECT_NAME(sys.columns.OBJECT_ID) = '{1}';",
                                     DbName, lstTables.Text.Trim()), Settings.Default.cnnStr);

            DataTable dtColumns = new DataTable();
            da.Fill(dtColumns);

            lstColumns.DataSource = dtColumns;
            lstColumns.DisplayMember = "ad";
            lstColumns.ValueMember = "ad";

            label1.Text = string.Format("Columns ({0})", lstColumns.Items.Count);
        }
    }
}
