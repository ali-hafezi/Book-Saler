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
    public partial class InsertPulisher : Form
    {
        public InsertPulisher()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sc = new SqlConnection("Data Source=.;Initial Catalog=dbbooksaler;Integrated Security=True");
                SqlCommand scom = new SqlCommand("exec insertpublisher @name, @phone,@address ", sc);

                scom.Parameters.AddWithValue("@name", txtname.Text);
                scom.Parameters.AddWithValue("@phone", txtphone.Text);
                scom.Parameters.AddWithValue("@address", txtaddress.Text);

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

        private void txtphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar > 47 & e.KeyChar < 58) && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("In This Field You Must Enter Only The Numbers", "Warning !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
