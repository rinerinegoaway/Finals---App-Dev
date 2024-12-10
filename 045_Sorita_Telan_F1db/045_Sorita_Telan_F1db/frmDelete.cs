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
    public partial class frmDelete : Form
    {
        string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Z:\\045_Sorita_Regine\\045_Sorita_Telan_F1db\\dbPhone.mdb";
        OleDbConnection conn;
        public frmDelete()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "DELETE from model where model_desc = @model";
            conn = new OleDbConnection(connStr);
            conn.Open();
            OleDbCommand cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@model", txtDelModelDesc.Text);
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("DELETED","Input", MessageBoxButtons.OK);
        }

        private void btnDelCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
