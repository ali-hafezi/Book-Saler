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
    public partial class InsertBook : Form
    {
        public InsertBook()
        {
            InitializeComponent();
            id = -1;   
        }
        public InsertBook(int _id)
        {
            InitializeComponent();
            id = _id;
        }


        private void InsertBook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbbooksalerDataSet.tpublisher' table. You can move, or remove it, as needed.
            this.tpublisherTableAdapter.Fill(this.dbbooksalerDataSet.tpublisher);
            // TODO: This line of code loads data into the 'dbbooksalerDataSet.authorview' table. You can move, or remove it, as needed.
            this.authorviewTableAdapter.Fill(this.dbbooksalerDataSet.authorview);

            if (id > 0)
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=dbbooksaler;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from editbook where id = "+ id, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    txtbook.Text = reader.GetValue(1).ToString();
                    txtisbn.Text = reader.GetValue(2).ToString();
                    txtprice.Text = reader.GetValue(3).ToString();
                    txtquantity.Text = reader.GetValue(4).ToString();
                    cmbpublisher.SelectedValue = Convert.ToInt32(reader.GetValue(5));
                    cmbauthor.SelectedValue = Convert.ToInt32(reader.GetValue(6));
                   
                }
                con.Close();
            }

        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            if (id < 0)
            {
                try
                {
                    SqlConnection sc = new SqlConnection("Data Source=.;Initial Catalog=dbbooksaler;Integrated Security=True");
                    SqlCommand scom = new SqlCommand("exec insertbook @name, @isbn, @price ,@quantity ,@pub ,@auth ", sc);
                    scom.Parameters.AddWithValue("@name", txtbook.Text);
                    scom.Parameters.AddWithValue("@isbn", txtisbn.Text);
                    scom.Parameters.AddWithValue("@price", txtprice.Text);
                    scom.Parameters.AddWithValue("@quantity", txtquantity.Text);
                    scom.Parameters.AddWithValue("@pub", cmbpublisher.SelectedValue);
                    scom.Parameters.AddWithValue("@auth", cmbauthor.SelectedValue);
                    sc.Open();
                    scom.ExecuteNonQuery();
                    sc.Close();

                    MessageBox.Show("the data has inserted successfully");
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
            else
            {
               try
               {
                SqlConnection sc = new SqlConnection("Data Source=.;Initial Catalog=dbbooksaler;Integrated Security=True");
                SqlCommand scom = new SqlCommand("exec updatebook "+id+" , @name, @isbn, @price ,@quantity ,@idp ,@ida ", sc);
                scom.Parameters.AddWithValue("@name", txtbook.Text);
                scom.Parameters.AddWithValue("@isbn", txtisbn.Text);
                scom.Parameters.AddWithValue("@price", txtprice.Text);
                scom.Parameters.AddWithValue("@quantity", txtquantity.Text);
                scom.Parameters.AddWithValue("@idp", cmbpublisher.SelectedValue);
                scom.Parameters.AddWithValue("@ida", cmbauthor.SelectedValue);
                sc.Open();
                scom.ExecuteNonQuery();
                sc.Close();

                MessageBox.Show("the data has inserted successfully");                      
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

        private void lnkpublisher_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InsertPulisher insp = new InsertPulisher();
            insp.ShowDialog();

            this.tpublisherTableAdapter.Fill(this.dbbooksalerDataSet.tpublisher);
        }

        private void lnkauthor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InsertAuthor insa = new InsertAuthor();
            insa.ShowDialog();

            this.authorviewTableAdapter.Fill(this.dbbooksalerDataSet.authorview);
        }
        private int id;

        private void txtisbn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar > 47 & e.KeyChar < 58) && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("In This Field You Must Enter Only The Numbers", "Warning !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
                
        }

        private void txtprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar > 47 & e.KeyChar < 58) && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("In This Field You Must Enter Only The Numbers", "Warning !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
                

        }

        private void txtquantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar > 47 & e.KeyChar < 58) && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("In This Field You Must Enter Only The Numbers", "Warning !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
                
        }

        private void lnkdeletepublisher_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                SqlConnection sc = new SqlConnection("Data Source=.;Initial Catalog=dbbooksaler;Integrated Security=True");
                SqlCommand scom = new SqlCommand("exec deletepublisher @id ", sc);
                scom.Parameters.AddWithValue("@id", cmbpublisher.SelectedValue);
                sc.Open();
                scom.ExecuteNonQuery();
                sc.Close();

                this.tpublisherTableAdapter.Fill(this.dbbooksalerDataSet.tpublisher);
            }
            catch
            {
            }
        }

        private void lnkdeleteauthor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                SqlConnection sc = new SqlConnection("Data Source=.;Initial Catalog=dbbooksaler;Integrated Security=True");
                SqlCommand scom = new SqlCommand("exec deleteauthor @id ", sc);
                scom.Parameters.AddWithValue("@id", cmbauthor.SelectedValue);
                sc.Open();
                scom.ExecuteNonQuery();
                sc.Close();

                this.authorviewTableAdapter.Fill(this.dbbooksalerDataSet.authorview);
            }
            catch
            {
            }
        }
    }
}
