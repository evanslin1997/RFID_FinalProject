﻿using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClose = new System.Windows.Forms.Button();
            this.Sector = new System.Windows.Forms.ComboBox();
            this.Block = new System.Windows.Forms.ComboBox();
            this.KeyAB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LoadKey = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tebReadData = new System.Windows.Forms.TextBox();
            this.BtnReadData = new System.Windows.Forms.Button();
            this.but_CleanCard = new System.Windows.Forms.Button();
            this.but_SignCard = new System.Windows.Forms.Button();
            this.textBox_Point = new System.Windows.Forms.TextBox();
            this.textBox_SignDay = new System.Windows.Forms.TextBox();
            this.textBox_MemName = new System.Windows.Forms.TextBox();
            this.textBox_MemID = new System.Windows.Forms.TextBox();
            this.label_point = new System.Windows.Forms.Label();
            this.label_SignDay = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_member = new System.Windows.Forms.Label();
            this.textBox_Point2 = new System.Windows.Forms.TextBox();
            this.textBox_SignDay2 = new System.Windows.Forms.TextBox();
            this.label_point2 = new System.Windows.Forms.Label();
            this.label_SignDay2 = new System.Windows.Forms.Label();
            this.lbl_message4 = new System.Windows.Forms.Label();
            this.but_SpendPoint = new System.Windows.Forms.Button();
            this.textBox_Point4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tebWriteData = new System.Windows.Forms.TextBox();
            this.BtnWriteData = new System.Windows.Forms.Button();
            this.but_AddPoint = new System.Windows.Forms.Button();
            this.lbl_message3 = new System.Windows.Forms.Label();
            this.label_point3 = new System.Windows.Forms.Label();
            this.textBox_Point3 = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.textBox_MemID2 = new System.Windows.Forms.TextBox();
            this.label_name2 = new System.Windows.Forms.Label();
            this.label_member2 = new System.Windows.Forms.Label();
            this.textBox_MemName2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(160, 445);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 29);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Sector
            // 
            this.Sector.FormattingEnabled = true;
            this.Sector.Location = new System.Drawing.Point(19, 46);
            this.Sector.Margin = new System.Windows.Forms.Padding(4);
            this.Sector.Name = "Sector";
            this.Sector.Size = new System.Drawing.Size(63, 23);
            this.Sector.TabIndex = 14;
            this.Sector.SelectedIndexChanged += new System.EventHandler(this.Sector_SelectedIndexChanged);
            // 
            // Block
            // 
            this.Block.FormattingEnabled = true;
            this.Block.Location = new System.Drawing.Point(104, 46);
            this.Block.Margin = new System.Windows.Forms.Padding(4);
            this.Block.Name = "Block";
            this.Block.Size = new System.Drawing.Size(63, 23);
            this.Block.TabIndex = 15;
            this.Block.SelectedIndexChanged += new System.EventHandler(this.Block_SelectedIndexChanged);
            // 
            // KeyAB
            // 
            this.KeyAB.FormattingEnabled = true;
            this.KeyAB.Location = new System.Drawing.Point(188, 46);
            this.KeyAB.Margin = new System.Windows.Forms.Padding(4);
            this.KeyAB.Name = "KeyAB";
            this.KeyAB.Size = new System.Drawing.Size(63, 23);
            this.KeyAB.TabIndex = 16;
            this.KeyAB.SelectedIndexChanged += new System.EventHandler(this.KeyAB_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Sector :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Block :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "KeyAB :";
            // 
            // LoadKey
            // 
            this.LoadKey.Location = new System.Drawing.Point(276, 46);
            this.LoadKey.Margin = new System.Windows.Forms.Padding(4);
            this.LoadKey.Name = "LoadKey";
            this.LoadKey.Size = new System.Drawing.Size(132, 25);
            this.LoadKey.TabIndex = 20;
            this.LoadKey.Text = "FFFFFFFFFFFF";
            this.LoadKey.TextChanged += new System.EventHandler(this.LoadKey_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(276, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Load Key :";
            // 
            // tebReadData
            // 
            this.tebReadData.Location = new System.Drawing.Point(19, 92);
            this.tebReadData.Margin = new System.Windows.Forms.Padding(4);
            this.tebReadData.Name = "tebReadData";
            this.tebReadData.Size = new System.Drawing.Size(291, 25);
            this.tebReadData.TabIndex = 22;
            // 
            // BtnReadData
            // 
            this.BtnReadData.Location = new System.Drawing.Point(324, 92);
            this.BtnReadData.Margin = new System.Windows.Forms.Padding(4);
            this.BtnReadData.Name = "BtnReadData";
            this.BtnReadData.Size = new System.Drawing.Size(100, 29);
            this.BtnReadData.TabIndex = 23;
            this.BtnReadData.Text = "Read data";
            this.BtnReadData.UseVisualStyleBackColor = true;
            this.BtnReadData.Click += new System.EventHandler(this.BtnReadData_Click);
            // 
            // but_CleanCard
            // 
            this.but_CleanCard.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.but_CleanCard.Location = new System.Drawing.Point(768, 266);
            this.but_CleanCard.Margin = new System.Windows.Forms.Padding(4);
            this.but_CleanCard.Name = "but_CleanCard";
            this.but_CleanCard.Size = new System.Drawing.Size(100, 29);
            this.but_CleanCard.TabIndex = 9;
            this.but_CleanCard.Text = "清空卡片";
            this.but_CleanCard.UseVisualStyleBackColor = true;
            this.but_CleanCard.Click += new System.EventHandler(this.but_CleanCard_Click);
            // 
            // but_SignCard
            // 
            this.but_SignCard.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.but_SignCard.Location = new System.Drawing.Point(768, 225);
            this.but_SignCard.Margin = new System.Windows.Forms.Padding(4);
            this.but_SignCard.Name = "but_SignCard";
            this.but_SignCard.Size = new System.Drawing.Size(100, 29);
            this.but_SignCard.TabIndex = 8;
            this.but_SignCard.Text = "卡片製作";
            this.but_SignCard.UseVisualStyleBackColor = true;
            this.but_SignCard.Click += new System.EventHandler(this.but_SignCard_Click);
            // 
            // textBox_Point
            // 
            this.textBox_Point.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.textBox_Point.Location = new System.Drawing.Point(610, 299);
            this.textBox_Point.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Point.Name = "textBox_Point";
            this.textBox_Point.Size = new System.Drawing.Size(132, 30);
            this.textBox_Point.TabIndex = 7;
            this.textBox_Point.Text = "9999";
            // 
            // textBox_SignDay
            // 
            this.textBox_SignDay.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.textBox_SignDay.Location = new System.Drawing.Point(610, 262);
            this.textBox_SignDay.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_SignDay.Name = "textBox_SignDay";
            this.textBox_SignDay.Size = new System.Drawing.Size(132, 30);
            this.textBox_SignDay.TabIndex = 6;
            this.textBox_SignDay.Text = "2019/11/20";
            this.textBox_SignDay.TextChanged += new System.EventHandler(this.textBox_SignDay_TextChanged);
            // 
            // textBox_MemName
            // 
            this.textBox_MemName.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.textBox_MemName.Location = new System.Drawing.Point(610, 227);
            this.textBox_MemName.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_MemName.Name = "textBox_MemName";
            this.textBox_MemName.Size = new System.Drawing.Size(132, 30);
            this.textBox_MemName.TabIndex = 5;
            this.textBox_MemName.Text = "林雅姿";
            this.textBox_MemName.TextChanged += new System.EventHandler(this.textBox_MemName_TextChanged);
            // 
            // textBox_MemID
            // 
            this.textBox_MemID.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.textBox_MemID.Location = new System.Drawing.Point(610, 192);
            this.textBox_MemID.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_MemID.Name = "textBox_MemID";
            this.textBox_MemID.Size = new System.Drawing.Size(132, 30);
            this.textBox_MemID.TabIndex = 4;
            this.textBox_MemID.Text = "C5303246";
            // 
            // label_point
            // 
            this.label_point.AutoSize = true;
            this.label_point.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.label_point.Location = new System.Drawing.Point(524, 302);
            this.label_point.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_point.Name = "label_point";
            this.label_point.Size = new System.Drawing.Size(44, 22);
            this.label_point.TabIndex = 3;
            this.label_point.Text = "點數";
            // 
            // label_SignDay
            // 
            this.label_SignDay.AutoSize = true;
            this.label_SignDay.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.label_SignDay.Location = new System.Drawing.Point(524, 266);
            this.label_SignDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_SignDay.Name = "label_SignDay";
            this.label_SignDay.Size = new System.Drawing.Size(78, 22);
            this.label_SignDay.TabIndex = 2;
            this.label_SignDay.Text = "申請日期";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.label_name.Location = new System.Drawing.Point(524, 231);
            this.label_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(78, 22);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "員工姓名";
            // 
            // label_member
            // 
            this.label_member.AutoSize = true;
            this.label_member.Font = new System.Drawing.Font("微軟正黑體", 25F, System.Drawing.FontStyle.Bold);
            this.label_member.Location = new System.Drawing.Point(524, 196);
            this.label_member.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_member.Name = "label_member";
            this.label_member.Size = new System.Drawing.Size(191, 53);
            this.label_member.TabIndex = 0;
            this.label_member.Text = "員工編號";
            // 
            // textBox_Point2
            // 
            this.textBox_Point2.Location = new System.Drawing.Point(610, 131);
            this.textBox_Point2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Point2.Name = "textBox_Point2";
            this.textBox_Point2.Size = new System.Drawing.Size(132, 25);
            this.textBox_Point2.TabIndex = 8;
            // 
            // textBox_SignDay2
            // 
            this.textBox_SignDay2.Location = new System.Drawing.Point(610, 94);
            this.textBox_SignDay2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_SignDay2.Name = "textBox_SignDay2";
            this.textBox_SignDay2.Size = new System.Drawing.Size(132, 25);
            this.textBox_SignDay2.TabIndex = 7;
            // 
            // label_point2
            // 
            this.label_point2.AutoSize = true;
            this.label_point2.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.label_point2.Location = new System.Drawing.Point(524, 134);
            this.label_point2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_point2.Name = "label_point2";
            this.label_point2.Size = new System.Drawing.Size(44, 22);
            this.label_point2.TabIndex = 4;
            this.label_point2.Text = "點數";
            // 
            // label_SignDay2
            // 
            this.label_SignDay2.AutoSize = true;
            this.label_SignDay2.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.label_SignDay2.Location = new System.Drawing.Point(524, 98);
            this.label_SignDay2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_SignDay2.Name = "label_SignDay2";
            this.label_SignDay2.Size = new System.Drawing.Size(78, 22);
            this.label_SignDay2.TabIndex = 3;
            this.label_SignDay2.Text = "申請日期";
            // 
            // lbl_message4
            // 
            this.lbl_message4.AutoSize = true;
            this.lbl_message4.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_message4.ForeColor = System.Drawing.Color.Blue;
            this.lbl_message4.Location = new System.Drawing.Point(755, 169);
            this.lbl_message4.Name = "lbl_message4";
            this.lbl_message4.Size = new System.Drawing.Size(155, 22);
            this.lbl_message4.TabIndex = 3;
            this.lbl_message4.Text = "~您好，歡迎消費~";
            // 
            // but_SpendPoint
            // 
            this.but_SpendPoint.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.but_SpendPoint.Location = new System.Drawing.Point(976, 133);
            this.but_SpendPoint.Margin = new System.Windows.Forms.Padding(4);
            this.but_SpendPoint.Name = "but_SpendPoint";
            this.but_SpendPoint.Size = new System.Drawing.Size(100, 29);
            this.but_SpendPoint.TabIndex = 2;
            this.but_SpendPoint.Text = "消費點數";
            this.but_SpendPoint.UseVisualStyleBackColor = true;
            this.but_SpendPoint.Click += new System.EventHandler(this.but_SpendPoint_Click);
            // 
            // textBox_Point4
            // 
            this.textBox_Point4.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.textBox_Point4.Location = new System.Drawing.Point(818, 131);
            this.textBox_Point4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Point4.Name = "textBox_Point4";
            this.textBox_Point4.Size = new System.Drawing.Size(132, 30);
            this.textBox_Point4.TabIndex = 1;
            this.textBox_Point4.Text = "50";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(755, 136);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "點數";
            // 
            // tebWriteData
            // 
            this.tebWriteData.Location = new System.Drawing.Point(19, 128);
            this.tebWriteData.Margin = new System.Windows.Forms.Padding(4);
            this.tebWriteData.Name = "tebWriteData";
            this.tebWriteData.Size = new System.Drawing.Size(291, 25);
            this.tebWriteData.TabIndex = 25;
            this.tebWriteData.TextChanged += new System.EventHandler(this.tebWriteData_TextChanged);
            // 
            // BtnWriteData
            // 
            this.BtnWriteData.Location = new System.Drawing.Point(324, 129);
            this.BtnWriteData.Margin = new System.Windows.Forms.Padding(4);
            this.BtnWriteData.Name = "BtnWriteData";
            this.BtnWriteData.Size = new System.Drawing.Size(100, 29);
            this.BtnWriteData.TabIndex = 26;
            this.BtnWriteData.Text = "Write data";
            this.BtnWriteData.UseVisualStyleBackColor = true;
            this.BtnWriteData.Click += new System.EventHandler(this.BtnWriteData_Click);
            // 
            // but_AddPoint
            // 
            this.but_AddPoint.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.but_AddPoint.Location = new System.Drawing.Point(737, 363);
            this.but_AddPoint.Margin = new System.Windows.Forms.Padding(4);
            this.but_AddPoint.Name = "but_AddPoint";
            this.but_AddPoint.Size = new System.Drawing.Size(100, 29);
            this.but_AddPoint.TabIndex = 2;
            this.but_AddPoint.Text = "加值點數";
            this.but_AddPoint.UseVisualStyleBackColor = true;
            this.but_AddPoint.Click += new System.EventHandler(this.but_AddPoint_Click);
            // 
            // lbl_message3
            // 
            this.lbl_message3.AutoSize = true;
            this.lbl_message3.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_message3.ForeColor = System.Drawing.Color.Blue;
            this.lbl_message3.Location = new System.Drawing.Point(528, 417);
            this.lbl_message3.Name = "lbl_message3";
            this.lbl_message3.Size = new System.Drawing.Size(266, 31);
            this.lbl_message3.TabIndex = 3;
            this.lbl_message3.Text = "~您好，歡迎儲值點數~";
            // 
            // label_point3
            // 
            this.label_point3.AutoSize = true;
            this.label_point3.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.label_point3.Location = new System.Drawing.Point(517, 368);
            this.label_point3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_point3.Name = "label_point3";
            this.label_point3.Size = new System.Drawing.Size(44, 22);
            this.label_point3.TabIndex = 0;
            this.label_point3.Text = "點數";
            // 
            // textBox_Point3
            // 
            this.textBox_Point3.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.textBox_Point3.Location = new System.Drawing.Point(580, 363);
            this.textBox_Point3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Point3.Name = "textBox_Point3";
            this.textBox_Point3.Size = new System.Drawing.Size(132, 30);
            this.textBox_Point3.TabIndex = 1;
            this.textBox_Point3.Text = "100";
            // 
            // textBox_MemID2
            // 
            this.textBox_MemID2.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Bold);
            this.textBox_MemID2.Location = new System.Drawing.Point(375, 532);
            this.textBox_MemID2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_MemID2.Name = "textBox_MemID2";
            this.textBox_MemID2.Size = new System.Drawing.Size(683, 41);
            this.textBox_MemID2.TabIndex = 5;
            this.textBox_MemID2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_MemID2.TextChanged += new System.EventHandler(this.textBox_MemID2_TextChanged);
            // 
            // label_name2
            // 
            this.label_name2.AutoSize = true;
            this.label_name2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label_name2.Font = new System.Drawing.Font("微軟正黑體", 25F, System.Drawing.FontStyle.Bold);
            this.label_name2.Location = new System.Drawing.Point(245, 532);
            this.label_name2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_name2.Name = "label_name2";
            this.label_name2.Size = new System.Drawing.Size(191, 53);
            this.label_name2.TabIndex = 2;
            this.label_name2.Text = "資產名稱";
            // 
            // label_member2
            // 
            this.label_member2.AutoSize = true;
            this.label_member2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label_member2.Font = new System.Drawing.Font("微軟正黑體", 25F, System.Drawing.FontStyle.Bold);
            this.label_member2.Location = new System.Drawing.Point(60, 532);
            this.label_member2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_member2.Name = "label_member2";
            this.label_member2.Size = new System.Drawing.Size(191, 53);
            this.label_member2.TabIndex = 1;
            this.label_member2.Text = "資產編號";
            this.label_member2.Click += new System.EventHandler(this.label_member2_Click);
            // 
            // textBox_MemName2
            // 
            this.textBox_MemName2.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Bold);
            this.textBox_MemName2.Location = new System.Drawing.Point(279, 544);
            this.textBox_MemName2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_MemName2.Name = "textBox_MemName2";
            this.textBox_MemName2.Size = new System.Drawing.Size(683, 41);
            this.textBox_MemName2.TabIndex = 6;
            this.textBox_MemName2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_MemName2.TextChanged += new System.EventHandler(this.textBox_MemName2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(292, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(527, 63);
            this.label2.TabIndex = 10;
            this.label2.Text = "熊貓快遞公司後台系統";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(18, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 775);
            this.panel1.TabIndex = 28;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(22, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 55);
            this.label7.TabIndex = 11;
            this.label7.Text = "人員職稱";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(11, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(359, 53);
            this.label8.TabIndex = 12;
            this.label8.Text = "指定資產品項名稱";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 25F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(11, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(359, 53);
            this.label10.TabIndex = 14;
            this.label10.Text = "指定資產負責人員";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(22, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(196, 55);
            this.label11.TabIndex = 15;
            this.label11.Text = "人員姓名";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(20, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(529, 673);
            this.panel2.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel3.Controls.Add(this.comboBox3);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.checkBox3);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.checkBox2);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(562, 90);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(773, 673);
            this.panel3.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(31, 595);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(462, 53);
            this.button1.TabIndex = 16;
            this.button1.Text = "修改人員資料";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(30, 595);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(713, 53);
            this.button2.TabIndex = 17;
            this.button2.Text = "修改資產資料";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("微軟正黑體", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox1.Location = new System.Drawing.Point(32, 530);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(175, 59);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "已離職";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("微軟正黑體", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox2.Location = new System.Drawing.Point(30, 519);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(175, 59);
            this.checkBox2.TabIndex = 18;
            this.checkBox2.Text = "已報銷";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(214, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(279, 41);
            this.textBox1.TabIndex = 18;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox2.Location = new System.Drawing.Point(214, 137);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(279, 41);
            this.textBox2.TabIndex = 19;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(376, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(366, 40);
            this.comboBox1.TabIndex = 19;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox3.Location = new System.Drawing.Point(376, 222);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(366, 41);
            this.textBox3.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(22, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(196, 55);
            this.label9.TabIndex = 20;
            this.label9.Text = "人員考績";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(214, 214);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(279, 40);
            this.comboBox2.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微軟正黑體", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(22, 284);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(196, 55);
            this.label12.TabIndex = 22;
            this.label12.Text = "所在城市";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox4.Location = new System.Drawing.Point(214, 291);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(279, 41);
            this.textBox4.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微軟正黑體", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.Location = new System.Drawing.Point(22, 361);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(196, 55);
            this.label13.TabIndex = 24;
            this.label13.Text = "詳細地址";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox5.Location = new System.Drawing.Point(214, 361);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(279, 41);
            this.textBox5.TabIndex = 25;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("微軟正黑體", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox3.Location = new System.Drawing.Point(30, 454);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(175, 59);
            this.checkBox3.TabIndex = 21;
            this.checkBox3.Text = "已歸還";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微軟正黑體", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.Location = new System.Drawing.Point(22, 430);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(196, 55);
            this.label14.TabIndex = 26;
            this.label14.Text = "手機號碼";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox6.Location = new System.Drawing.Point(214, 442);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(279, 41);
            this.textBox6.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微軟正黑體", 25F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(11, 131);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(359, 53);
            this.label15.TabIndex = 22;
            this.label15.Text = "指定資產借用人員";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(376, 138);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(366, 40);
            this.comboBox3.TabIndex = 23;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("微軟正黑體", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(1150, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 63);
            this.button3.TabIndex = 18;
            this.button3.Text = "編輯";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1380, 799);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox_MemName2);
            this.Controls.Add(this.BtnWriteData);
            this.Controls.Add(this.tebWriteData);
            this.Controls.Add(this.textBox_MemID2);
            this.Controls.Add(this.label_name2);
            this.Controls.Add(this.BtnReadData);
            this.Controls.Add(this.tebReadData);
            this.Controls.Add(this.label_member2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LoadKey);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.KeyAB);
            this.Controls.Add(this.Block);
            this.Controls.Add(this.Sector);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbl_message4);
            this.Controls.Add(this.lbl_message3);
            this.Controls.Add(this.but_SpendPoint);
            this.Controls.Add(this.textBox_Point4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but_AddPoint);
            this.Controls.Add(this.but_CleanCard);
            this.Controls.Add(this.textBox_Point3);
            this.Controls.Add(this.label_point3);
            this.Controls.Add(this.textBox_Point2);
            this.Controls.Add(this.textBox_SignDay2);
            this.Controls.Add(this.but_SignCard);
            this.Controls.Add(this.label_point2);
            this.Controls.Add(this.textBox_Point);
            this.Controls.Add(this.label_SignDay2);
            this.Controls.Add(this.textBox_SignDay);
            this.Controls.Add(this.textBox_MemName);
            this.Controls.Add(this.textBox_MemID);
            this.Controls.Add(this.label_point);
            this.Controls.Add(this.label_SignDay);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_member);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "熊貓快遞公司";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox Sector;
        private System.Windows.Forms.ComboBox Block;
        private System.Windows.Forms.ComboBox KeyAB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LoadKey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tebReadData;
        private System.Windows.Forms.Button BtnReadData;
        private System.Windows.Forms.Button but_CleanCard;
        private System.Windows.Forms.Button but_SignCard;
        private System.Windows.Forms.TextBox textBox_Point;
        private System.Windows.Forms.TextBox textBox_SignDay;
        private System.Windows.Forms.TextBox textBox_MemName;
        private System.Windows.Forms.TextBox textBox_MemID;
        private System.Windows.Forms.Label label_point;
        private System.Windows.Forms.Label label_SignDay;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_member;
        private System.Windows.Forms.TextBox textBox_Point2;
        private System.Windows.Forms.TextBox textBox_SignDay2;
        private System.Windows.Forms.Label label_point2;
        private System.Windows.Forms.Label label_SignDay2;
        private System.Windows.Forms.Button but_SpendPoint;
        private System.Windows.Forms.TextBox textBox_Point4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tebWriteData;
        private System.Windows.Forms.Button BtnWriteData;
        private System.Windows.Forms.Label lbl_message4;
        private System.Windows.Forms.Button but_AddPoint;
        private System.Windows.Forms.Label lbl_message3;
        private System.Windows.Forms.Label label_point3;
        private System.Windows.Forms.TextBox textBox_Point3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private TextBox textBox_MemID2;
        private Label label_name2;
        private Label label_member2;
        private TextBox textBox_MemName2;
        private Label label2;
        private Panel panel1;
        private Label label8;
        private Label label7;
        private Label label11;
        private Label label10;
        private Panel panel3;
        private Button button2;
        private Panel panel2;
        private Button button1;
        private CheckBox checkBox2;
        private TextBox textBox2;
        private TextBox textBox1;
        private CheckBox checkBox1;
        private Label label15;
        private CheckBox checkBox3;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private TextBox textBox6;
        private Label label14;
        private TextBox textBox5;
        private Label label13;
        private TextBox textBox4;
        private Label label12;
        private ComboBox comboBox2;
        private Label label9;
        private ComboBox comboBox3;
        private Button button3;
    }
}

