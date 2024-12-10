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
    public partial class FrmMain : Form
    {
        string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Z:\\045_Sorita_Regine\\045_Sorita_Telan_F1db\\dbPhone.mdb";
        OleDbConnection conn;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {


            string keyword = txtKeyword.Text;
            string minPriceText = txtMin.Text;
            string maxPriceText = txtMax.Text;
            string brand = cbobrand.Text;

           

            string query = "SELECT model_desc AS MODEL, price AS PRICE, brandid AS BRAND FROM model WHERE 1=1";

            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(query, conn);


                if (!string.IsNullOrWhiteSpace(keyword))
                {
                    query += " AND model_desc LIKE @keyword";
                    cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                }

                if (decimal.TryParse(minPriceText, out decimal minPrice) && decimal.TryParse(maxPriceText, out decimal maxPrice))
                {
                    query += " AND price BETWEEN @minPrice AND @maxPrice";
                    cmd.Parameters.AddWithValue("@minPrice", minPrice);
                    cmd.Parameters.AddWithValue("@maxPrice", maxPrice);
                }

                if (!string.IsNullOrWhiteSpace(brand))
                {
                    query += " AND model.brandid = @brand";
                    cmd.Parameters.AddWithValue("@brand", get_equivalent(brand));
                }

                cmd.CommandText = query;


                DataTable dt = new DataTable();
                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dt);
                grdResult.DataSource = dt;

            }
        }

        public int get_equivalent(string brandvalue)
        {
            int value = 0;

            if (brandvalue.Equals("Nokia"))
            {
                value = 1;
            }
            else if (brandvalue.Equals("Samsung"))
            {
                value = 2;
            }
            else if (brandvalue.Equals("Apple"))
            {
                value = 3;
            }
            else if (brandvalue.Equals("Xiaomi"))
            {
                value = 4;
            }
            else if (brandvalue.Equals("Realme"))
            {
                value = 5;
            }
            else if (brandvalue.Equals("Redmi"))
            {
                value = 6;
            }
            else if (brandvalue.Equals("Asus"))
            {
                value = 7;
            }
            else if (brandvalue.Equals("Oppo"))
            {
                value = 8;
            }
            else if (brandvalue.Equals("Vivo"))
            {
                value = 9;
            }
            else if (brandvalue.Equals("Huawei"))
            {
                value = 10;
            }

            return value;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAdd add = new frmAdd();
            add.ShowDialog();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmEdit edit = new frmEdit();
            edit.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmDelete delete = new frmDelete();
            delete.ShowDialog();
        }
    }
}
