using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using System.BitConverter;

namespace WindowsFormsApplication6
{
    public partial class Form2 : Form
    {
        MySqlConnection conn;
        const int idCol = 1;
        public Form2(String eid)
        {
            string myConnStr = "server=rfiddatabase.codn1rmbkzxk.us-east-2.rds.amazonaws.com;database=RFID_BINARY_DB;uid=admin;pwd=rfid123123;";
            conn = new MySqlConnection(myConnStr);
            try
            {
            conn.Open();
            Console.WriteLine("conn");           
            InitializeComponent();
            MySqlCommand command = new MySqlCommand("select * from device where owner_id = \"" + eid + "\"; ");
            //MySqlCommand command = new MySqlCommand("select item_name from device");
            MySqlDataAdapter da = new MySqlDataAdapter(command);
                da.SelectCommand.Connection = conn;
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBox1.Items.Add("負責的資產列表");
                comboBox1.SelectedIndex = 0;
                foreach (DataRow dr in dt.Rows)
                {                   
                    comboBox1.Items.Add(dr["item_name"]);
                    Console.WriteLine(dr["item_name"]);
                }

                //conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("not conn");
            }

            ShowContent();
        }

        unsafe public void ShowContent()
        {
            textBox_SignDay2.Text = String.Format("{0:yyyy/MM/dd}", DateTime.Now);
            //textBox_Point2.Text = "1867";
            string R01 = "";
            string R02 = "";
            string R03 = "";
            string R04 = "";
            string R05 = "";
            string R06 = "";
            string R07 = "";
            string R08 = "";
            // 讀取 0100---textBox_MemID2
            string tmp0100 = "";
            string SNum0100 = "-1", BNum0100 = "-1", KType0100 = "-1"; //參數預設
            SNum0100 = "01";
            BNum0100 = "00";
            KType0100 = "60";
            string ReadCmd0100 = "020A15"; //讀取commend 0x02, 0x0A, 0x15,
            string TX0100 = ReadCmd0100 + KType0100 + LoadKey.Text + SNum0100 + BNum0100; //組成 Read Data Request
            UInt32 uiLength0100, uiRead0100, uiResult0100, uiWritten0100;
            byte[] ReadBuffer0100 = new byte[0x40];
            //byte[] WriteBuffer = new byte[] { 0x02, 0x0A, 0x15, 0x60, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x02, 0x01 };
            byte[] WriteBuffer0100 = StringToByteArray(TX0100);
            byte[] sResponse0100 = null;
            sResponse0100 = new byte[21];
            EasyPOD.VID = 0xe6a;
            EasyPOD.PID = 0x317;
            Index = 1;
            uiLength0100 = 64;
            fixed (MW_EasyPOD* pPOD = &EasyPOD)
            {
                dwResult = PODfuncs.ConnectPOD(pPOD, Index);
                if ((dwResult != 0))
                {
                    MessageBox.Show("Not connected yet");
                }
                else
                {
                    EasyPOD.ReadTimeOut = 200;
                    EasyPOD.WriteTimeOut = 200;
                    dwResult = PODfuncs.WriteData(pPOD, WriteBuffer0100, 12, &
                        uiWritten0100); //Send a request command to reader  ,buffer 讀取12個 command 碼
                    uiResult0100 = PODfuncs.ReadData(pPOD, ReadBuffer0100, uiLength0100, &
                        uiRead0100); //Read the response data from reader
                    tmp0100 = BitConverter.ToString(ReadBuffer0100, 4, (Int32)uiRead0100 - 4).Replace("-", ""); //HEX  從 4 之後開始 讀取 data (Response 欄位 0~4 為 02 12 15 00)
                    //tmp0100, 32 Bytes, Substring 從 0 算數
                    bool result = Select(tmp0100);
                    Console.WriteLine("ooo:::" + result);
                    if (!result)
                    {
                        textBox_MemID2.Text = "";
                        textBox_MemName2.Text = "";
                        return;
                    }
                    textBox_MemID2.Text = tmp0100;//R01 + R02 + R03 + R04 + R05 + R06 + R07 + R08;                   

                }
                dwResult = PODfuncs.ClearPODBuffer(pPOD);
                dwResult = PODfuncs.DisconnectPOD(pPOD);
            }
            // 讀取 0100 end

            // 讀取 0101---textBox_MemName2
            string tmp0101 = "";
            string SNum0101 = "-1", BNum0101 = "-1", KType0101 = "-1"; //參數預設
            SNum0101 = "01";
            BNum0101 = "01";
            KType0101 = "60";
            string ReadCmd0101 = "020A15"; //讀取commend 0x02, 0x0A, 0x15,
            string TX0101 = ReadCmd0101 + KType0101 + LoadKey.Text + SNum0101 + BNum0101; //組成 Read Data Request
            UInt32 uiLength0101, uiRead0101, uiResult0101, uiWritten0101;
            byte[] ReadBuffer0101 = new byte[0x40];
            //byte[] WriteBuffer = new byte[] { 0x02, 0x0A, 0x15, 0x60, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x02, 0x01 };
            byte[] WriteBuffer0101 = StringToByteArray(TX0101);
            byte[] sResponse0101 = null;
            sResponse0101 = new byte[21];
            EasyPOD.VID = 0xe6a;
            EasyPOD.PID = 0x317;
            Index = 1;
            uiLength0101 = 64;
            fixed (MW_EasyPOD* pPOD = &EasyPOD)
            {
                dwResult = PODfuncs.ConnectPOD(pPOD, Index);
                if ((dwResult != 0))
                {
                    MessageBox.Show("Not connected yet");
                }
                else
                {
                    EasyPOD.ReadTimeOut = 200;
                    EasyPOD.WriteTimeOut = 200;
                    dwResult = PODfuncs.WriteData(pPOD, WriteBuffer0101, 12, &
                        uiWritten0101); //Send a request command to reader  ,buffer 讀取12個 command 碼
                    uiResult0101 = PODfuncs.ReadData(pPOD, ReadBuffer0101, uiLength0101, &
                        uiRead0101); //Read the response data from reader
                    tmp0101 = BitConverter.ToString(ReadBuffer0101, 4, (Int32)uiRead0101 - 4).Replace("-",
                        ""); //HEX  從 4 之後開始 讀取 data (Response 欄位 0~4 為 02 12 15 00)
                    //tmp0101, 32 Bytes, Substring 從 0 算數
                    R01 = UnicodeToString(@"\u" + tmp0101.Substring(0, 4));
                    R02 = UnicodeToString(@"\u" + tmp0101.Substring(4, 4));
                    R03 = UnicodeToString(@"\u" + tmp0101.Substring(8, 4));
                    R04 = UnicodeToString(@"\u" + tmp0101.Substring(12, 4));
                    R05 = UnicodeToString(@"\u" + tmp0101.Substring(16, 4));
                    R06 = UnicodeToString(@"\u" + tmp0101.Substring(20, 4));
                    R07 = UnicodeToString(@"\u" + tmp0101.Substring(24, 4));
                    R08 = UnicodeToString(@"\u" + tmp0101.Substring(28, 4));
                    textBox_MemName2.Text = (R01 + R02 + R03 + R04 + R05 + R06 + R07 + R08).Replace("0", "");    // 去掉 0
                }
                dwResult = PODfuncs.ClearPODBuffer(pPOD);
                dwResult = PODfuncs.DisconnectPOD(pPOD);
            }
            //// 讀取 0200---textBox_Point2
            //String tmpPoint = "";
            //Int32 num1 = 0;
            //string tmp0200 = "";
            //string SNum0200 = "-1", BNum0200 = "-1", KType0200 = "-1"; //參數預設
            //SNum0200 = "02";
            //BNum0200 = "00";
            //KType0200 = "60";
            //string ReadCmd0200 = "020A15"; //讀取commend 0x02, 0x0A, 0x15,
            //string TX0200 = ReadCmd0200 + KType0200 + LoadKey.Text + SNum0200 + BNum0200; //組成 Read Data Request
            //UInt32 uiLength0200, uiRead0200, uiResult0200, uiWritten0200;
            //byte[] ReadBuffer0200 = new byte[0x40];
            ////byte[] WriteBuffer = new byte[] { 0x02, 0x0A, 0x15, 0x60, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x02, 0x01 };
            //byte[] WriteBuffer0200 = StringToByteArray(TX0200);
            //byte[] sResponse0200 = null;
            //sResponse0200 = new byte[21];
            //EasyPOD.VID = 0xe6a;
            //EasyPOD.PID = 0x317;
            //Index = 1;
            //uiLength0200 = 64;
            //fixed (MW_EasyPOD* pPOD = &EasyPOD)
            //{
            //    dwResult = PODfuncs.ConnectPOD(pPOD, Index);
            //    if ((dwResult != 0))
            //    {
            //        MessageBox.Show("Not connected yet");
            //    }
            //    else
            //    {
            //        EasyPOD.ReadTimeOut = 200;
            //        EasyPOD.WriteTimeOut = 200;
            //        dwResult = PODfuncs.WriteData(pPOD, WriteBuffer0200, 12, &
            //            uiWritten0200); //Send a request command to reader  ,buffer 讀取12個 command 碼
            //        uiResult0200 = PODfuncs.ReadData(pPOD, ReadBuffer0200, uiLength0200, &
            //            uiRead0200); //Read the response data from reader
            //        tmp0200 = BitConverter.ToString(ReadBuffer0200, 4, (Int32)uiRead0200 - 4).Replace("-",
            //            ""); //HEX  從 4 之後開始 讀取 data (Response 欄位 0~4 為 02 12 15 00)
            //        String tmp1 = tmp0200.Substring(0, 24);
            //        num1 = Convert.ToInt32(tmp1, 16);
            //        //Console.WriteLine(num1);
            //        textBox_Point2.Text = num1.ToString();
            //    }
            //    dwResult = PODfuncs.ClearPODBuffer(pPOD);
            //    dwResult = PODfuncs.DisconnectPOD(pPOD);
            //}
            //// 讀取 0200 end
            //// 0200---Point---8個Data
            //tmpPoint = num1.ToString().PadLeft(24, '0') + "00FF00FF"; ;
            //SNum0200 = "02";
            //BNum0200 = "00";
            //KType0200 = "60";
            //string tmpWriteData0200 = tmpPoint;
            //string LLoadKey0200 = "FFFFFFFFFFFF";
            //string WriteCmd0200 = "021A16"; //寫入commend 0x02, 0x1A, 0x16,
            //TX0200 = WriteCmd0200 + KType0200 + LLoadKey0200 + SNum0200 + BNum0200 + tmpWriteData0200; //組成 Read Data Request
            //Console.WriteLine("iii::" + TX0200);
            ////Console.WriteLine("TX0200 :" + TX0200);
            //ReadBuffer0200 = new byte[0x40];
            ////byte[] WriteBuffer = new byte[] { 0x02, 0x0A, 0x15, 0x60, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x02, 0x01 };
            //WriteBuffer0200 = StringToByteArray(TX0200);
            //sResponse0200 = null;
            //sResponse0200 = new byte[21];
            //EasyPOD.VID = 0xe6a;
            //EasyPOD.PID = 0x317;
            //Index = 1;
            //uiLength0200 = 64;
            //fixed (MW_EasyPOD* pPOD = &EasyPOD)
            //{
            //    dwResult = PODfuncs.ConnectPOD(pPOD, Index);
            //    if ((dwResult != 0))
            //    {
            //        MessageBox.Show("Not connected yet");
            //    }
            //    else
            //    {
            //        EasyPOD.ReadTimeOut = 200;
            //        EasyPOD.WriteTimeOut = 200;
            //        dwResult = PODfuncs.WriteData(pPOD, WriteBuffer0200, 28, &uiWritten0200); //Send a request command to reader  ,buffer 讀取12個 command 碼 + 16 byte data，所以讀28個
            //        uiResult0200 = PODfuncs.ReadData(pPOD, ReadBuffer0200, uiLength0200, &uiRead0200); //Read the response data from reader
            //        tebReadData.Text = BitConverter.ToString(AddByteToArray(ReadBuffer0200, 1), 4, (Int32)uiRead0200 - 4).Replace("-", "");//BitConverter.ToString(ReadBuffer0200, 4, (Int32)uiRead0200 - 4).Replace("-", ""); //HEX  從 4 之後開始 寫入 data (Response 欄位 0~4 為 02 12 16 00 ，這四個之後才是data)
            //    }
            //    dwResult = PODfuncs.ClearPODBuffer(pPOD);
            //    dwResult = PODfuncs.DisconnectPOD(pPOD);
            //    textBox_Point2.Text = tebReadData.Text;
            //}
            ////0200 END      
            ///
            string tmpPoint = textBox_Point3.Text;
            string tmpWritePoint = "";
            Int32 Point = 0;
            Int32 PointWrite = 0;
            Point = Convert.ToInt32(tmpPoint); // Convert.ToInt32 十進制
            Int32 SumPoint = 0;

            // 讀取 0200Read---textBox_Point2
            string tmp0200Read = "";
            string SNum0200Read = "-1", BNum0200Read = "-1", KType0200Read = "-1"; //參數預設
            SNum0200Read = "02";
            BNum0200Read = "00";
            KType0200Read = "60";
            string ReadCmd0200Read = "020A15"; //讀取commend 0x02, 0x0A, 0x15,
            string TX0200Read = ReadCmd0200Read + KType0200Read + LoadKey.Text + SNum0200Read + BNum0200Read; //組成 Read Data Request
            UInt32 uiLength0200Read, uiRead0200Read, uiResult0200Read, uiWritten0200Read;
            byte[] ReadBuffer0200Read = new byte[0x40];
            //byte[] WriteBuffer = new byte[] { 0x02, 0x0A, 0x15, 0x60, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x02, 0x01 };
            byte[] WriteBuffer0200Read = StringToByteArray(TX0200Read);
            byte[] sResponse0200Read = null;
            sResponse0200Read = new byte[21];
            EasyPOD.VID = 0xe6a;
            EasyPOD.PID = 0x317;
            Index = 1;
            uiLength0200Read = 64;
            fixed (MW_EasyPOD* pPOD = &EasyPOD)
            {
                dwResult = PODfuncs.ConnectPOD(pPOD, Index);
                if ((dwResult != 0))
                {
                    MessageBox.Show("Not connected yet");
                }
                else
                {
                    EasyPOD.ReadTimeOut = 200;
                    EasyPOD.WriteTimeOut = 200;
                    dwResult = PODfuncs.WriteData(pPOD, WriteBuffer0200Read, 12, &
                        uiWritten0200Read); //Send a request command to reader  ,buffer 讀取12個 command 碼
                    uiResult0200Read = PODfuncs.ReadData(pPOD, ReadBuffer0200Read, uiLength0200Read, &
                        uiRead0200Read); //Read the response data from reader
                    tmp0200Read = BitConverter.ToString(ReadBuffer0200Read, 4, (Int32)uiRead0200Read - 4).Replace("-",
                        ""); //HEX  從 4 之後開始 讀取 data (Response 欄位 0~4 為 02 12 15 00)
                    String tmp1 = tmp0200Read.Substring(0, 24);
                    Int32 num1 = Convert.ToInt32(tmp1, 16);
                    //Console.WriteLine(num1);
                    SumPoint = num1 + 1;

                    textBox_Point2.Text = SumPoint.ToString();
                }
                dwResult = PODfuncs.ClearPODBuffer(pPOD);
                dwResult = PODfuncs.DisconnectPOD(pPOD);
            }
            // 讀取 0200Read end            

            tmpWritePoint = SumPoint.ToString();
            // 如：999999999999(十進制) 轉為 E8D4A50FFF （十六進制）。
            // 先把 E8D4A50FFF，補零至 24個 bytes即 0000 0000 0000 00E8 D4A5 0FFF，再寫入至 block 中。
            PointWrite = Convert.ToInt32(tmpWritePoint); // Convert.ToInt32(string), 十進制
            tmpWritePoint = Convert.ToString(PointWrite, 16); // Convert.ToString(int32,16), 十進制→十六進制
            tmpWritePoint = tmpWritePoint.PadLeft(24, '0') + "00FF00FF";       // 不足 24個 Bytes，要補零

            // 0200Write---Point---8個Data
            string SNum0200Write = "-1", BNum0200Write = "-1", KType0200Write = "-1"; //參數預設
            SNum0200Write = "02";
            BNum0200Write = "00";
            KType0200Write = "60";
            string tmpWriteData0200Write = tmpWritePoint;
            string LLoadKey0200Write = "FFFFFFFFFFFF";
            string WriteCmd0200Write = "021A16"; //寫入commend 0x02, 0x1A, 0x16,
            string TX0200Write = WriteCmd0200Write + KType0200Write + LLoadKey0200Write + SNum0200Write + BNum0200Write + tmpWriteData0200Write; //組成 Read Data Request
            //Console.WriteLine("TX0200Write :" + TX0200Write);
            UInt32 uiLength0200Write, uiRead0200Write, uiResult0200Write, uiWritten0200Write;
            byte[] ReadBuffer0200Write = new byte[0x40];
            //byte[] WriteBuffer = new byte[] { 0x02, 0x0A, 0x15, 0x60, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x02, 0x01 };
            byte[] WriteBuffer0200Write = StringToByteArray(TX0200Write);
            byte[] sResponse0200Write = null;
            sResponse0200Write = new byte[21];
            EasyPOD.VID = 0xe6a;
            EasyPOD.PID = 0x317;
            Index = 1;
            uiLength0200Write = 64;
            fixed (MW_EasyPOD* pPOD = &EasyPOD)
            {
                dwResult = PODfuncs.ConnectPOD(pPOD, Index);
                if ((dwResult != 0))
                {
                    MessageBox.Show("Not connected yet");
                }
                else
                {
                    EasyPOD.ReadTimeOut = 200;
                    EasyPOD.WriteTimeOut = 200;
                    dwResult = PODfuncs.WriteData(pPOD, WriteBuffer0200Write, 28, &uiWritten0200Write); //Send a request command to reader  ,buffer 讀取12個 command 碼 + 16 byte data，所以讀28個
                    uiResult0200Write = PODfuncs.ReadData(pPOD, ReadBuffer0200Write, uiLength0200Write, &uiRead0200Write); //Read the response data from reader
                    tebReadData.Text = BitConverter.ToString(ReadBuffer0200Write, 4, (Int32)uiRead0200Write - 4).Replace("-", ""); //HEX  從 4 之後開始 寫入 data (Response 欄位 0~4 為 02 12 16 00 ，這四個之後才是data)
                }
                dwResult = PODfuncs.ClearPODBuffer(pPOD);
                dwResult = PODfuncs.DisconnectPOD(pPOD);
            }
        }

        ~Form2()
        {
            conn.Close();
            Console.WriteLine("close conn");
        }
        MW_EasyPOD EasyPOD;
        UInt32 dwResult, Index;
        bool SC, BC, KC = false;  //參數預設

        /// <summary>
        /// 讀取
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        unsafe public void BtnReadData_Click(object sender, EventArgs e)
        {
            string SNum = "-1", BNum = "-1", KType = "-1";  //參數預設
            SNum = Sector.Text;
            BNum = Block.Text;
            if (KeyAB.Text == "A")  //選擇 key A,B
            {
                KType = "60";
            }
            else
            {
                KType = "61";
            }
            string ReadCmd = "020A15";  //讀取commend 0x02, 0x0A, 0x15,
            string TX = ReadCmd + KType + LoadKey.Text + SNum + BNum;         //組成 Read Data Request
            UInt32 uiLength, uiRead, uiResult, uiWritten;
            byte[] ReadBuffer = new byte[0x40];
            //byte[] WriteBuffer = new byte[] { 0x02, 0x0A, 0x15, 0x60, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x02, 0x01 };
            byte[] WriteBuffer = StringToByteArray(TX);
            byte[] sResponse = null;
            sResponse = new byte[21];
            EasyPOD.VID = 0xe6a;
            EasyPOD.PID = 0x317;
            Index = 1;
            uiLength = 64;
            fixed (MW_EasyPOD* pPOD = &EasyPOD)
            {
                dwResult = PODfuncs.ConnectPOD(pPOD, Index);
                if ((dwResult != 0))
                {
                    MessageBox.Show("Not connected yet");
                }
                else
                {
                    EasyPOD.ReadTimeOut = 200;
                    EasyPOD.WriteTimeOut = 200;
                    dwResult = PODfuncs.WriteData(pPOD, WriteBuffer, 12, &uiWritten);    //Send a request command to reader  ,buffer 讀取12個 command 碼
                    uiResult = PODfuncs.ReadData(pPOD, ReadBuffer, uiLength, &uiRead);  //Read the response data from reader
                    tebReadData.Text = BitConverter.ToString(ReadBuffer, 4, (Int32)uiRead - 4).Replace("-", "");  //HEX  從 4 之後開始 讀取 data (Response 欄位 0~4 為 02 12 15 00)
                }
                dwResult = PODfuncs.ClearPODBuffer(pPOD);
                dwResult = PODfuncs.DisconnectPOD(pPOD);
            }
        }
        /// <summary>
        /// 寫入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        unsafe public void BtnWriteData_Click(object sender, EventArgs e)
        {
            string SNum = "-1", BNum = "-1", KType = "-1";  //參數預設
            SNum = Sector.Text;
            BNum = Block.Text;
            if (KeyAB.Text == "A")  //選擇 key A,B
            {
                KType = "60";
            }
            else
            {
                KType = "61";
            }
            string WriteCmd = "021A16";  //寫入commend 0x02, 0x1A, 0x16,
            string TX = WriteCmd + KType + LoadKey.Text + SNum + BNum + tebWriteData.Text;         //組成 Read Data Request
            UInt32 uiLength, uiRead, uiResult, uiWritten;
            byte[] ReadBuffer = new byte[0x40];
            //byte[] WriteBuffer = new byte[] { 0x02, 0x0A, 0x15, 0x60, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x02, 0x01 };
            byte[] WriteBuffer = StringToByteArray(TX);
            byte[] sResponse = null;
            sResponse = new byte[21];
            EasyPOD.VID = 0xe6a;
            EasyPOD.PID = 0x317;
            Index = 1;
            uiLength = 64;
            fixed (MW_EasyPOD* pPOD = &EasyPOD)
            {
                dwResult = PODfuncs.ConnectPOD(pPOD, Index);
                if ((dwResult != 0))
                {
                    MessageBox.Show("Not connected yet");
                }
                else
                {
                    EasyPOD.ReadTimeOut = 200;
                    EasyPOD.WriteTimeOut = 200;
                    dwResult = PODfuncs.WriteData(pPOD, WriteBuffer, 28, &uiWritten);    //Send a request command to reader  ,buffer 讀取12個 command 碼 + 16 byte data，所以讀28個
                    uiResult = PODfuncs.ReadData(pPOD, ReadBuffer, uiLength, &uiRead);  //Read the response data from reader
                    tebReadData.Text = BitConverter.ToString(ReadBuffer, 4, (Int32)uiRead - 4).Replace("-", "");  //HEX  從 4 之後開始 寫入 data (Response 欄位 0~4 為 02 12 16 00 ，這四個之後才是data)
                }
                dwResult = PODfuncs.ClearPODBuffer(pPOD);
                dwResult = PODfuncs.DisconnectPOD(pPOD);
            }
        }


        /// <summary>
        /// StringToByteArray 字串轉型
        /// </summary>
        /// <param name="hex"></param>
        /// <returns></returns>
        public static byte[] StringToByteArray(String hex)
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }

        /// <summary>
        /// 頁面初始(下拉選單參數等)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form2_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < 16; i++)
            {
                Sector.Items.Add(i.ToString("00"));
            }

            for (int j = 0; j < 4; j++)
            {
                Block.Items.Add(j.ToString("00"));
            }

            KeyAB.Items.Add("A");
            KeyAB.Items.Add("B");

            BtnReadData.Enabled = false;
            BtnWriteData.Enabled = false;

            this.FormClosing += new FormClosingEventHandler(Form2_Closing);
        }

    private void Form2_Closing(object sender, EventArgs e)
    {
        conn.Close();
        Console.WriteLine("6666");
    }
    


        /// <summary>
        /// Sector 防呆
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sector_SelectedIndexChanged(object sender, EventArgs e)
        {
            tebReadData.Text = "";
            BtnReadData.Enabled = false;
            SC = true;
            if (SC == true && BC == true && KC == true)
            {
                if (LoadKey.TextLength == 12)
                {
                    BtnReadData.Enabled = true;
                }
            }
        }

        /// <summary>
        /// Block 防呆
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Block_SelectedIndexChanged(object sender, EventArgs e)
        {
            tebReadData.Text = "";
            BtnReadData.Enabled = false;
            BC = true;
            if (SC == true && BC == true && KC == true)
            {
                if (LoadKey.TextLength == 12)
                {
                    BtnReadData.Enabled = true;
                }
            }
        }

        /// <summary>
        /// 寫入防呆 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tebWriteData_TextChanged(object sender, EventArgs e)
        {
            BtnWriteData.Enabled = false;
            if (tebWriteData.TextLength == 32)
            {
                BtnWriteData.Enabled = true;
            }

        }

        private void textBox_SignDay_TextChanged(object sender, EventArgs e)
        {

        }

        unsafe private void but_SignCard_Click(object sender, EventArgs e)
        {

        }

        unsafe private void but_CleanCard_Click(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// KeyAB 防呆
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KeyAB_SelectedIndexChanged(object sender, EventArgs e)
        {
            tebReadData.Text = "";
            BtnReadData.Enabled = false;
            KC = true;
            if (SC == true && BC == true && KC == true)
            {
                if (LoadKey.TextLength == 12)
                {
                    BtnReadData.Enabled = true;
                }
            }
        }

        /// <summary>
        /// LoadKey防呆
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadKey_TextChanged(object sender, EventArgs e)
        {
            BtnReadData.Enabled = false;
            if (SC == true && BC == true && KC == true)
            {
                if (LoadKey.TextLength == 12)
                {
                    BtnReadData.Enabled = true;
                }
            }
        }

        public bool Select(string id)
        {
            string query = "SELECT * FROM employee WHERE id = '" + id + "'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                //if (!reader.IsDBNull(idCol))
                {
                    bool isRead = false;
                    while (reader.Read())
                    {
                        string DBEmployeeId = reader.GetString("id");

                        Console.WriteLine("tttt::" + DBEmployeeId);
                        isRead = true;
                    }
                    if (!isRead)
                    {
                        return false;
                    }
                    return true;
                }
                MessageBox.Show("不存在此位員工");
                return false;
            }
            catch
            {
                MessageBox.Show("不存在此位員工");
                return false;
            }

        }

        unsafe private void but_ReadCard_Click(object sender, EventArgs e)
        {

            // R01 至 R08，uncode → string, 拼接
            string R01 = "";
            string R02 = "";
            string R03 = "";
            string R04 = "";
            string R05 = "";
            string R06 = "";
            string R07 = "";
            string R08 = "";
            // 讀取 0100---textBox_MemID2
            string tmp0100 = "";
            string SNum0100 = "-1", BNum0100 = "-1", KType0100 = "-1"; //參數預設
            SNum0100 = "01";
            BNum0100 = "00";
            KType0100 = "60";
            string ReadCmd0100 = "020A15"; //讀取commend 0x02, 0x0A, 0x15,
            string TX0100 = ReadCmd0100 + KType0100 + LoadKey.Text + SNum0100 + BNum0100; //組成 Read Data Request
            UInt32 uiLength0100, uiRead0100, uiResult0100, uiWritten0100;
            byte[] ReadBuffer0100 = new byte[0x40];
            //byte[] WriteBuffer = new byte[] { 0x02, 0x0A, 0x15, 0x60, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x02, 0x01 };
            byte[] WriteBuffer0100 = StringToByteArray(TX0100);
            byte[] sResponse0100 = null;
            sResponse0100 = new byte[21];
            EasyPOD.VID = 0xe6a;
            EasyPOD.PID = 0x317;
            Index = 1;
            uiLength0100 = 64;
            fixed (MW_EasyPOD* pPOD = &EasyPOD)
            {
                dwResult = PODfuncs.ConnectPOD(pPOD, Index);
                if ((dwResult != 0))
                {
                    MessageBox.Show("Not connected yet");
                }
                else
                {
                    EasyPOD.ReadTimeOut = 200;
                    EasyPOD.WriteTimeOut = 200;
                    dwResult = PODfuncs.WriteData(pPOD, WriteBuffer0100, 12, &
                        uiWritten0100); //Send a request command to reader  ,buffer 讀取12個 command 碼
                    uiResult0100 = PODfuncs.ReadData(pPOD, ReadBuffer0100, uiLength0100, &
                        uiRead0100); //Read the response data from reader
                    tmp0100 = BitConverter.ToString(ReadBuffer0100, 4, (Int32)uiRead0100 - 4).Replace("-", ""); //HEX  從 4 之後開始 讀取 data (Response 欄位 0~4 為 02 12 15 00)
                    
                    bool result = Select(tmp0100);
                    Console.WriteLine("ooo:::" + result);
                    if (!result)
                    {
                        textBox_MemID2.Text = "";
                        textBox_MemName2.Text = "";
                        return;
                    }
                    textBox_MemID2.Text = tmp0100;//R01 + R02 + R03 + R04 + R05 + R06 + R07 + R08;                   

                }
                dwResult = PODfuncs.ClearPODBuffer(pPOD);
                dwResult = PODfuncs.DisconnectPOD(pPOD);
            }
            // 讀取 0100 end

            // 讀取 0101---textBox_MemName2
            string tmp0101 = "";
            string SNum0101 = "-1", BNum0101 = "-1", KType0101 = "-1"; //參數預設
            SNum0101 = "01";
            BNum0101 = "01";
            KType0101 = "60";
            string ReadCmd0101 = "020A15"; //讀取commend 0x02, 0x0A, 0x15,
            string TX0101 = ReadCmd0101 + KType0101 + LoadKey.Text + SNum0101 + BNum0101; //組成 Read Data Request
            UInt32 uiLength0101, uiRead0101, uiResult0101, uiWritten0101;
            byte[] ReadBuffer0101 = new byte[0x40];
            //byte[] WriteBuffer = new byte[] { 0x02, 0x0A, 0x15, 0x60, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x02, 0x01 };
            byte[] WriteBuffer0101 = StringToByteArray(TX0101);
            byte[] sResponse0101 = null;
            sResponse0101 = new byte[21];
            EasyPOD.VID = 0xe6a;
            EasyPOD.PID = 0x317;
            Index = 1;
            uiLength0101 = 64;
            fixed (MW_EasyPOD* pPOD = &EasyPOD)
            {
                dwResult = PODfuncs.ConnectPOD(pPOD, Index);
                if ((dwResult != 0))
                {
                    MessageBox.Show("Not connected yet");
                }
                else
                {
                    EasyPOD.ReadTimeOut = 200;
                    EasyPOD.WriteTimeOut = 200;
                    dwResult = PODfuncs.WriteData(pPOD, WriteBuffer0101, 12, &
                        uiWritten0101); //Send a request command to reader  ,buffer 讀取12個 command 碼
                    uiResult0101 = PODfuncs.ReadData(pPOD, ReadBuffer0101, uiLength0101, &
                        uiRead0101); //Read the response data from reader
                    tmp0101 = BitConverter.ToString(ReadBuffer0101, 4, (Int32)uiRead0101 - 4).Replace("-",
                        ""); //HEX  從 4 之後開始 讀取 data (Response 欄位 0~4 為 02 12 15 00)
                    //tmp0101, 32 Bytes, Substring 從 0 算數
                    R01 = UnicodeToString(@"\u" + tmp0101.Substring(0, 4));
                    R02 = UnicodeToString(@"\u" + tmp0101.Substring(4, 4));
                    R03 = UnicodeToString(@"\u" + tmp0101.Substring(8, 4));
                    R04 = UnicodeToString(@"\u" + tmp0101.Substring(12, 4));
                    R05 = UnicodeToString(@"\u" + tmp0101.Substring(16, 4));
                    R06 = UnicodeToString(@"\u" + tmp0101.Substring(20, 4));
                    R07 = UnicodeToString(@"\u" + tmp0101.Substring(24, 4));
                    R08 = UnicodeToString(@"\u" + tmp0101.Substring(28, 4));
                    textBox_MemName2.Text = (R01 + R02 + R03 + R04 + R05 + R06 + R07 + R08).Replace("0", "");    // 去掉 0
                }
                dwResult = PODfuncs.ClearPODBuffer(pPOD);
                dwResult = PODfuncs.DisconnectPOD(pPOD);
            }
                 
        }

        public byte[] AddByteToArray(byte[] bArray, byte newByte)
        {
            byte[] newArray = new byte[bArray.Length + 1];
            bArray.CopyTo(newArray, 1);
            newArray[0] = newByte;
            return newArray;
        }

        unsafe private void but_AddPoint_Click(object sender, EventArgs e)
        {

            string tmpPoint = textBox_Point3.Text;
            string tmpWritePoint = "";
            Int32 Point = 0;
            Int32 PointWrite = 0;
            Point = Convert.ToInt32(tmpPoint); // Convert.ToInt32 十進制
            Int32 SumPoint = 0;

            // 讀取 0200Read---textBox_Point2
            string tmp0200Read = "";
            string SNum0200Read = "-1", BNum0200Read = "-1", KType0200Read = "-1"; //參數預設
            SNum0200Read = "02";
            BNum0200Read = "00";
            KType0200Read = "60";
            string ReadCmd0200Read = "020A15"; //讀取commend 0x02, 0x0A, 0x15,
            string TX0200Read = ReadCmd0200Read + KType0200Read + LoadKey.Text + SNum0200Read + BNum0200Read; //組成 Read Data Request
            UInt32 uiLength0200Read, uiRead0200Read, uiResult0200Read, uiWritten0200Read;
            byte[] ReadBuffer0200Read = new byte[0x40];
            //byte[] WriteBuffer = new byte[] { 0x02, 0x0A, 0x15, 0x60, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x02, 0x01 };
            byte[] WriteBuffer0200Read = StringToByteArray(TX0200Read);
            byte[] sResponse0200Read = null;
            sResponse0200Read = new byte[21];
            EasyPOD.VID = 0xe6a;
            EasyPOD.PID = 0x317;
            Index = 1;
            uiLength0200Read = 64;
            fixed (MW_EasyPOD* pPOD = &EasyPOD)
            {
                dwResult = PODfuncs.ConnectPOD(pPOD, Index);
                if ((dwResult != 0))
                {
                    MessageBox.Show("Not connected yet");
                }
                else
                {
                    EasyPOD.ReadTimeOut = 200;
                    EasyPOD.WriteTimeOut = 200;
                    dwResult = PODfuncs.WriteData(pPOD, WriteBuffer0200Read, 12, &
                        uiWritten0200Read); //Send a request command to reader  ,buffer 讀取12個 command 碼
                    uiResult0200Read = PODfuncs.ReadData(pPOD, ReadBuffer0200Read, uiLength0200Read, &
                        uiRead0200Read); //Read the response data from reader
                    tmp0200Read = BitConverter.ToString(ReadBuffer0200Read, 4, (Int32)uiRead0200Read - 4).Replace("-",
                        ""); //HEX  從 4 之後開始 讀取 data (Response 欄位 0~4 為 02 12 15 00)
                    String tmp1 = tmp0200Read.Substring(0, 24);
                    Int32 num1 = Convert.ToInt32(tmp1, 16);
                    //Console.WriteLine(num1);
                    SumPoint = Point + num1;

                    // textBox_Point2.Text = num1.ToString();
                }
                dwResult = PODfuncs.ClearPODBuffer(pPOD);
                dwResult = PODfuncs.DisconnectPOD(pPOD);
            }
            // 讀取 0200Read end            

            tmpWritePoint = SumPoint.ToString();
            // 如：999999999999(十進制) 轉為 E8D4A50FFF （十六進制）。
            // 先把 E8D4A50FFF，補零至 24個 bytes即 0000 0000 0000 00E8 D4A5 0FFF，再寫入至 block 中。
            PointWrite = Convert.ToInt32(tmpWritePoint); // Convert.ToInt32(string), 十進制
            tmpWritePoint = Convert.ToString(PointWrite, 16); // Convert.ToString(int32,16), 十進制→十六進制
            tmpWritePoint = tmpWritePoint.PadLeft(24, '0') + "00FF00FF";       // 不足 24個 Bytes，要補零

            // 0200Write---Point---8個Data
            string SNum0200Write = "-1", BNum0200Write = "-1", KType0200Write = "-1"; //參數預設
            SNum0200Write = "02";
            BNum0200Write = "00";
            KType0200Write = "60";
            string tmpWriteData0200Write = tmpWritePoint;
            string LLoadKey0200Write = "FFFFFFFFFFFF";
            string WriteCmd0200Write = "021A16"; //寫入commend 0x02, 0x1A, 0x16,
            string TX0200Write = WriteCmd0200Write + KType0200Write + LLoadKey0200Write + SNum0200Write + BNum0200Write + tmpWriteData0200Write; //組成 Read Data Request
            //Console.WriteLine("TX0200Write :" + TX0200Write);
            UInt32 uiLength0200Write, uiRead0200Write, uiResult0200Write, uiWritten0200Write;
            byte[] ReadBuffer0200Write = new byte[0x40];
            //byte[] WriteBuffer = new byte[] { 0x02, 0x0A, 0x15, 0x60, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x02, 0x01 };
            byte[] WriteBuffer0200Write = StringToByteArray(TX0200Write);
            byte[] sResponse0200Write = null;
            sResponse0200Write = new byte[21];
            EasyPOD.VID = 0xe6a;
            EasyPOD.PID = 0x317;
            Index = 1;
            uiLength0200Write = 64;
            fixed (MW_EasyPOD* pPOD = &EasyPOD)
            {
                dwResult = PODfuncs.ConnectPOD(pPOD, Index);
                if ((dwResult != 0))
                {
                    MessageBox.Show("Not connected yet");
                }
                else
                {
                    EasyPOD.ReadTimeOut = 200;
                    EasyPOD.WriteTimeOut = 200;
                    dwResult = PODfuncs.WriteData(pPOD, WriteBuffer0200Write, 28, &uiWritten0200Write); //Send a request command to reader  ,buffer 讀取12個 command 碼 + 16 byte data，所以讀28個
                    uiResult0200Write = PODfuncs.ReadData(pPOD, ReadBuffer0200Write, uiLength0200Write, &uiRead0200Write); //Read the response data from reader
                    tebReadData.Text = BitConverter.ToString(ReadBuffer0200Write, 4, (Int32)uiRead0200Write - 4).Replace("-", ""); //HEX  從 4 之後開始 寫入 data (Response 欄位 0~4 為 02 12 16 00 ，這四個之後才是data)
                }
                dwResult = PODfuncs.ClearPODBuffer(pPOD);
                dwResult = PODfuncs.DisconnectPOD(pPOD);
            }
            //0200Write END


            //Console.WriteLine("總點數：" + SumPoint.ToString());
            lbl_message3.Text = "儲值: " + Point.ToString() + "，可用餘額：" + SumPoint.ToString();
            // MessageBox.Show("增加點數完成","儲值完成");
        }

        unsafe private void but_SpendPoint_Click(object sender, EventArgs e)
        {

            string tmpPoint = textBox_Point4.Text;
            string tmpWritePoint = "";
            Int32 Point = 0;
            Int32 PointWrite = 0;
            Point = Convert.ToInt32(tmpPoint); // Convert.ToInt32 十進制
            Int32 SumPoint = 0;

            // 讀取 0200Read---textBox_Point2
            string tmp0200Read = "";
            string SNum0200Read = "-1", BNum0200Read = "-1", KType0200Read = "-1"; //參數預設
            SNum0200Read = "02";
            BNum0200Read = "00";
            KType0200Read = "60";
            string ReadCmd0200Read = "020A15"; //讀取commend 0x02, 0x0A, 0x15,
            string TX0200Read = ReadCmd0200Read + KType0200Read + LoadKey.Text + SNum0200Read + BNum0200Read; //組成 Read Data Request
            UInt32 uiLength0200Read, uiRead0200Read, uiResult0200Read, uiWritten0200Read;
            byte[] ReadBuffer0200Read = new byte[0x40];
            //byte[] WriteBuffer = new byte[] { 0x02, 0x0A, 0x15, 0x60, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x02, 0x01 };
            byte[] WriteBuffer0200Read = StringToByteArray(TX0200Read);
            byte[] sResponse0200Read = null;
            sResponse0200Read = new byte[21];
            EasyPOD.VID = 0xe6a;
            EasyPOD.PID = 0x317;
            Index = 1;
            uiLength0200Read = 64;
            fixed (MW_EasyPOD* pPOD = &EasyPOD)
            {
                dwResult = PODfuncs.ConnectPOD(pPOD, Index);
                if ((dwResult != 0))
                {
                    MessageBox.Show("Not connected yet");
                }
                else
                {
                    EasyPOD.ReadTimeOut = 200;
                    EasyPOD.WriteTimeOut = 200;
                    dwResult = PODfuncs.WriteData(pPOD, WriteBuffer0200Read, 12, &
                        uiWritten0200Read); //Send a request command to reader  ,buffer 讀取12個 command 碼
                    uiResult0200Read = PODfuncs.ReadData(pPOD, ReadBuffer0200Read, uiLength0200Read, &
                        uiRead0200Read); //Read the response data from reader
                    tmp0200Read = BitConverter.ToString(ReadBuffer0200Read, 4, (Int32)uiRead0200Read - 4).Replace("-",
                        ""); //HEX  從 4 之後開始 讀取 data (Response 欄位 0~4 為 02 12 15 00)
                    String tmp1 = tmp0200Read.Substring(0, 24);
                    Int32 num1 = Convert.ToInt32(tmp1, 16);
                    //Console.WriteLine("0200 Read / point: "+Point.ToString());
                    //Console.WriteLine("0200 Read / num1: " + num1.ToString());

                    if (num1 >= Point)
                    {
                        SumPoint = num1 - Point;
                        lbl_message4.Text = "消費: " + Point.ToString() + "，可用餘額：" + SumPoint.ToString();
                    }
                    if (Point > num1)
                    {
                        string tmpM = "";
                        Int32 tmpNum2 = 0;
                        tmpNum2 = ((Point - num1) / 2000) + 1;
                        //Console.WriteLine("0200 Read / tmpNum2 (自動加值次數): " + tmpNum2.ToString());
                        tmpM = tmpM + "由於您的紅利點數不足，\n系統自動幫您加值！\n";
                        tmpM = tmpM + "自動加值：" + (2000).ToString() + "，次數：" + (tmpNum2).ToString() + "\n";
                        SumPoint = ((2000 * tmpNum2) + num1) - Point;
                        tmpM = tmpM + "消費：" + Point + "，可用餘額：" + SumPoint + "\n";
                        lbl_message4.Text = tmpM;
                    }
                    //Console.WriteLine("0200 Read / SumPoint: " + SumPoint.ToString());
                    // textBox_Point2.Text = num1.ToString();
                }
                dwResult = PODfuncs.ClearPODBuffer(pPOD);
                dwResult = PODfuncs.DisconnectPOD(pPOD);
            }
            // 讀取 0200Read end            

            tmpWritePoint = SumPoint.ToString();
            // 如：999999999999(十進制) 轉為 E8D4A50FFF （十六進制）。
            // 先把 E8D4A50FFF，補零至 24個 bytes即 0000 0000 0000 00E8 D4A5 0FFF，再寫入至 block 中。
            PointWrite = Convert.ToInt32(tmpWritePoint); // Convert.ToInt32(string), 十進制
            tmpWritePoint = Convert.ToString(PointWrite, 16); // Convert.ToString(int32,16), 十進制→十六進制
            tmpWritePoint = tmpWritePoint.PadLeft(24, '0') + "00FF00FF";       // 不足 24個 Bytes，要補零

            // 0200Write---Point---8個Data
            string SNum0200Write = "-1", BNum0200Write = "-1", KType0200Write = "-1"; //參數預設
            SNum0200Write = "02";
            BNum0200Write = "00";
            KType0200Write = "60";
            string tmpWriteData0200Write = tmpWritePoint;
            string LLoadKey0200Write = "FFFFFFFFFFFF";
            string WriteCmd0200Write = "021A16"; //寫入commend 0x02, 0x1A, 0x16,
            string TX0200Write = WriteCmd0200Write + KType0200Write + LLoadKey0200Write + SNum0200Write + BNum0200Write + tmpWriteData0200Write; //組成 Read Data Request
            //Console.WriteLine("TX0200Write :" + TX0200Write);
            UInt32 uiLength0200Write, uiRead0200Write, uiResult0200Write, uiWritten0200Write;
            byte[] ReadBuffer0200Write = new byte[0x40];
            //byte[] WriteBuffer = new byte[] { 0x02, 0x0A, 0x15, 0x60, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x02, 0x01 };
            byte[] WriteBuffer0200Write = StringToByteArray(TX0200Write);
            byte[] sResponse0200Write = null;
            sResponse0200Write = new byte[21];
            EasyPOD.VID = 0xe6a;
            EasyPOD.PID = 0x317;
            Index = 1;
            uiLength0200Write = 64;
            fixed (MW_EasyPOD* pPOD = &EasyPOD)
            {
                dwResult = PODfuncs.ConnectPOD(pPOD, Index);
                if ((dwResult != 0))
                {
                    MessageBox.Show("Not connected yet");
                }
                else
                {
                    EasyPOD.ReadTimeOut = 200;
                    EasyPOD.WriteTimeOut = 200;
                    dwResult = PODfuncs.WriteData(pPOD, WriteBuffer0200Write, 28, &uiWritten0200Write); //Send a request command to reader  ,buffer 讀取12個 command 碼 + 16 byte data，所以讀28個
                    uiResult0200Write = PODfuncs.ReadData(pPOD, ReadBuffer0200Write, uiLength0200Write, &uiRead0200Write); //Read the response data from reader
                    tebReadData.Text = BitConverter.ToString(ReadBuffer0200Write, 4, (Int32)uiRead0200Write - 4).Replace("-", ""); //HEX  從 4 之後開始 寫入 data (Response 欄位 0~4 為 02 12 16 00 ，這四個之後才是data)
                }
                dwResult = PODfuncs.ClearPODBuffer(pPOD);
                dwResult = PODfuncs.DisconnectPOD(pPOD);
            }
            //0200Write END


            //Console.WriteLine("總點數：" + SumPoint.ToString());
            // MessageBox.Show("增加點數完成","儲值完成");
        }

        private void textBox_MemName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label_member2_Click(object sender, EventArgs e)
        {

        }

        private void textBox_MemID2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_MemName2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_SignDay2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox_SignDay2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Point2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_point2_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private string StringToUnicode(string srcText)
        {
            string dst = "";
            char[] src = srcText.ToCharArray();
            for (int i = 0; i < src.Length; i++)
            {
                byte[] bytes = Encoding.Unicode.GetBytes(src[i].ToString());
                string str = @"\u" + bytes[1].ToString("X2") + bytes[0].ToString("X2");
                dst += str;
            }
            return dst;
        }

        private string UnicodeToString(string srcText)
        {
            string dst = "";
            string src = srcText;
            int len = srcText.Length / 6;

            for (int i = 0; i <= len - 1; i++)
            {
                string str = "";
                str = src.Substring(0, 6).Substring(2);
                src = src.Substring(6);
                byte[] bytes = new byte[2];
                bytes[1] = byte.Parse(int.Parse(str.Substring(0, 2), System.Globalization.NumberStyles.HexNumber).ToString());
                bytes[0] = byte.Parse(int.Parse(str.Substring(2, 2), System.Globalization.NumberStyles.HexNumber).ToString());
                dst += Encoding.Unicode.GetString(bytes);
            }
            return dst;
        }
    }
}
