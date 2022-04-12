using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication6;

namespace WindowsFormsApplication6
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();            
            var form1 = new Form1();
            //this.WindowState = FormWindowState.Maximized;
            //不要顯示Title
            form1.FormBorderStyle = FormBorderStyle.None;

            //非最上層
            form1.TopLevel = false;

            //顯示From，要加上去才會顯示Form
            form1.Visible = true;

            //設定From位置
            form1.Top = 0;
            form1.Left = 0;

            //將Form加入tabPage中
            this.tabPage1.Controls.Add(form1);

            //顯示tabPage
            this.tabPage1.Show();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }
        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((sender as TabControl).SelectedIndex)
            {
                case 0:
                    var form1 = new Form1();
                    form1.FormBorderStyle = FormBorderStyle.None;
                    form1.TopLevel = false;
                    form1.Visible = true;
                    form1.Top = 0;
                    form1.Left = 0;

                    //將Form加入tabPage中
                    tabPage1.Controls.Add(form1);

                    //顯示tabPage
                    tabPage1.Show();
                    break;
                case 1:
                    //do page1
                    var form3 = new Form3();
                    //不要顯示Title
                    form3.FormBorderStyle = FormBorderStyle.None;

                    //非最上層
                    form3.TopLevel = false;

                    //顯示From，要加上去才會顯示Form
                    form3.Visible = true;

                    //設定From位置
                    form3.Top = 0;
                    form3.Left = 0;

                    //將Form加入tabPage中
                    tabPage2.Controls.Add(form3);

                    //顯示tabPage
                    tabPage2.Show();
                    break;
                 
                case 2:
                    //do page2
                    var form6 = new Form6();
                    //不要顯示Title
                    form6.FormBorderStyle = FormBorderStyle.None;

                    //非最上層
                    form6.TopLevel = false;

                    //顯示From，要加上去才會顯示Form
                    form6.Visible = true;

                    //設定From位置
                    form6.Top = 0;
                    form6.Left = 0;

                    //將Form加入tabPage中
                    tabPage3.Controls.Add(form6);

                    //顯示tabPage
                    tabPage3.Show();                    
                    break;
                case 3:
                    //do page2
                    var form7 = new Form7();
                    //不要顯示Title
                    form7.FormBorderStyle = FormBorderStyle.None;

                    //非最上層
                    form7.TopLevel = false;

                    //顯示From，要加上去才會顯示Form
                    form7.Visible = true;

                    //設定From位置
                    form7.Top = 0;
                    form7.Left = 0;

                    //將Form加入tabPage中
                    tabPage4.Controls.Add(form7);

                    //顯示tabPage
                    tabPage4.Show();
                    break;

                default:
                    var form = new Form1();
                    //不要顯示Title
                    form.FormBorderStyle = FormBorderStyle.None;

                    //非最上層
                    form.TopLevel = false;

                    //顯示From，要加上去才會顯示Form
                    form.Visible = true;

                    //設定From位置
                    form.Top = 0;
                    form.Left = 0;

                    //將Form加入tabPage中
                    tabPage1.Controls.Add(form);

                    //顯示tabPage
                    tabPage1.Show();
                    break;
            }
        }
    }
}
