using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SpBrowser.Properties;

namespace SpBrowser
{
    public static class Works
    {
        public delegate void RunningIfDbExist();

        public static void RunIfDbExists(RunningIfDbExist myMethod, string dbName)
        {
            SqlCommand myCommand = new SqlCommand(string.Format(@"USE {0};", dbName),
                                                      new SqlConnection(Settings.Default.cnnStr));
            try
            {
                myCommand.Connection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                myMethod();
            }
            catch (SqlException ex)
            {
                if (myCommand.Connection.State != ConnectionState.Closed)
                {
                    myCommand.Connection.Dispose();
                }

                MessageBox.Show(ex.Message, "Connection Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
