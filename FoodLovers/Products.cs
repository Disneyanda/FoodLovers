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
using System.Data.SqlClient;
using System.IO;

namespace FoodLovers
{
    public partial class Products : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tabis\OneDrive\Documents\FoodLoversMarket.mdf;Integrated Security=True;Connect Timeout=30");

        public void populate()
        {
            conn.Open();

            string slctQuery = "select * from Products";
            SqlDataAdapter sqlAd = new SqlDataAdapter(slctQuery, conn);
            SqlCommandBuilder sqlCb = new SqlCommandBuilder(sqlAd);
            var ds = new DataSet();
            sqlAd.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            conn.Close();
        }
        public Products()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from Products where Id=" + txtId.Text + "", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Product Removed");
            conn.Close();

            populate(); // Refresh list

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            bool isWeighed;
            if (rbYes.Checked)
                isWeighed = true;
            else
                isWeighed = false;
            conn.Open();
            SqlCommand cmd = new SqlCommand("update Products set Name='"+txtName.Text+"',WeightedItem='"+isWeighed+"', SuggestedSellingPrice='"+txtPrice.Text+"' where Id=" + txtId.Text + ";", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Product Updated");
            conn.Close();

            populate();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool isWeighed;
            if (rbYes.Checked)
                isWeighed = true;
            else
                isWeighed= false;

            conn.Open();

            SqlCommand cmd = new SqlCommand("insert into Product values(" + txtId.Text +",'"+txtName.Text+"','"+isWeighed+"','" +txtPrice.Text+ "')", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Product Added");

            conn.Close();

            populate();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtPrice.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            populate();

        }
    }
}
