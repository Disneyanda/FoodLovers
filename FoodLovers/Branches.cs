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
using System.IO;

namespace FoodLovers
{
    public partial class Branches : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tabis\OneDrive\Documents\FoodLoversMarket.mdf;Integrated Security=True;Connect Timeout=30");

        public void populate() 
        { 
            conn.Open();

            string slctQuery = "select * from Branches"; //Add clause to avoid loading the whole payload
            SqlDataAdapter sqlAd = new SqlDataAdapter(slctQuery, conn);
            SqlCommandBuilder sqlCb = new SqlCommandBuilder(sqlAd);
            var ds = new DataSet();
            sqlAd.Fill(ds);
            dgvBranches.DataSource = ds.Tables[0];

            conn.Close();
        }
        public Branches()
        {
            InitializeComponent();
        } 

        private void Branches_Load(object sender, EventArgs e)
        {
            populate();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("insert into Branches values("+txtId.Text+",'"+txtName.Text+"','"+txtTelephone.Text+"','"+dtpOpenDate.Value.ToString("d-MMM-yyyy hh:mm:ss")+"')", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Branch Added");

            conn.Close();

            populate(); //refresh

        }

        private void dgvBranches_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Load textbox with record to edit
            txtId.Text = dgvBranches.SelectedRows[0].Cells[0].Value.ToString();
            txtName.Text = dgvBranches.SelectedRows[0].Cells[1].Value.ToString();
            txtTelephone.Text = dgvBranches.SelectedRows[0].Cells[2].Value.ToString();

            //missing populate datepicker with OpenDate
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("update Branches set Name='"+txtName.Text+"',Telephone='"+txtTelephone.Text +"',OpenDate='"+dtpOpenDate.Text+"' where Id="+txtId.Text+";", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Branch Updated");
            conn.Close();

            populate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from Branches where Id=" + txtId.Text + "", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Branch Removed");
            conn.Close();

            populate(); // Refresh list

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            conn.Open();

            string slctQuery = "select * from Branches where Name='"+txtSearch.Text+"'"; //Add clause to avoid loading the whole payload
            SqlDataAdapter sqlAd = new SqlDataAdapter(slctQuery, conn);
            SqlCommandBuilder sqlCb = new SqlCommandBuilder(sqlAd);
            var ds = new DataSet();
            sqlAd.Fill(ds);
            dgvBranches.DataSource = ds.Tables[0];

            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e) //export csv
        {
            if (dgvBranches.Rows.Count >0)
            {
                SaveFileDialog sfdSave =new SaveFileDialog();
                sfdSave.Filter = "CSV (*.csv)|*.csv";
                sfdSave.FileName = "Branch.csv";
                bool errorFile =false;

                if (sfdSave.ShowDialog() == DialogResult.OK)
                {
                    if(File.Exists(sfdSave.FileName))
                    {
                        try
                        {
                            File.Delete(sfdSave.FileName);

                        }
                        catch (Exception)
                        {
                            errorFile= true;
                            throw;
                            //MessageBox.Show("Could not write to file", "Info");
                        }
                    }
                    if(!errorFile)
                    {
                        try
                        {
                            int clnCount = dgvBranches.Columns.Count;
                            string clnNames = "";
                            string[] outputCsv = new string[dgvBranches.Rows.Count + 1];

                            for(int i=0; i< clnCount;i++)
                            {
                                clnNames += dgvBranches.Columns[i].HeaderText.ToString() + ","; //Data format
                            }

                            outputCsv[0] += clnNames;

                            for (int i = 1; (i - 1) < dgvBranches.Rows.Count; i++)
                            {
                                for(int j=0; j<clnCount; j++) 
                                {
                                    outputCsv[i] += dgvBranches.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }

                            File.WriteAllLines(sfdSave.FileName, outputCsv, Encoding.UTF8);
                            MessageBox.Show("Exported to CSV", "Info");

                        }
                        catch (Exception)
                        {

                           throw;
                        }
                    }
                }
            }

        }

        private void btnExportXml_Click(object sender, EventArgs e)
        {

        }

        private void btnImportCsv_Click(object sender, EventArgs e)
        {
            //OpenFileDialog.ShowDialog
            openFileDialog1.ShowDialog();
            txtFilePath.Text = openFileDialog1.FileName;
            DataBinding(txtFilePath.Text);

        }

        private void DataBinding(string filePath)
        {
            DataTable dt = new DataTable();
            string[] lns = System.IO.File.ReadAllLines(filePath);
            if (lns.Length > 0)
            {
                string firstLine = lns[0];
                string[] headerLabels = firstLine.Split(',');
                foreach (string headerWord in headerLabels)
                {
                    dt.Columns.Add(new DataColumn(headerWord));
                }
                //For Data
                for (int i = 1; i <lns.Length; i++)
                {
                    string[] dataWords = lns[i].Split(',');
                    DataRow dr = dt.NewRow();
                    int columnIndex = 0;
                    foreach (string headerWord in headerLabels)
                    {
                        dr[headerWord] = dataWords[columnIndex++];
                    }
                    dt.Rows.Add(dr);
                }
            }
            if (dt.Rows.Count > 0)
            {
                dgvBranches.DataSource = dt;
            }

        }

        private void btnImportJson_Click(object sender, EventArgs e)
        {
            DataTable dataTable = (DataTable)JsonConvert.DeserializeObject(jsonString, (typeof(DataTable)));
            dgvBranches.DataSource = dataTable;
        }
    }
}
