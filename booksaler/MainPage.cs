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


using System.IO;
namespace booksaler
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            dgvdata.ContextMenuStrip = cmsdgvshow;
            sc = new SqlConnection("Data Source=.;Initial Catalog=dbbooksaler;Integrated Security=True");
        }
        private void MainPage_Load(object sender, EventArgs e)
        {
            cmbsearch.Text = "book";
        }
        private void btnsearch_Click(object sender, EventArgs e)
        {
            search();
        }    
        private void cmbsearch_SelectedIndexChanged(object sender, EventArgs e)     
        {
          choice = cmbsearch.SelectedIndex;
        }    
        private void btnshow_Click(object sender, EventArgs e)
        {
          Show(); 
        }   
     
    
        private void btnadd_Click(object sender, EventArgs e)      
        {       
            InsertBook insb = new InsertBook();         
            insb.ShowDialog();
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int idnumber = Convert.ToInt32(dgvdata.Rows[dgvdata.SelectedRows[0].Index].Cells[0].Value);
                InsertBook ins = new InsertBook(idnumber);
                ins.ShowDialog();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please Select the Rows In The DataGridView And Then Try To Edit The Rows", "Warning !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("unknown problem", "Warning !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                int idnumber;
                sd = new SqlCommand("exec deletebook @id", sc);
                idnumber = Convert.ToInt32(dgvdata.Rows[dgvdata.SelectedRows[0].Index].Cells[0].Value);

                sd.Parameters.AddWithValue("@id", idnumber);

                sc.Open();
                sd.ExecuteNonQuery();
                sc.Close();

                MessageBox.Show("Deleted Succecfully");

                Show();
            }
            catch (ArgumentOutOfRangeException)
            {

                MessageBox.Show("Please Select the Rows In The DataGridView And Then Try To Delete The Rows", "Warning !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("unknown problem", "Warning !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtsearch_KeyUp(object sender, KeyEventArgs e)
        {
            search();
        }

        private void search()
        {

            switch (choice)
            {
                case 0:
                    sd = new SqlCommand("exec searchbyname @name", sc);
                    break;
                case 1:
                    sd = new SqlCommand("exec searchbypublisher @name", sc);
                    break;
                case 2:
                    sd = new SqlCommand("exec searchbyauthor @name", sc);
                    break;

                default:
                    sd = new SqlCommand("select * from showall", sc);
                    break;
            }
            sd.Parameters.AddWithValue("@name", txtsearch.Text);
            SqlDataAdapter os = new SqlDataAdapter(sd);
            DataSet ds = new DataSet();

            os.Fill(ds, "t1");
            dgvdata.DataSource = ds.Tables["t1"];

            dgvdata.Columns[0].Visible = false;
        }
        private void Show()
        {
            SqlDataAdapter os = new SqlDataAdapter("select * from showall", sc);
            DataSet ds = new DataSet();
            os.Fill(ds, "t1");
            dgvdata.DataSource = ds.Tables["t1"];

            dgvdata.Columns[0].Visible = false;
         
        }
      private SqlConnection sc ;
      private SqlCommand sd;
      private int choice = 0;

    }
}
