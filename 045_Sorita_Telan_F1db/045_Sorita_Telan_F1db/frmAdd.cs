using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _045_Sorita_Telan_F1db
{
    public partial class frmAdd : Form
    {
        string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Z:\\045_Sorita_Regine\\045_Sorita_Telan_F1db\\dbPhone.mdb";
        OleDbConnection conn;

        public frmAdd()
        {
            InitializeComponent();
        }

        private void frmAdd_Load(object sender, EventArgs e)
        {
            
            string query = "SELECT * FROM brand";
            DataTable dt = new DataTable();
            conn = new OleDbConnection(connStr);
            conn.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
            adapter.Fill(dt);
            conn.Close();

            
            cboAddBrand.DataSource = dt;
            cboAddBrand.DisplayMember = "brand";
            cboAddBrand.ValueMember = "brandid";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            decimal price;
            if (!decimal.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }

            string query = "INSERT INTO model (model_desc, price, brandid) VALUES (@model, @price, @brand)";
            conn = new OleDbConnection(connStr);
            conn.Open();

            OleDbCommand cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@model", txtModelDesc.Text);  
            cmd.Parameters.AddWithValue("@price", price);  
            cmd.Parameters.AddWithValue("@brand", cboAddBrand.SelectedValue);  

            cmd.ExecuteNonQuery();  
            conn.Close();

            MessageBox.Show("ADDED", "Input", MessageBoxButtons.OK);
        }

        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
