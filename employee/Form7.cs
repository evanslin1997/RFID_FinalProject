using MySql.Data.MySqlClient;
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

namespace WindowsFormsApplication6
{
    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }



    public partial class Form7 : Form
    {
        MySqlConnection conn;
        int selectedLoginStatus = 0;
        string myConnStr = "server=rfiddatabase.codn1rmbkzxk.us-east-2.rds.amazonaws.com;database=RFID_BINARY_DB;uid=admin;pwd=rfid123123;";
        List<ComboboxItem> ComboboxItems = new List<ComboboxItem>();

        public Form7()
        {
            InitializeComponent();

            conn = new MySqlConnection(myConnStr);
            try
            {
                conn.Open();
                Console.WriteLine("conn");
                //conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("not conn");
            }

            ComboboxItem allEmployee = new ComboboxItem();
            allEmployee.Text = "全部";
            allEmployee.Value = 0;
            comboBox1.Items.Add(allEmployee);

            string query = "select * from employee;";
            MySqlDataReader reader = null;
            MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                reader = cmd.ExecuteReader();
                String id;
                String name;
                while (reader.Read())
                {
                    id = reader.GetString("id");
                    name = reader.GetString("name");
                    ComboboxItem item = new ComboboxItem();
                    item.Text = name;
                    item.Value = id;

                    ComboboxItems.Add(item);
                    comboBox1.Items.Add(item);
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("資料庫讀取錯誤");
                Console.WriteLine(ex.ToString());
            }

            ComboboxItem allStatus = new ComboboxItem();
            allStatus.Text = "全部";
            allStatus.Value = 0;
            comboBox2.Items.Add(allStatus);

            ComboboxItem loginStatus = new ComboboxItem();
            loginStatus.Text = "登入";
            loginStatus.Value = 1;
            comboBox2.Items.Add(loginStatus);

            ComboboxItem logoutStatus = new ComboboxItem();
            logoutStatus.Text = "登出";
            logoutStatus.Value = 2;
            comboBox2.Items.Add(logoutStatus);


            comboBox1.SelectedIndex = 0;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query_time = "ADDTIME(date_time, '0 8:0:0.000000') ";
            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 0)
            {
                MySqlDataAdapter da = null;
                DataSet ds = new DataSet();
                foreach (ComboboxItem item in ComboboxItems)
                {
                    string value = (string)item.Value;//comboBox1.Items[i].ToString();

                    Console.WriteLine(value);
                    MySqlCommand query_command = new MySqlCommand("SELECT name as '姓名', " + query_time + " as '登入/登出日期' ,   (case when isLogin = 0 then '登出' else '登入' end) as '登入/登出' FROM login_date INNER JOIN employee ON employee.id = login_date.employee_id WHERE employee_id = '" + value + "';");
                    da = new MySqlDataAdapter(query_command);
                    da.SelectCommand.Connection = conn;
                    DataSet dataSet = new DataSet();
                    da.Fill(dataSet, "login_date");
                    if (dataSet.Tables[0] != null)
                        ds.Merge(dataSet);
                }
                if (comboBox1.Items.Count > 0)
                {
                    dataGridView1.DataSource = ds.Tables["login_date"].DefaultView;
                    DataGridViewColumn column = dataGridView1.Columns[1];
                    column.Width = 200;
                }
            }
            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex != 0)
            {
                MySqlDataAdapter da = null;
                DataSet ds = new DataSet();
                foreach (ComboboxItem item in ComboboxItems)
                {
                    string value = (string)item.Value;//comboBox1.Items[i].ToString();

                    Console.WriteLine(value);
                    MySqlCommand query_command = null;
                    if (comboBox2.SelectedIndex == 1)
                    {
                        query_command = new MySqlCommand("SELECT name as '姓名', " + query_time + " as '登入/登出日期',   (case when isLogin = 0 then '登出' else '登入' end) as '登入/登出' FROM login_date INNER JOIN employee ON employee.id = login_date.employee_id WHERE employee_id = '" + value + "' and isLogin = 1;");
                    }
                    else
                    {
                        query_command = new MySqlCommand("SELECT name as '姓名', " + query_time + " as '登入/登出日期',   (case when isLogin = 0 then '登出' else '登入' end) as '登入/登出' FROM login_date INNER JOIN employee ON employee.id = login_date.employee_id WHERE employee_id = '" + value + "' and isLogin = 0;");
                    }
                    da = new MySqlDataAdapter(query_command);
                    da.SelectCommand.Connection = conn;
                    DataSet dataSet = new DataSet();
                    da.Fill(dataSet, "login_date");
                    if (dataSet.Tables[0] != null)
                        ds.Merge(dataSet);
                }
                if (comboBox1.Items.Count > 0)
                {
                    dataGridView1.DataSource = ds.Tables["login_date"].DefaultView;
                    DataGridViewColumn column = dataGridView1.Columns[1];
                    column.Width = 200;
                }
            }
            else if (comboBox1.SelectedIndex != 0 && comboBox2.SelectedIndex != 0)
            {
                MySqlDataAdapter da = null;
                DataSet ds = new DataSet();
                int count = 0;
                string value = "";
                foreach (ComboboxItem item in ComboboxItems)
                {
                    
                    if (count == comboBox1.SelectedIndex - 1)
                         value = (string)item.Value;
                    count++;
                }
               
                Console.WriteLine(value+"::rrrr");
                MySqlCommand query_command = null;
                if (comboBox2.SelectedIndex == 1)
                {
                    query_command = new MySqlCommand("SELECT name as '姓名', " + query_time + " as '登入日期',   (case when isLogin = 0 then '登出' else '登入' end) as '登入/登出' FROM login_date INNER JOIN employee ON employee.id = login_date.employee_id WHERE employee_id = '" + value + "' and isLogin = 1;");
                }
                else
                {
                    query_command = new MySqlCommand("SELECT name as '姓名', " + query_time + " as '登出日期',   (case when isLogin = 0 then '登出' else '登入' end) as '登入/登出' FROM login_date INNER JOIN employee ON employee.id = login_date.employee_id WHERE employee_id = '" + value + "' and isLogin = 0;");
                }
                da = new MySqlDataAdapter(query_command);
                da.SelectCommand.Connection = conn;
                DataSet dataSet = new DataSet();
                da.Fill(dataSet, "login_date");
                if (dataSet.Tables[0] != null)
                    ds.Merge(dataSet);

                if (comboBox1.Items.Count > 0)
                {
                    dataGridView1.DataSource = ds.Tables["login_date"].DefaultView;
                    DataGridViewColumn column = dataGridView1.Columns[1];
                    column.Width = 200;
                }
            }
            else if (comboBox1.SelectedIndex != 0 && comboBox2.SelectedIndex == 0)
            {
                MySqlDataAdapter da = null;
                DataSet ds = new DataSet();
                int count = 0;
                string value = "";
                foreach (ComboboxItem item in ComboboxItems)
                {

                    if (count == comboBox1.SelectedIndex - 1)
                        value = (string)item.Value;
                    count++;
                }

                Console.WriteLine(value + "::rrrr");
                MySqlCommand query_command = null;               
                query_command = new MySqlCommand("SELECT name as '姓名', " + query_time + " as '登入/登出日期',   (case when isLogin = 0 then '登出' else '登入' end) as '登入/登出' FROM login_date INNER JOIN employee ON employee.id = login_date.employee_id WHERE employee_id = '" + value + "';");
                                
                da = new MySqlDataAdapter(query_command);
                da.SelectCommand.Connection = conn;
                DataSet dataSet = new DataSet();
                da.Fill(dataSet, "login_date");
                if (dataSet.Tables[0] != null)
                    ds.Merge(dataSet);

                if (comboBox1.Items.Count > 0)
                {
                    dataGridView1.DataSource = ds.Tables["login_date"].DefaultView;
                    DataGridViewColumn column = dataGridView1.Columns[1];
                    column.Width = 200;
                }
            }

        }
    }
}
