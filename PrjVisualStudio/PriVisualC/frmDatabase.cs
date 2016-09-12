using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace ImagingApp
{
    public partial class frmDatabase : Form
    {
        public frmDatabase()
        {
            InitializeComponent();
        }

        private void frmDatabase_Load(object sender, EventArgs e)

        {
            string connStr;
            connStr = "Data Source=ServerName;Initial Catalog=AdventureWorks2014;Persist Security Info=True;User ID=sa;Password=YourSecret";

            SqlConnection db = new SqlConnection(connStr);

            SqlCommand cmd = new SqlCommand("uspInsertItemMaster", db);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@itemcode", "60500");
            cmd.Parameters.AddWithValue("@itemName", "Simple Max");
            cmd.Parameters.AddWithValue("@categoryCode", 9);
            cmd.Parameters.AddWithValue("@color", "Blue");
                
            //cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50);
            //cmd.Parameters["@Name"].Value = "Name 1";

            try
            {
                db.Open();

                string strServerAck;
                strServerAck  =  Convert.ToString(cmd.ExecuteScalar());

                MessageBox.Show(strServerAck + " is acknowledged");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

                throw ex.GetBaseException();
            }
            finally
            {
                db.Close();
            }

        }

    }
}
