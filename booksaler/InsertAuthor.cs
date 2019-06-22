using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace booksaler
{
    public partial class InsertAuthor : Form
    {
        public InsertAuthor()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
            SqlConnection sc = new SqlConnection("Data Source=.;Initial Catalog=dbbooksaler;Integrated Security=True");
            SqlCommand scom = new SqlCommand("exec inserauthor @fname, @lname ", sc);

            scom.Parameters.AddWithValue("@fname", txtfname.Text);
            scom.Parameters.AddWithValue("@lname", txtlname.Text);


            sc.Open();
            scom.ExecuteNonQuery();
            sc.Close();                      
            }
            catch (SqlException)
            {
                MessageBox.Show("Faild To Insert Data !!!\n Please Correct Check The Data You had Entered Then Try Again. ", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);          
            }
            catch
            {
                MessageBox.Show("Faild TO Insert The Data !!!\n Unknown Problem", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
