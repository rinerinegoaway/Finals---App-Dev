using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _045_Sorita_Telan_F1db
{
    public partial class frmEdit : Form
    {
        string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Z:\\045_Sorita_Regine\\045_Sorita_Telan_F1db\\dbPhone.mdb";
        OleDbConnection conn;
        public frmEdit()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string query = "UPDATE model set price = @price, brandid = @brand where model_desc = '"+txtUpModelDesc.Text+"'";
            conn = new OleDbConnection(connStr);
            conn.Open();
            OleDbCommand cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@price", txtUpPrice.Text);
            cmd.Parameters.AddWithValue("brand", cboUpBrand.SelectedIndex.ToString());
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("UPDATED", "Input", MessageBoxButtons.OK);
        
    }

        private void frmEdit_Load(object sender, EventArgs e)
        {
            string query = "select * from brand";
            DataTable dt = new DataTable();
            conn = new OleDbConnection(connStr);
            conn.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
            adapter.Fill(dt);
            conn.Close();

            string getValue;
            cboUpBrand.DataSource = dt;
            cboUpBrand.DisplayMember = "brand";
            getValue = cboUpBrand.SelectedIndex.ToString();
        }

        private void btnUpCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboUpBrand_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
