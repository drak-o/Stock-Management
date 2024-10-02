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
using static System.Net.Mime.MediaTypeNames;


namespace Stock

{
    public partial class Products : Form
    {   

        //Function that Loads DB to front-end
        public void LoadData()
        {
            // Create connection to DB and send query through sql adapter
            SqlConnection con = Connection.GetConnection();
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM [Stock].[dbo].Products", con);
            
            // Create a DataTable in RAM which we fill with our DB
            DataTable dt = new DataTable();
            sda.Fill(dt);

            // Clear front-end
            dgvProducts.Rows.Clear();

            // Populate DB based on DataTable
            foreach (DataRow item in dt.Rows)
            {
                int n = dgvProducts.Rows.Add();
                dgvProducts.Rows[n].Cells[0].Value = item["ProductCode"].ToString();
                dgvProducts.Rows[n].Cells[1].Value = item["ProductName"].ToString();
                if ((bool)item["ProductStatus"])
                {
                    dgvProducts.Rows[n].Cells[2].Value = "Active";
                }
                else
                {
                    dgvProducts.Rows[n].Cells[2].Value = "Inactive";
                }
            }
        }

        
        private bool IfProductExists(SqlConnection con, string productCode)
        {
            // Check if any in our DB WHERE the ProductCode is the provided value
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT 1 FROM [Stock].[dbo].[Products] WHERE
                            ([ProductCode] = '" + productCode + "')", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0) 
                return true;
            else 
                return false;
        
        }

        private void ResetRecords()
        {
            txtProductCode.Clear();
            txtProductName.Clear();
            cmbStatus.SelectedIndex = -1;
            btnAdd.Text = "Add";
            txtProductCode.Focus();
        }

        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            cmbStatus.SelectedIndex = 0;
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = Connection.GetConnection();

            con.Open();
            // Decide status based on front-end status
            bool status = cmbStatus.SelectedIndex == 0;

            if (cmbStatus.SelectedIndex == 1) 
            { 
                status = true;
            }
            else
            {
                status = false;
            }

            var sqlQuery = ""; //bad practice can inject SQL (overwrite)

            // Logic for updating in case the product code already exists 
            if (IfProductExists(con,txtProductCode.Text))
            {
               sqlQuery = @"UPDATE [Products] SET [ProductName] = '" + txtProductName.Text + "' ,[ProductStatus] = '" + status + "'" +
                          "WHERE [ProductCode] = '" + txtProductCode.Text + "'";

            }

            // Logic for inserting
            else
            {
                sqlQuery = @"INSERT INTO [Stock].[dbo].[Products] ([ProductCode] ,[ProductName] ,[ProductStatus]) VALUES
                            ('" + txtProductCode.Text + "', '" +txtProductName.Text + "','" + status + "')";
            }

            SqlCommand cmd = new SqlCommand(sqlQuery, con); //send query
            cmd.ExecuteNonQuery();
            con.Close();
            LoadData();
            btnAdd.Text = "Add";
        }

        private void dgvProducts_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnAdd.Text = "Update";
            txtProductCode.Text = dgvProducts.SelectedRows[0].Cells[0].Value.ToString();
            txtProductName.Text = dgvProducts.SelectedRows[0].Cells[1].Value.ToString();
            if (dgvProducts.SelectedRows[0].Cells[2].Value.ToString() == "Active")
            {
                cmbStatus.SelectedIndex = 0;
            }
            else
            {
                cmbStatus.SelectedIndex = 1;
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = Connection.GetConnection();
            var sqlQuery = "";
            
            // if product exists delete it
            if (IfProductExists(con,txtProductCode.Text))
            {
                con.Open();
                sqlQuery = @"DELETE FROM [Products] WHERE [ProductCode] = '" + txtProductCode.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }

            //else can't find it
            else
            {
                MessageBox.Show("No record found with that product code");
            }
            LoadData();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetRecords();
        }
    }
}
