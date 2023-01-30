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

namespace FoodLovers
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tabis\OneDrive\Documents\FoodLoversMarket.mdf;Integrated Security=True;Connect Timeout=30");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();

            //Only registered users have access
            SqlDataAdapter sqlAd = new SqlDataAdapter("Select COUNT(*) from Users where UserName='" + txtUserName.Text + "' and Password='" + txtPassword.Text + "' ", conn);
            DataTable dt = new DataTable();
            sqlAd.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                MainPageForm mpf = new MainPageForm();
                mpf.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect UserName/Password");
            }

            conn.Close();
        }
    }
}