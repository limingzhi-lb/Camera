using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Camera
{
    public partial class Login: System.Windows.Forms.Form
    {
        public static Int32 result = -1;
        public CHCNetSDK.NET_DVR_DEVICEINFO_V30 DeviceInfo;
        private bool InitSDK = false;
        public static string IP;
        public static string Port;
        public static string Username;
         byte[] byData = new byte[100];
        char[] charData = new char[1000];
        public string[] data =new string[500];
        public void Read()
        {
            try
            { 
            StreamReader sr = new StreamReader("log_data.txt", Encoding.Default);
            int i = 0;
            while ((data[i] = sr.ReadLine()) != null)
            {
                i++;
            }           
            sr.Close();
            }
            catch
            {
                FileStream fs = new FileStream("log_data.txt", FileMode.Create);
                //获得字节数组
                byte[] da = System.Text.Encoding.Default.GetBytes("");
                //开始写入
                fs.Write(da, 0, da.Length);
                //清空缓冲区、关闭流
                fs.Flush();
                fs.Close();
                StreamReader sr = new StreamReader("log_data.txt", Encoding.Default);
                int i = 0;
                while ((data[i] = sr.ReadLine()) != null)
                {
                    i++;
                }
                sr.Close();
            }              
        }
        public void Write(string path)
        {
            FileStream fs = new FileStream("log_data.txt", FileMode.Create);
            //获得字节数组
            byte[] data = System.Text.Encoding.Default.GetBytes(path);
            //开始写入
            fs.Write(data, 0, data.Length);
            //清空缓冲区、关闭流
            fs.Flush();
            fs.Close();
        }
        public Login()
        {
            /*在运行程序时就对设备进行初始化，调用CHCNetSDK.cs 中的NET_DVR_Init()*/
            InitializeComponent();
            InitSDK = CHCNetSDK.NET_DVR_Init();
            if (InitSDK == false)
            {
                MessageBox.Show("设备初始化失败!");
                return;
            }
            else
            {
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Read();
            if (data[0]!=null)
            {
                IPBox.Text = data[0];
                PortBox.Text = data[1];
                NameBox.Text = data[2];
                PasswordBox.Text = data[3];
                log_msg_chk.Checked = true;
            }

        }

        public void IPBox_TextChanged(object sender, EventArgs e)
        {          
        }
        
        public void NameBox_TextChanged(object sender, EventArgs e)
        {
        }
        public void PortBox_TextChanged(object sender, EventArgs e)
        {
        }
        /*登录时首先检查输入的参数是否完整，然后调用NET_DVR_Login_V30(),传入参数,返回值result为整数，
         * 是登录后的状态，-1表示登录失败，其余的返回值可以查看SDK使用手册，登录成功后隐藏该窗体，进入主窗体*/
        private void LoginButton_Click(object sender, System.EventArgs e)
        {
            if(IPBox.Text==""||PortBox.Text==""||NameBox.Text==""||PasswordBox.Text=="")
            {
                MessageBox.Show("请输入完整的参数");
                return;
            }
            if (log_msg_chk.Checked == true)
            {
                Write(IPBox.Text + "\n" + PortBox.Text + "\n" + NameBox.Text + "\n" + PasswordBox.Text);
            }
            else
            {
                Write("");
            }
            string IPAddress = IPBox.Text;
            Int16 PortNumber = Int16.Parse(PortBox.Text);
            string Name = NameBox.Text;
            string Password = PasswordBox.Text;
            result = CHCNetSDK.NET_DVR_Login_V30(IPAddress, PortNumber, Name, Password, ref DeviceInfo);
            if (result == -1)
            {
                MessageBox.Show("登录失败");
                return;
            }
            else
            {
                IP = IPBox.Text;
                Port = PortBox.Text;
                Username = NameBox.Text;
                
                Main camera = new Main();
                camera.Show();
                this.Hide();
            }
        }
        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {
        }       
    }
}
