using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FishProduction
{
    public partial class MainFrom : Form
    {
        /*设置状态*/
        public byte OptionState = 0x00;

        /*设置结果*/
        public bool SetOptionResult = false;

        /*写入的ID*/
        public byte[] WriteID = new byte[4];

        /*获取的SIM卡号*/
        public byte[] GetSimID = new byte[10];

        /*   协议   */
        public byte CheckTemp = 0; /*校验字节缓存*/

        /*设置板子id协议*/
        public byte[] SetBoardIdProtocol = new byte[8] { 0x03, 0x00, 0x08, 0xff, 0xff, 0xff, 0xff, 0x0B };

        public byte[] GetSimIdProtocol = new byte[5] { 0x03, 0x02, 0x05, 0xff, 0xfb };

        /*获取主服务器地址*/
        public byte[] GetServeraddressProtocol = new byte[5] { 0x03, 0x04, 0x05, 0xff, 0xfd };

        /*获取主服务器端口*/
        public byte[] GetServerPortProtocol = new byte[5] { 0x03, 0x06, 0x05, 0xff, 0xff };
        /*获取备服务器地址*/
        public byte[] GetSpareServeraddressProtocol = new byte[5] { 0x03, 0x10, 0x05, 0xff, 0xe9 };
        /*获取备服务器端口*/
        public byte[] GetSpareServerPortProtocol = new byte[5] { 0x03, 0x12, 0x05, 0xff, 0xeb };
        /*设置服务器地址  变化*/
        public byte[] SetServerAddress = new byte[100];

        public int SetServerAddressLenght = 0;
        /*设置服务器端口号协议 变化*/
        public byte[] SetServerPortProtocol = new byte[9] { 0x03, 0x05, 0x08, 0x00, 0x00, 0x00, 0x00, 0x00,0xff };

        /*重置Flash协议*/
        public byte[] ResetFlashProtocol = new byte[5] { 0x03, 0x0d, 0x05, 0xff, 0xf4 };

        /*获取板子ID协议*/
        public byte[] GetBoardIDProtocol = new byte[5] { 0x03, 0x01, 0x05, 0xFF, 0xF8 };

        /*重置MCU*/
        public byte[] ResetMcu = new byte[5] { 0x03, 0x0e, 0x05, 0xff, 0xf7 }; 

        /*串口接收数据解析区*/
        public byte[] AnalysisSerailData = new byte[200];

        /*电量补偿*/
        public byte[] PowerCompensate = new byte[5] { 0x03, 0x15, 0x05, 0x01, 0x12 };

        /*读取电量协议*/
        public byte[] ReadPowerProtocol = new byte[5] { 0x03, 0x1e,0x05, 0xff,0xe7 };

        /*设置钥匙一id*/
        public byte[] SetKey1IdProtocol = new byte[8] { 0x03, 0x07,0x08, 0xff, 0xff, 0xff, 0xff, 0xff };

        /*设置钥匙二id*/
        public byte[] SetKey2IdProtocol = new byte[8] { 0x03, 0x09, 0x08, 0xff, 0xff, 0xff, 0xff, 0xff };

        /*设置域名ip选项协议*/

        public byte[] SetDomainSelect = new byte[5] { 0x03, 0x13, 0x05, 0xff, 0xff };
        public byte[] GetVersionNumber= new byte[5] { 0x03, 0x16, 0x05, 0xff, 0xef };
        /*串口字节数*/
        int BufferCount = 0;
        /*串口接收状态 0x00:未接收  0x01:接收中*/


        /*获取加速度传感器状态*/
        public byte[] GetAccelerationState = new byte[5] { 0x03, 0x2a, 0x05, 0xff, 0xd3 };

        public byte SerailRecState = 0x00;
 
        /*串口捕获定义*/
        public const int WM_DEVICE_CHANGE = 0x219;
        public const int DBT_DEVICEARRIVAL = 0x8000;
        public const int DBT_DEVICE_REMOVE_COMPLETE = 0x8004;
        public const UInt32 DBT_DEVTYP_PORT = 0x00000003;

        //串口防锁死变量
        private bool Listening = false;//是否没有执行完invoke相关操作             
        private bool Closeing = false;//是否正在关闭串口，执行Application.DoEvents，并阻止再次invoke  

        public MainFrom()
        {
            InitializeComponent();


        }

        private void Permission_Function_diff(int PermissionValue)
        {
            if(1 == PermissionValue)
            {

            }
            else
            {
                /*禁止高级功能*/
                tabPage2.Parent = null;
                tabPage3.Parent = null;

            }
        }
        private void MainFrom_Load(object sender, EventArgs e)
        {
            //LogHelper.WriteLog(typeof(MainFrom), "加载主窗体");

            ///*扫描串口*/
            //LogHelper.WriteLog(typeof(MainFrom), "开始扫码存在的串口");

            SearchAndAddSerialToComboBox(serialPort1, serialPortBox);

            //LogHelper.WriteLog(typeof(MainFrom), "结束扫码存在的串口");

            /*域名 ip选项控件*/
            ipSelectBox.Items.Add("域名");
            ipSelectBox.Items.Add("IP");
            ipSelectBox.SelectedIndex = 0;


            Permission_Function_diff(LoginForm.Jurisdiction);

            /*串口接收事件*/
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
            //LogHelper.WriteLog(typeof(MainFrom), "主窗体加载结束");

              


        }
        /// <summary>
        /// 串口刷新遍历
        /// </summary>
        /// <param name="MyPort"></param>
        /// <param name="MyBox"></param>
        private void SearchAndAddSerialToComboBox(SerialPort MyPort, ComboBox MyBox)
        {
 
            string Buffer;
            MyBox.Items.Clear();
            for (int i = 1; i < 20; i++)
            {
                try                                                   
                {
                    Buffer = "COM" + i.ToString();
                    MyPort.PortName = Buffer;
                   
                    MyPort.Open();                                      
                   
                    MyBox.Items.Add(Buffer);                            
                    MyPort.Close();

                    Application.DoEvents();
                }
                catch 
                {
                    
                }
  

            }
            serialPortBox.SelectedIndex = MyBox.Items.Count > 0 ? 0 : -1;

        }
        private void scanPort_Click(object sender, EventArgs e)
        {
            SearchAndAddSerialToComboBox(serialPort1, serialPortBox);
        }
        private void openSerialPort_Click(object sender, EventArgs e)
        {
            //try
            //{       
                if (serialPort1.IsOpen)
                {
                    Closeing = true;
                    while (Listening)
                    {
                        Application.DoEvents();
                    }
                    serialPort1.Close();
                    Closeing = false ;
                    scanPort.Enabled = true;
                    openSerialPort.Text = "打开串口";
                }
                else
                {
                    serialPort1.PortName = serialPortBox.Text;
                    serialPort1.BaudRate = int.Parse(BaudComBox.Text);
                    serialPort1.WriteTimeout = 500; 
                    serialPort1.ReadTimeout = 500; 
                    scanPort.Enabled = false;
                    serialPort1.Close();
                    try
                    {
                        serialPort1.Open();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                    
                    openSerialPort.Text = "关闭串口";
                   
                }
               
            //}
            //catch (Exception ex)
            //{
            //    LogHelper.WriteLog(typeof(MainFrom), ex);
            //    MessageBox.Show("端口错误,请检查串口", "错误");
            //}
 
        }
        /// <summary>
        /// 字符串转16进制字节数组
        /// </summary>
        /// <param name="Str"></param>
        private static byte[] StrToHexByte(string Str)
        {
 
            byte[] returnBytes = new byte[Str.Length / 2];
            for (int i = 0; i < returnBytes.Length; i++)
                returnBytes[i] = Convert.ToByte(Str.Substring(i * 2, 2), 16);
            return returnBytes;

        }
        /// <summary>
        /// 字节转字符串
        ///  // 0xae00cf => "AE00CF "
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static string ByteToHexString(byte[] bytes)
        {
            string hexString = string.Empty;

            if (bytes != null)
            {
                StringBuilder strB = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    strB.Append(bytes[i].ToString("X2"));
                }
                hexString = strB.ToString();
            }
            return hexString;

        }
        /*串口数据接收事件*/
        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(100);

            //如果正在关闭，忽略操作，直接返回，尽快的完成串口监听线程的一次循环 
            if (Closeing)
            {
                return;
            }

            try
            {
                Listening = true;//设置标记，说明我已经开始处理数据，一会儿要使用系统UI的。  

                BufferCount = serialPort1.BytesToRead;

                byte[] ReciveDataBuffer = new byte[BufferCount];

                if (BufferCount > 3)//要大于3个字节
                {
                    if (BufferCount < AnalysisSerailData.Length)
                    {
                        Thread DataAnalysis = new Thread(new ThreadStart(DataAnalysisThread));

                        serialPort1.Read(ReciveDataBuffer, 0, BufferCount);

                        Array.Copy(ReciveDataBuffer, AnalysisSerailData, BufferCount);

                        /*赋值完成清空*/
                        Array.Clear(ReciveDataBuffer, 0, ReciveDataBuffer.Length);

                        DataAnalysis.Start();

                        DataAnalysis.Join();

                    }
                    else
                    {
                        MessageBox.Show("数据接收出错", "提示");
                    }
                }
                BufferCount = 1;
                /*赋值完成清空*/
                Array.Clear(ReciveDataBuffer, 0, ReciveDataBuffer.Length);
            }
            finally
            {
                Listening = false;//用完了，ui可以关闭串口了。  
            }   

        }
        public byte Crc8(byte[] CheckData)
        {
            byte CrcValue = 0;
            if(null == CheckData)
            {
                throw new ArgumentNullException("CheckData为空");
            }
            if(CheckData.Length < 3)
            {
                throw new ArgumentNullException("CheckData长度小于3！");
            }
            for (int i = 0; i < CheckData[2] - 1; i++)
            {
                CrcValue ^= CheckData[i];
            }
            return CrcValue;
        }
        /*接收数据分析*/
        public void DataAnalysisThread()
        {
            if(AnalysisSerailData[0] == 0x03)
            {
                this.Invoke((EventHandler)delegate
                {
                    #region 1.设置控制器ID应答命令
                    if ( 0x00 == AnalysisSerailData[1]) //设置控制器ID应答命令
                    {
                        if (AnalysisSerailData[AnalysisSerailData[2] - 1] == Crc8(AnalysisSerailData))
                        {
                            if (0x05 == AnalysisSerailData[2])//数据长度验证
                            {

                                if (0x00 == AnalysisSerailData[3])
                                {
                                    logTextBox.AppendText("ID设置成功\r\n");

                                    SetOptionResult = true;

                                    serialPort1.Write(GetBoardIDProtocol, 0, 5);

                                }
                                else if (0x01 == AnalysisSerailData[3])
                                {
                                    logTextBox.AppendText("ID设置失败\r\n");
                                }
                            }

                        }
                        else
                        {
                            logTextBox.AppendText("ID设置Crc校验失败\r\n");
                        }
                           
 
                    }
                    #endregion

                    #region  2.获取控制器ID应答命令
                    if ( 0x01 == AnalysisSerailData[1]) //获取控制器ID应答命令
                    {
                        /*CRC8校验*/
                        if (AnalysisSerailData[AnalysisSerailData[2] - 1] == Crc8(AnalysisSerailData))
                        {
                            if (0x00 == AnalysisSerailData[3])//获取成功
                            {

                                if (0x09 == AnalysisSerailData[2])//数据长度验证
                                {
                                    byte[] Temp = new byte[4];

                                    Temp[0] = AnalysisSerailData[7];
                                    Temp[1] = AnalysisSerailData[6];
                                    Temp[2] = AnalysisSerailData[5];
                                    Temp[3] = AnalysisSerailData[4];

                                    string Temp_Temp = Convert.ToString(BitConverter.ToInt32(Temp, 0), 16);

                                    Temp_Temp = Temp_Temp.PadLeft(8, '0');

                                    logTextBox.AppendText("控制器的ID为: " + Temp_Temp + "\r\n");
 

                                }
                            }
                            else
                            {
                                logTextBox.AppendText("控制器ID获取失败 ！" + "\r\n");
                            }

                        }
                        else
                        {
                            logTextBox.AppendText("控制器ID获取校验失败 ！" + "\r\n");
                        }



                    }
                    #endregion

                    #region 3.获取SIM卡号应答
                    if (0x02 == AnalysisSerailData[1] )
                    {
                        if (AnalysisSerailData[AnalysisSerailData[2] - 1] == Crc8(AnalysisSerailData))
                        {
                            if (0x00 == AnalysisSerailData[3])
                            {
                                if (0x0f == AnalysisSerailData[2])
                                {
                                    for (int i = 0; i < 10; i++)
                                    {
                                        GetSimID[i] = AnalysisSerailData[i + 4];
                                    }

                                    ByteToHexString(GetSimID);

                                    logTextBox.AppendText("当前Sim卡号为:" + ByteToHexString(GetSimID) + "\r\n");

                                }
                            }
                            else
                            {
                                logTextBox.AppendText("Sim卡号获取失败\r\n");
                            }
                        }
                        else
                        {
                            logTextBox.AppendText("Sim卡号获取校验失败\r\n");
                        }                   
                    }
                    #endregion

                    #region 4.设置服务器应答

                    if (0x03 == AnalysisSerailData[1])
                    {
                        if (AnalysisSerailData[AnalysisSerailData[2] - 1] == Crc8(AnalysisSerailData))
                        {

                            /*设置成功*/
                            if (0x00 == AnalysisSerailData[3])
                            {

                                if (0x05 == AnalysisSerailData[2])//数据长度验证
                                {

                                    logTextBox.AppendText("服务器地址设置成功！\r\n");
                                    SetOptionResult = true;
                                }

                            }
                            else
                            {
                                logTextBox.AppendText("服务器地址设置失败！\r\n");
                            }

                        }
                        else
                        {
                            logTextBox.AppendText("服务器地址设置校验失败！\r\n");
                        }

                    }

                    #endregion

                    #region 5.获取服务器地址应答

                    if ( 0x04 == AnalysisSerailData[1])
                    {

                        if (AnalysisSerailData[AnalysisSerailData[2]-1]== Crc8(AnalysisSerailData))
                        {
                            /*获取成功*/
                            if (0x00 == AnalysisSerailData[3])
                            {

                                byte[] GetServerAddressValue = new byte[BufferCount - 5];

                                for (int i = 0; i < GetServerAddressValue.Length; i++)
                                {
                                    GetServerAddressValue[i] = AnalysisSerailData[4 + i];
                                }
                                logTextBox.AppendText("服务器地址为:" + System.Text.Encoding.Default.GetString(GetServerAddressValue) + "\r\n");
                            }
                            else
                            {
                                logTextBox.AppendText("服务器地址获取失败！" + "\r\n");
                            }
                        }
                        else
                        {
                            logTextBox.AppendText("服务器地址获取校验失败！" + "\r\n");
                        }


                    }

                    #endregion 

                    #region 6.设置端口应答
                    if (0x05 ==   AnalysisSerailData[1])
                    {
                        if (AnalysisSerailData[AnalysisSerailData[2] - 1] == Crc8(AnalysisSerailData))
                        {
                            /*设置成功*/
                            if (0x00 == AnalysisSerailData[3])
                            {
                                /*数据长度验证*/
                                if (0x05 == AnalysisSerailData[2])
                                {
                                    SetOptionResult = true;
                                    logTextBox.AppendText("服务器端口设置成功！\r\n");
                                }
                            }
                            else
                            {
                                logTextBox.AppendText("服务器端口设置失败！\r\n");
                            }

                        }
                        else
                        {
                            logTextBox.AppendText("服务器端口设置校验失败！\r\n");
                        }
                    }

                    #endregion

                    #region 7.获取服务器端口应答

                    if (0x06 == AnalysisSerailData[1])
                    {
                        if (AnalysisSerailData[AnalysisSerailData[2] - 1] == Crc8(AnalysisSerailData))
                        {
                            if (0x00 == AnalysisSerailData[3]) //获取成功
                            {
                                if (0x0a == AnalysisSerailData[2])//数据长度验证
                                {
                                    byte[] Port = new byte[5];
                                    for (int i = 0; i < 5; i++)
                                    {
                                        Port[i] = AnalysisSerailData[4 + i];
                                    }

                                    logTextBox.AppendText("端口号为：" + System.Text.Encoding.Default.GetString(Port) + "\r\n");
                                }

                            }
                            else
                            {
                                logTextBox.AppendText("端口获取失败！\r\n");
                            }
                        }
                        else
                        {
                            logTextBox.AppendText("端口获取校验失败！\r\n");
                        }
                    }

                    #endregion

                    #region 8.设置钥匙ID一应答
                    if (0x07 == AnalysisSerailData[1])
                    {
                        if (AnalysisSerailData[AnalysisSerailData[2] - 1] == Crc8(AnalysisSerailData))
                        {
                            /*设置成功*/
                            if (0x00 == AnalysisSerailData[3])
                            {
                                /*数据长度验证*/
                                if (0x05 == AnalysisSerailData[2])
                                {

                                    logTextBox.AppendText("钥匙一ID设置成功！\r\n");
                                }
                            }
                            else
                            {
                                logTextBox.AppendText("钥匙一ID设置失败！\r\n");
                            }
                        }
                        else
                        {
                            logTextBox.AppendText("钥匙一ID设置校验失败！\r\n");
                        }
                            

                    }

                    #endregion

                    #region 9.获取钥匙一ID应答
                    if ( 0x08 == AnalysisSerailData[1])
                    {
                        if (AnalysisSerailData[AnalysisSerailData[2] - 1] == Crc8(AnalysisSerailData))
                        {
                            if (0x00 == AnalysisSerailData[3]) //获取成功
                            {
                                if (0x09 == AnalysisSerailData[2])//数据长度验证
                                {
                                    byte[] KeyID = new byte[4];
                                    for (int i = 0; i < 4; i++)
                                    {
                                        KeyID[i] = AnalysisSerailData[4 + i];
                                    }
                                     
                                    logTextBox.AppendText("钥匙一ID为：" + ByteToHexString(KeyID) + "\r\n");
                                }

                            }
                            else
                            {
                                logTextBox.AppendText("钥匙一ID获取失败！\r\n");
                            }

                        }
                        else
                        {
                            logTextBox.AppendText("钥匙一ID获取校验失败！\r\n");
                        }
                       

                    }



                    #endregion

                    #region 10.设置钥匙二ID应答
                    if (0x09 == AnalysisSerailData[1])
                    {

                        if (AnalysisSerailData[AnalysisSerailData[2] - 1] == Crc8(AnalysisSerailData))
                        {
                            /*设置成功*/
                            if (0x00 == AnalysisSerailData[3])
                            {
                                /*数据长度验证*/
                                if (0x05 == AnalysisSerailData[2])
                                {

                                    logTextBox.AppendText("钥匙二ID设置成功！\r\n");
                                }
                            }
                            else
                            {
                                logTextBox.AppendText("钥匙二ID设置失败！\r\n");
                            }

                        }
                        else
                        {
                            logTextBox.AppendText("钥匙二ID设置校验失败！\r\n");

                        }
                       

                    }


                    #endregion

                    #region 11.获取钥匙二ID应答
                    if (0x0a == AnalysisSerailData[1])
                    {

                        if (AnalysisSerailData[AnalysisSerailData[2] - 1] == Crc8(AnalysisSerailData))
                        {
                            if (0x00 == AnalysisSerailData[3]) //获取成功
                            {
                                if (0x09 == AnalysisSerailData[2])//数据长度验证
                                {
                                    byte[] KeyID = new byte[4];
                                    for (int i = 0; i < 4; i++)
                                    {
                                        KeyID[i] = AnalysisSerailData[4 + i];
                                    }

                                    logTextBox.AppendText("钥匙二ID为：" + ByteToHexString(KeyID) + "\r\n");
                                }

                            }
                            else
                            {
                                logTextBox.AppendText("钥匙二ID获取失败！\r\n");
                            }

                        }
                        else
                        {
                            logTextBox.AppendText("钥匙二ID获取校验失败！\r\n");
                        }
                       

                    }


                    #endregion

                    #region 12.设置服务器域名IP选项应答
                    if (0x0b == AnalysisSerailData[1])
                    {

                        if (AnalysisSerailData[AnalysisSerailData[2] - 1] == Crc8(AnalysisSerailData))
                        {
                            /*设置成功*/
                            if (0x00 == AnalysisSerailData[3])
                            {
                                /*数据长度验证*/
                                if (0x05 == AnalysisSerailData[2])
                                {

                                    logTextBox.AppendText("服务器域名IP设置成功！\r\n");
                                }
                            }
                            else
                            {
                                logTextBox.AppendText("服务器域名IP设置失败！\r\n");
                            }

                        }
                        else
                        {
                            logTextBox.AppendText("服务器域名IP设置校验失败！\r\n");
                        }
                      

                    }



                    #endregion

                    #region 13.获取服务器域名IP选项
                    if (0x0c ==  AnalysisSerailData[1])
                    {

                        if (AnalysisSerailData[AnalysisSerailData[2] - 1] == Crc8(AnalysisSerailData))
                        {
                            /*获取成功*/
                            if (0x00 == AnalysisSerailData[3])
                            {
                                /*数据长度验证*/
                                if (0x06 == AnalysisSerailData[2])
                                {
                                    if (0x55 == AnalysisSerailData[4])
                                    {
                                        logTextBox.AppendText("服务器为域名选项！\r\n");
                                    }
                                    else if (0xaa == AnalysisSerailData[4])
                                    {
                                        logTextBox.AppendText("服务器为IP选项！\r\n");
                                    }


                                }
                            }
                            else
                            {
                                logTextBox.AppendText("服务器域名IP获取失败！\r\n");
                            }

                        }
                        else
                        {
                            logTextBox.AppendText("服务器域名IP获取校验失败！\r\n");
                        }
                       

                    }

                    #endregion

                    #region 14.重置Flash参数为默认值
                    if (0x0d == AnalysisSerailData[1])
                    {

                        if (AnalysisSerailData[AnalysisSerailData[2] - 1] == Crc8(AnalysisSerailData))
                        {
                            if (0x00 == AnalysisSerailData[3]) //重置成功
                            {
                                if (0x05 == AnalysisSerailData[2])//数据长度验证
                                {
                                    logTextBox.AppendText("Flash重置成功！" + "\r\n");

                                    SetOptionResult = true;
                                }

                            }
                            else
                            {
                                logTextBox.AppendText("Flash重置失败！\r\n");
                            }

                        }
                        else
                        {
                            logTextBox.AppendText("Flash重置校验失败！\r\n");
                        }
                        

                    }
                    #endregion

                    #region 15.重启MCU
                    if (0x0e == AnalysisSerailData[1])
                    {
                        byte a = AnalysisSerailData[AnalysisSerailData[2] - 1];
                        byte b = Crc8(AnalysisSerailData);

                        if (AnalysisSerailData[AnalysisSerailData[2] - 1] == Crc8(AnalysisSerailData))
                        {
                            if (0x00 == AnalysisSerailData[3]) //重启成功
                            {
                                if (0x05 == AnalysisSerailData[2])//数据长度验证
                                {

                                    logTextBox.AppendText("MCU重启成功！" + "\r\n");

                                    SetOptionResult = true;
                                }

                            }
                            else
                            {
                                logTextBox.AppendText("MCU重启失败！\r\n");
                            }

                        }
                        else
                        {
                            logTextBox.AppendText("MCU重启校验失败！\r\n");
                        }
                        
                    }
                    #endregion

                    #region 16.设置备用服务器地址
                    if (0x0f == AnalysisSerailData[1])
                    {

                        if (AnalysisSerailData[AnalysisSerailData[2] - 1] == Crc8(AnalysisSerailData))
                        {
                            if (0x00 == AnalysisSerailData[3])
                            {
                                if (0x05 == AnalysisSerailData[2])
                                {

                                    logTextBox.AppendText("备用服务器设置成功！" + "\r\n");

                                    SetOptionResult = true;
                                }

                            }
                            else
                            {
                                logTextBox.AppendText("备用服务器设置失败！\r\n");
                            }

                        }
                        else
                        {
                            logTextBox.AppendText("备用服务器设置校验失败！\r\n");
                        }
                       

                    }

                    #endregion

                    #region 17.获取备用服务器地址
                    if (0x10 == AnalysisSerailData[1])
                    {

                        if (AnalysisSerailData[AnalysisSerailData[2] - 1] == Crc8(AnalysisSerailData))
                        {

                            /*获取成功*/
                            if (0x00 == AnalysisSerailData[3])
                            {

                                byte[] GetServerAddressValue = new byte[BufferCount - 5];

                                for (int i = 0; i < GetServerAddressValue.Length; i++)
                                {
                                    GetServerAddressValue[i] = AnalysisSerailData[4 + i];
                                }

                                logTextBox.AppendText("备用服务器地址为:" + System.Text.Encoding.Default.GetString(GetServerAddressValue) + "\r\n");

                            }
                            else
                            {
                                logTextBox.AppendText("备用服务器地址获取失败！" + "\r\n");
                            }

                        }
                        else
                        {
                            logTextBox.AppendText("备用服务器地址获取校验失败！" + "\r\n");
                        }
                        
                       

                    }

                    #endregion

                    #region 18.设置备用服务器端口
                    if (0x11 == AnalysisSerailData[1])
                    {

                        if (AnalysisSerailData[AnalysisSerailData[2] - 1] == Crc8(AnalysisSerailData))
                        {
                            if (0x00 == AnalysisSerailData[3])
                            {
                                if (0x05 == AnalysisSerailData[2])
                                {

                                    logTextBox.AppendText("设置备用服务器端口成功！" + "\r\n");

                                    SetOptionResult = true;
                                }

                            }
                            else
                            {
                                logTextBox.AppendText("设置备用服务器失败！\r\n");
                            }

                        }
                        else
                        {
                            logTextBox.AppendText("设置备用服务器校验失败！\r\n");

                        }
                        
                    }

                    #endregion

                    #region 19.获取备用服务器端口应答

                    if (AnalysisSerailData[1] == 0x12)
                    {

                        if (AnalysisSerailData[AnalysisSerailData[2] - 1] == Crc8(AnalysisSerailData))
                        {

                            if (AnalysisSerailData[3] == 0x00)
                            {
                                if (AnalysisSerailData[2] == 0x0a)
                                {
                                    byte[] Port = new byte[5];
                                    for (int i = 0; i < 5; i++)
                                    {
                                        Port[i] = AnalysisSerailData[4 + i];
                                    }

                                    logTextBox.AppendText("备用服务器端口号为：" + System.Text.Encoding.Default.GetString(Port) + "\r\n");
                                }

                            }
                            else
                            {
                                logTextBox.AppendText("备用服务器端口获取失败！\r\n");
                            }
                        }
                        else
                        {
                            logTextBox.AppendText("备用服务器端口获取校验失败！\r\n");
                        }
                       

                    }

                    #endregion

                    #region 20.设置备用服务器域名IP选项应答
                    if (0x13 == AnalysisSerailData[1])
                    {

                        if (AnalysisSerailData[AnalysisSerailData[2] - 1] == Crc8(AnalysisSerailData))
                        {
                            /*设置成功*/
                            if (0x00 == AnalysisSerailData[3])
                            {
                                /*数据长度验证*/
                                if (0x05 == AnalysisSerailData[2])
                                {

                                    logTextBox.AppendText("服务器域名IP设置成功！\r\n");
                                }
                            }
                            else
                            {
                                logTextBox.AppendText("服务器域名IP设置失败！\r\n");
                            }

                        }
                        else
                        {
                            logTextBox.AppendText("服务器域名IP设置校验失败！\r\n");
                        }
                       

                    }
                    #endregion

                    #region 21.获取备用服务器域名IP选项

                    if (0x14 == AnalysisSerailData[1])
                    {

                        if (AnalysisSerailData[AnalysisSerailData[2] - 1] == Crc8(AnalysisSerailData))
                        {
                            /*获取成功*/
                            if (0x00 == AnalysisSerailData[3])
                            {
                                /*数据长度验证*/
                                if (0x06 == AnalysisSerailData[2])
                                {
                                    if (0x55 == AnalysisSerailData[4])
                                    {
                                        logTextBox.AppendText("备用服务器为域名选项！\r\n");
                                    }
                                    else if (0xaa == AnalysisSerailData[4])
                                    {
                                        logTextBox.AppendText("备用服务器为IP选项！\r\n");
                                    }
                                }
                            }
                            else
                            {
                                logTextBox.AppendText("服务器域名IP获取失败！\r\n");
                            }

                        }
                        else
                        {
                            logTextBox.AppendText("服务器域名IP获取校验失败！\r\n");
                        }

                    }
                    #endregion

                    #region 22.电瓶电量补偿
                    if (AnalysisSerailData[1] == 0x15)
                    {

                        if (AnalysisSerailData[AnalysisSerailData[2] - 1] == Crc8(AnalysisSerailData))
                        {
                            if (AnalysisSerailData[3] == 0x00) //重启成功
                            {
                                if (AnalysisSerailData[2] == 0x05)//数据长度验证
                                {
                                    logTextBox.AppendText("电量补偿成功！" + "\r\n");
                                }

                            }
                            else if (AnalysisSerailData[3] == 0x01)
                            {
                                logTextBox.AppendText("参数错误！\r\n");
                            }
                            else if (AnalysisSerailData[3] == 0x02)
                            {
                                logTextBox.AppendText("未接入电瓶电压！\r\n");
                            }
                            else if (AnalysisSerailData[3] == 0x03)
                            {
                                logTextBox.AppendText("补偿值超出有效范围！\r\n");
                            }

                        }
                        else
                        {
                            logTextBox.AppendText("补偿值校验失败！\r\n");

                        }
                       

                    }
                    #endregion

                    #region 23.获取软硬件版本信息

                    if (AnalysisSerailData[1] == 0x16)
                    {

                        if (AnalysisSerailData[AnalysisSerailData[2] - 1] == Crc8(AnalysisSerailData))
                        {
                            if (AnalysisSerailData[3] == 0x00) //获取成功
                            {


                                logTextBox.AppendText("软件版本号是:V" + AnalysisSerailData[4] + "." + AnalysisSerailData[5] + "." + AnalysisSerailData[6] + "\r\n");
                                logTextBox.AppendText("硬件版本号是:V" + AnalysisSerailData[7] + "." + AnalysisSerailData[8] + "." + AnalysisSerailData[9] + "\r\n");

                            }
                            else
                            {
                                logTextBox.AppendText("版本号获取失败！" + "\r\n");
                            }

                        }
                        else
                        {
                            logTextBox.AppendText("版本号获取校验失败！" + "\r\n");
                        }                   

                    }

                    #endregion


                    #region 24.验证加速度传感器


                    if (AnalysisSerailData[1] == 0x2a)
                    {

                        if (AnalysisSerailData[AnalysisSerailData[2] - 1] == Crc8(AnalysisSerailData))
                        {
                            if (AnalysisSerailData[3] == 0x00) //获取成功
                            {

                                logTextBox.AppendText("加速度传感器正常！" + "\r\n");

                                SetOptionResult = true;
                            }
                            else
                            {
                                logTextBox.AppendText("警告：加速度传感器异常！！" + "\r\n");
                               
                            }

                        }
                        else
                        {
                            logTextBox.AppendText("加速度传感器信息获取失败！" + "\r\n");
                            
                        }

                    }

                    #endregion
 

                    #region 31.读取电瓶电量

                    if (AnalysisSerailData[1] == 0x1e)
                    {

                        if (AnalysisSerailData[AnalysisSerailData[2] - 1] == Crc8(AnalysisSerailData))
                        {

                            if (AnalysisSerailData[3] == 0x00) //获取成功
                            {
                                logTextBox.AppendText("电量百分比为：" + AnalysisSerailData[4].ToString() + "%" + "\r\n");
                            }
                            else
                            {
                                logTextBox.AppendText("电量获取失败！" + "\r\n");

                            }
                        }
                        else
                        {
                            logTextBox.AppendText("电量数据校验失败！" + "\r\n");
                        }

                    }


                    #endregion

                     

                });

            }
            /*解析完成清空*/
            Array.Clear(AnalysisSerailData, 0, AnalysisSerailData.Length);
            BufferCount = 1;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            this.Invoke((EventHandler)delegate
            {
                if (0x01 == OptionState)
                {
                    SetOptionResult = false;
                    serialPort1.Write(ResetFlashProtocol, 0, 5);
                    OptionState = 0x02;
                }
                else if (0x02 == OptionState)
                {
                    if (SetOptionResult)
                    {

                        SetOptionResult = false;

                        serialPort1.Write(SetBoardIdProtocol, 0, 8);

                        OptionState = 0x03;


                    }
                    else
                    {
                        logTextBox.AppendText("Flash重置失败！\r\n");
                        timer1.Enabled = false;
                        writeButtonID.Enabled = true;
                        powerCompensation.Enabled = true;

                    }

                }
                else if (0x03 == OptionState)
                {
                    if (SetOptionResult)
                    {
                        SetOptionResult = false;

                        serialPort1.Write(GetAccelerationState, 0, 5);

                        OptionState = 0x04;
                    }
                }



                else if (0x04 == OptionState)
                {
                    if (SetOptionResult)
                    {
                        SetOptionResult = false;

                        serialPort1.Write(ResetMcu, 0, 5);

                        OptionState = 0x05;

                    }
                    else
                    {
                        logTextBox.AppendText("板子ID设置失败！\r\n");
                        timer1.Enabled = false;
                        writeButtonID.Enabled = true;
                        powerCompensation.Enabled = true;
                    }
                }
                else if (0x05 == OptionState)
                {
                    if (SetOptionResult)
                    {
                        /*板子Id加一*/
                        IdtextBox.Text = (Convert.ToInt64(IdtextBox.Text, 16) + 0x01).ToString("X2");

                        int IDlenth = IdtextBox.Text.Length;

                        if (IDlenth < 8)
                        {
                            for (int i = 0; i < 8 - IDlenth; i++)
                            {
                                IdtextBox.Text = "0" + IdtextBox.Text;

                            }
                        }
                    }
                    else
                    {
                        logTextBox.AppendText("重启Mcu失败！\r\n");

                    }

                    timer1.Enabled = false;
                    writeButtonID.Enabled = true;
                    powerCompensation.Enabled = true;
                    OptionState = 0x00;

                }
                else if (0x06 == OptionState)
                {
                    SetOptionResult = false;
                    serialPort1.Write(SetServerAddress, 0, SetServerAddressLenght + 4);
                    OptionState = 0x07;

                }
                else if (0x07 == OptionState)
                {
                    if (SetOptionResult)
                    {
                        SetOptionResult = false;
                        serialPort1.Write(SetServerPortProtocol, 0, 8);
                       
                    }
                    else
                    {
                        setMainServerAddress.Enabled = true;
                        timer1.Enabled = false;
                        OptionState = 0x00;
                        logTextBox.AppendText("写入服务器地址失败！\r\n");
                    }
                    setMainServerAddress.Enabled = true;
                    timer1.Enabled = false;
                    OptionState = 0x00;
                }
 

            });


        }
        private void writeButtonID_Click(object sender, EventArgs e)
        {
            if (8 == IdtextBox.Text.Length)
            {
                if(serialPort1.IsOpen)
                {
                    WriteID = StrToHexByte(IdtextBox.Text);

                    for (int i = 0; i < 4; i++)
                    {
                        SetBoardIdProtocol[i + 3] = WriteID[i];

                    }
                    CheckTemp = 0;

                    for (int i = 0; i < SetBoardIdProtocol.Length - 1; i++)
                    {
                        CheckTemp ^= SetBoardIdProtocol[i];
                    }
                    SetBoardIdProtocol[SetBoardIdProtocol.Length - 1] = CheckTemp;
                 
                    OptionState = 0x01;

                    writeButtonID.Enabled = false;
                    powerCompensation.Enabled = false;
                    timer1.Enabled = true;


                }
            }
            else
            {
                MessageBox.Show("请检查输入长度", "提示");
            }
        }
        private void clearLogButton_Click(object sender, EventArgs e)
        {
            logTextBox.Text = "";
        }
        private void readIDButton_Click(object sender, EventArgs e)
        {
            //LogHelper.WriteLog(typeof(MainFrom), "测试是否能写入日志");
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write(GetBoardIDProtocol, 0, 5);
                     
                }
                else
                {
                    MessageBox.Show("串口未打开！", "提示");
                }

            }
            catch (Exception ex)
            {
                LogHelper.WriteLog(typeof(MainFrom), ex);
            }
           
        }
        private void SetSerAddress(string ServerAddrText,string type)
        {
            string ServerAddress = ServerAddrText.Replace(" ","");
            byte[] TempAddress = System.Text.Encoding.ASCII.GetBytes(ServerAddress);
            byte i = 0;
            if ("主服务器"==type)
            {
                SetServerAddressLenght = TempAddress.Length;
                SetServerAddress[0] = 0x03;
                SetServerAddress[1] = 0x03;

                for (i = 0; i < TempAddress.Length; i++)
                {
                    SetServerAddress[i + 3] = TempAddress[i];
                }
                i++;//包头，命令，长度和检验2个字节
                i++;
                i++;
                i++;
                SetServerAddress[2] = i;

                CheckTemp = 0;

                for (i = 0; i < SetServerAddress[2] - 1; i++)
                {
                    CheckTemp ^= SetServerAddress[i];
                }

                SetServerAddress[SetServerAddress[2] - 1] = CheckTemp;


                StringBuilder strB = new StringBuilder();

                for (int j = 0; j < SetServerAddress.Length; j++)

                {

                    strB.Append(SetServerAddress[j].ToString("X2"));

                }

            }
            else if(type == "备用服务器")
            {
                SetServerAddressLenght = TempAddress.Length;
                SetServerAddress[0] = 0x03;
                SetServerAddress[1] = 0x0f;

                for (i = 0; i < TempAddress.Length; i++)
                {
                    SetServerAddress[i + 3] = TempAddress[i];
                }
                i++;//包头，命令，长度和检验2个字节
                i++;
                i++;
                i++;
                SetServerAddress[2] = i;

                CheckTemp = 0;

                for (i = 0; i < SetServerAddress[2] - 1; i++)
                {
                    CheckTemp ^= SetServerAddress[i];
                }

                SetServerAddress[SetServerAddress[2] - 1] = CheckTemp;


                StringBuilder strB = new StringBuilder();

                for (int j = 0; j < SetServerAddress.Length; j++)

                {

                    strB.Append(SetServerAddress[j].ToString("X2"));

                }
            }
            
                                 
            setMainServerAddress.Enabled = false;
            timer1.Enabled = true;
            OptionState = 0x06;

            //serialPort1.Write(SetServerAddress, 0, Count + 4);
  
        }
        private void SetServerPort(string PortNumString,string type)
        {
            string ServerPort = PortNumString;
            byte[] TempPort = System.Text.Encoding.ASCII.GetBytes(ServerPort);

            if(type == "主服务器")
            {
               
                SetServerPortProtocol[0] = 0x03;
                SetServerPortProtocol[1] = 0x05;
                SetServerPortProtocol[2] = 0x09;
               // SetServerPortProtocol[3] = 0x30;
                for (int i = 0; i < 5; i++)
                {
                    SetServerPortProtocol[i + 3] = TempPort[i];
                }
                CheckTemp = 0;
                for (int i = 0; i < SetServerPortProtocol.Length - 1; i++)
                {
                    CheckTemp ^= SetServerPortProtocol[i];
                }

                SetServerPortProtocol[SetServerPortProtocol[2] - 1] = CheckTemp;


            }
            else if(type == "备用服务器")
            {
                SetServerPortProtocol[0] = 0x03;
                SetServerPortProtocol[1] = 0x11;
                SetServerPortProtocol[2] = 0x09;
               // SetServerPortProtocol[3] = 0x30;
                for (int i = 0; i < 5; i++)
                {
                    SetServerPortProtocol[i + 3] = TempPort[i];
                }
                CheckTemp = 0;
                for (int i = 0; i < SetServerPortProtocol.Length - 1; i++)
                {
                    CheckTemp ^= SetServerPortProtocol[i];
                }

                SetServerPortProtocol[SetServerPortProtocol[2] - 1] = CheckTemp;

            }

            serialPort1.Write(SetServerPortProtocol, 0, 9);



        }
        private void setMainServerAddress_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    SetSerAddress(mainServerAddrBox.Text,"主服务器");
                   
                }
                else
                {
                    MessageBox.Show("串口未打开！", "提示");
                }

            }
            catch(Exception ex)
            {
                LogHelper.WriteLog(typeof(MainFrom), ex);
            }
        }
        private void setSpareAddreButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    SetSerAddress(spareServerAddreBox.Text,"备用服务器");
                   
                }
                else
                {
                    MessageBox.Show("串口未打开！", "提示");
                }

            }
            catch(Exception ex)
            {
                LogHelper.WriteLog(typeof(MainFrom), ex);
            }
        }
        private void powerCompensation_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {

                    serialPort1.Write(PowerCompensate, 0, 5);
                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog(typeof(MainFrom), ex);
                
            }
               
        }
        private void readMainServAddr_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write(GetServeraddressProtocol, 0, 5);
                }
                else
                {
                    MessageBox.Show("串口未打开！", "提示");
                }

            }
            catch (Exception ex)
            {
                LogHelper.WriteLog(typeof(MainFrom), ex);

            }
        }
        private void readMainPort_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write(GetServerPortProtocol, 0, 5);
                }
                else
                {
                    MessageBox.Show("串口未打开！", "提示");
                }

            }
            catch (Exception ex)
            {
                LogHelper.WriteLog(typeof(MainFrom), ex);
            }
        }
        private void getSparePortBut_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write(GetSpareServerPortProtocol, 0, 5);
                }
                else
                {
                    MessageBox.Show("串口未打开！", "提示");
                }

            }
            catch (Exception ex)
            {
                LogHelper.WriteLog(typeof(MainFrom), ex);
            }
        }
        private void readSpareServerBut_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write(GetSpareServeraddressProtocol, 0, 5);
                }
                else
                {
                    MessageBox.Show("串口未打开！", "提示");
                }

            }
            catch(Exception ex)
            {
                LogHelper.WriteLog(typeof(MainFrom), ex);
            }
        }
        private void setKey1IdBut_Click(object sender, EventArgs e)
        {
            if(8 == keyId1Box.TextLength)
            {
                if (serialPort1.IsOpen)
                {
                    byte[] WriteKeyIdbuff = new byte[4];
                    WriteKeyIdbuff  = StrToHexByte(keyId1Box.Text);

                    for (int i = 0; i < 4; i++)
                    {
                        SetKey1IdProtocol[i + 3] = WriteKeyIdbuff[i];

                    }

                    SetKey1IdProtocol[SetKey1IdProtocol.Length - 1] = Crc8(SetKey1IdProtocol);

                    serialPort1.Write(SetKey1IdProtocol, 0, 8);
                }
            }
            else
            {
                MessageBox.Show("钥匙id长度输入有误", "提示");
            }
        }
        private void setKey2IdBut_Click(object sender, EventArgs e)
        {
            if (8 == KeyId2Box.TextLength)
            {
                if (serialPort1.IsOpen)
                {
                    byte[] WriteKeyIdbuff = new byte[4];
                    WriteKeyIdbuff = StrToHexByte(KeyId2Box.Text);

                    for (int i = 0; i < 4; i++)
                    {
                        SetKey2IdProtocol[i + 3] = WriteKeyIdbuff[i];

                    }

                    SetKey2IdProtocol[SetKey2IdProtocol.Length - 1] = Crc8(SetKey2IdProtocol);

                    serialPort1.Write(SetKey2IdProtocol, 0, 8);
                }
            }
            else
            {
                MessageBox.Show("钥匙id长度输入有误", "提示");
            }
        }
        private void setIpSelectBut_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                if (0 == ipSelectBox.SelectedIndex)
                {
                    SetDomainSelect[3] = 0x55;
                }
                else if (1 == ipSelectBox.SelectedIndex)
                {
                    SetDomainSelect[3] = 0xaa;
                }
                SetDomainSelect[4] = Crc8(SetDomainSelect);
                serialPort1.Write(SetDomainSelect, 0, 5);
            }
 
        }
        private void readPowerbut_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write(ReadPowerProtocol, 0, 5);
                }
                else
                {
                    MessageBox.Show("串口未打开！", "提示");
                }

            }
            catch(Exception ex)
            {
                LogHelper.WriteLog(typeof(MainFrom), ex);
            }
        }
        private void readVersionNumBut_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write(GetVersionNumber, 0, 5);
                }
                else
                {
                    MessageBox.Show("串口未打开！", "提示");
                }

            }
            catch (Exception ex)
            {
                LogHelper.WriteLog(typeof(MainFrom), ex);
            }
        }
        private void readSimIDbutton_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write(GetSimIdProtocol, 0, 5);
                }
                else
                {
                    MessageBox.Show("串口未打开！", "提示");
                }

            }
            catch
            {

            }
        }
        private void BaseSettingstab_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void MainFrom_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {

                serialPort1.Close();

                System.Environment.Exit(0);
            }
            catch  
            {

                
            }
         
        }

        private void setMainportBut_Click(object sender, EventArgs e)
        {
            try
            {
                if(setmainPortBox.Text.Length == 5)
                {
                    if (serialPort1.IsOpen)
                    {

                        SetServerPort(setmainPortBox.Text, "主服务器");
                    }
                }
                else
                {
                    MessageBox.Show("端口长度不正确");
                }
                
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog(typeof(MainFrom), ex);
            }  
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (sparePortBox.Text.Length == 5)
                {
                    if (serialPort1.IsOpen)
                    {
                        SetServerPort(sparePortBox.Text, "备用服务器");
                    }
                }
               
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog(typeof(MainFrom), ex);
            }
           
        }

        private void setboardid_Click(object sender, EventArgs e)
        {
            if (8 ==boardidBox.Text.Length)
            {
                if (serialPort1.IsOpen)
                {
                    WriteID = StrToHexByte(boardidBox.Text);

                    for (int i = 0; i < 4; i++)
                    {
                        SetBoardIdProtocol[i + 3] = WriteID[i];

                    }
                    CheckTemp = 0;

                    for (int i = 0; i < SetBoardIdProtocol.Length - 1; i++)
                    {
                        CheckTemp ^= SetBoardIdProtocol[i];
                    }
                    SetBoardIdProtocol[SetBoardIdProtocol.Length - 1] = CheckTemp;
                    serialPort1.Write(SetBoardIdProtocol, 0, 8);
                }
            }
            else
            {
                MessageBox.Show("请检查输入长度", "提示");
            }
        }

        private void resetBoard_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(ResetMcu, 0, 5);
            }
        }

        private void clearFlash_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(ResetFlashProtocol, 0, 5);
            }
        }

        /*串口拔插捕获*/
        protected override void WndProc(ref Message m)
        {

            if (m.Msg == WM_DEVICE_CHANGE)        // 捕获USB设备的拔出消息WM_DEVICECHANGE
            {

                switch (m.WParam.ToInt32())
                {
                    /*Usb拔除*/
                    case DBT_DEVICE_REMOVE_COMPLETE:
                    {
                        Closeing = true;

                        while (Listening)
                        {
                            Application.DoEvents();
                        } 
 
                        serialPort1.Close();
                        Closeing = false ;
                        scanPort.Enabled = true;
                        openSerialPort.Text = "打开串口";
                        SearchAndAddSerialToComboBox(serialPort1, serialPortBox);
                        logTextBox.AppendText("提示：串口可能被拔除！\r\n");

                     }
                    break;
                    
                        /*Usb插入获取对应串口名称*/
                    case DBT_DEVICEARRIVAL: 
                    {
                        SearchAndAddSerialToComboBox(serialPort1, serialPortBox);
                        logTextBox.AppendText("提示：可能有新串口插入\r\n");
                    }
                    break;
 
                }


            }
            base.WndProc(ref m);
        }
        FromProductInfo fromProductInfo ;
        private void butProInfo_Click(object sender, EventArgs e)
        {
           
            if(fromProductInfo == null ||fromProductInfo.IsDisposed)
            {
                fromProductInfo = new FromProductInfo();
                fromProductInfo.Show();
            }
            else
            {
                fromProductInfo.Activate();
            }
            
        }
    }
}
