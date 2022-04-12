using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace WindowsFormsApplication6
{
    public partial class Form6 : Form
    {
        string connectionString = @"Server=rfiddatabase.codn1rmbkzxk.us-east-2.rds.amazonaws.com;Database=RFID_BINARY_DB;Uid=admin;Pwd=rfid123123;";
        int ID = 0;
        public Form6()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("RFIDAddOrEdit", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_id", txtid.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_owner_id", txtownerId.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_item_name", txtdeviceName.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_user_id", txtuserId.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_is_return", txtisreturn.Text.Trim());


                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Submitted Successfully");
                Clear();
                GridFill();
            }
        }

        void GridFill()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("RFIDViewAll", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtblRFID = new DataTable();
                sqlDa.Fill(dtblRFID);
                dgvRFID.DataSource = dtblRFID;
                dgvRFID.Columns[0].Visible = true;
                string employee_Sql = "select name from employee";
                string device_Sql = "select item_name from device";

                MySqlCommand employee_id_result = new MySqlCommand(employee_Sql, mysqlCon);
                MySqlDataReader employee_id_result_read = employee_id_result.ExecuteReader();



                while (employee_id_result_read.Read())
                {
                    txtownerId.Items.Add(employee_id_result_read[0]);
                    txtuserId.Items.Add(employee_id_result_read[0]);
                }
                employee_id_result_read.Close();
                MySqlCommand device_id_result = new MySqlCommand(device_Sql, mysqlCon);
                MySqlDataReader device_id_result_read = device_id_result.ExecuteReader();
                while (device_id_result_read.Read())
                {
                    txtdeviceName.Items.Add(device_id_result_read[0]);
                }
                device_id_result_read.Close();
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            Clear();
            GridFill();
        }

        void Clear()
        {
            txtid.Text = txtownerId.Text = txtdeviceName.Text = txtuserId.Text = txtisreturn.Text = txtSearch.Text = "";
            //ID = 0;
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
        }

        private void dgvRFID_DoubleClick(object sender, EventArgs e)
        {
            if (dgvRFID.CurrentRow.Index != -1)
            {
                txtid.Text = dgvRFID.CurrentRow.Cells[0].Value.ToString();
                txtdeviceName.Text = dgvRFID.CurrentRow.Cells[1].Value.ToString();
                txtownerId.Text = dgvRFID.CurrentRow.Cells[2].Value.ToString();
                txtuserId.Text = dgvRFID.CurrentRow.Cells[3].Value.ToString();
                txtisreturn.Text = dgvRFID.CurrentRow.Cells[4].Value.ToString();
                txtreturnDate.Text = dgvRFID.CurrentRow.Cells[6].Value.ToString();
                //ID = Convert.ToInt32(dgvRFID.CurrentRow.Cells[0].Value.ToString());
                btnSave.Text = "Update";
                btnDelete.Enabled = Enabled;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("RFIDSearchByValue", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_SearchValue", txtSearch.Text);
                DataTable dtblRFID = new DataTable();
                sqlDa.Fill(dtblRFID);
                dgvRFID.DataSource = dtblRFID;
                dgvRFID.Columns[0].Visible = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("RFIDDeleteByID", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_id", txtid.Text.Trim());
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully");
                Clear();
                GridFill();
            }
        }

        private void dgvRFID_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            // {
            // mysqlCon.Open();
            // string Sql = "select id from employee";

            // MySqlCommand mySqlCmd = new MySqlCommand(Sql, mysqlCon);

            // MySqlDataReader DR = mySqlCmd.ExecuteReader();

            // while (DR.Read())
            //  {
            //      comboBox1.Items.Add(DR[0]);

            // }
            // mySqlCmd.CommandType = CommandType.StoredProcedure;
            //  mySqlCmd.Parameters.AddWithValue("_id", txtid.Text.Trim());
            //  mySqlCmd.ExecuteNonQuery();
            // }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtuserId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
