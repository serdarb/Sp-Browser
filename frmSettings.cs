using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using SpBrowser.Properties;

namespace SpBrowser
{
    public partial class frmSettings : Form
    {
        public static string myConString { get; set; }
        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmConstrcs_Load(object sender, EventArgs e)
        {            
            txtConString.Text = Settings.Default.cnnStr;
        }

        private void chbAut_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAut.Checked)
            {
                txtConString.Text = "Server=.;Database=master;Trusted_Connection=True;";
            }
            else
            {
                txtConString.Text = "Server=.;Database=master;User ID=myUsername;Password=myPassword;";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection() { ConnectionString = txtConString.Text.Trim() };
                con.Open();
                con.Close();

                Settings.Default["cnnStr"] = txtConString.Text.Trim();

                this.Close();
            }
            catch
            {
                MessageBox.Show("Wrong connecting string!", "Couldn't Connected...", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtConString.Focus();
            }
        }
    }
}
