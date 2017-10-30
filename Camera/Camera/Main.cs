using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Camera
{
    public partial class Main : Form
    {
        private Int32 m_iPreviewType = 1;
        private IntPtr m_ptrRealHandle;
        private CHCNetSDK.REALDATACALLBACK m_fRealData = null;      
        private Int32 m_lRealHandle = 1;
        private CHCNetSDK.NET_DVR_CLIENTINFO lpClientInfo;
        
        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            shIP.Text = "设备IP:" + Login.IP;
            shPort.Text = "端口:" + Login.Port;
            shName.Text = "用户:" + Login.Username;
            Information.Text = "";
        }
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void shIP_Click(object sender, EventArgs e)
        {
        }
        private void shPort_Click(object sender, EventArgs e)
        {
        }
        private void shName_Click(object sender, EventArgs e)
        {
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            CHCNetSDK.NET_DVR_Logout(Login.result);
            CHCNetSDK.NET_DVR_Cleanup();
            Application.Exit();
        }
        private void Relogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            CHCNetSDK.NET_DVR_Logout(Login.result);
            CHCNetSDK.NET_DVR_Cleanup();
            
            login.Show();
            this.Hide();
        }
        private void view_Click(object sender, EventArgs e)
        {
        }
        /*预览有两种模式，在于是否传入码回调函数，具体区别可以查阅SDK操作手册，NET_DVR_RealPlay_V30()的返回值
         为错误码，可以根据返回的错误码来进行下一步操作(码流是指视频文件在单位时间内使用的数据流量)*/
        private void Previewbtn_Click(object sender, EventArgs e)
        {
            lpClientInfo.lChannel = 1;
            lpClientInfo.lLinkMode = 0x0000;
            lpClientInfo.sMultiCastIP = "";
            if (Previewbtn.Text == "预览")
            {
                if (m_iPreviewType == 0) // use by callback
                {
                    lpClientInfo.hPlayWnd = IntPtr.Zero;

                    m_ptrRealHandle = RealPlayWnd.Handle;
                    m_fRealData = new CHCNetSDK.REALDATACALLBACK(RealDataCallBack);
                    IntPtr pUser = new IntPtr();
                    m_lRealHandle = CHCNetSDK.NET_DVR_RealPlay_V30(Login.result, ref lpClientInfo, m_fRealData, pUser, 1);
                }
                else if (1 == m_iPreviewType)
                {
                    lpClientInfo.hPlayWnd = RealPlayWnd.Handle;
                    IntPtr pUser = new IntPtr();
                    m_lRealHandle = CHCNetSDK.NET_DVR_RealPlay_V30(Login.result, ref lpClientInfo, null, pUser, 1);
                }               
                if (m_lRealHandle == -1)
                {
                    uint nError = CHCNetSDK.NET_DVR_GetLastError();
                    Information.Text += "发生错误，错误代码：" + nError + System.Environment.NewLine;                                        
                }              
                if (m_lRealHandle != -1)
                {
                    Information.Text += "正在预览..." + System.Environment.NewLine;
                    Previewbtn.Text = "停止预览";
                }
            }
            else
            {
                bool result = CHCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle);
                if (result == true)
                {
                    Information.Text += "预览结束" + System.Environment.NewLine;
                    RealPlayWnd.Image = null;
                    Previewbtn.Text = "预览";                   
                }
            }         
        }
        /*截图和录像的存放目录保存在与exe文件同文件夹下的path.txt中，在截图和录像之前先从
         TXT中取出路径，将系统时间作为文件名。使用的是NET_DVR_CaptureJPEGPicture()和
         NET_DVR_SaveRealData()函数*/
        private void button1_Click(object sender, EventArgs e)
        {
                     
            CHCNetSDK.NET_DVR_JPEGPARA jpgpa = new CHCNetSDK.NET_DVR_JPEGPARA();
            jpgpa.wPicSize = 5;
            jpgpa.wPicQuality = 2;
            DateTime time=DateTime.Now;
            folder data = new folder();
            data.Read();
            if (data.data[0] == "" || data.data[1] == "")
            {
                Information.Text += "请先指定截图存放目录！" + System.Environment.NewLine;
                return;
            }
            string src = data.data[0]+"/"+ time.ToString("yyyy-MM-dd-hh-mm-ss") + ".jpeg";
            bool result = CHCNetSDK.NET_DVR_CaptureJPEGPicture(Login.result, 1, ref jpgpa,src);
            if (result == false)
            {
                Information.Text += "拍照失败！" + System.Environment.NewLine;     //摄像机拍照失败
                uint nError = CHCNetSDK.NET_DVR_GetLastError();
                Information.Text += "发生错误，错误代码：" + nError + System.Environment.NewLine;
                if(nError==34)
                { Information.Text += "请检查截图存放目录！" + System.Environment.NewLine; }
            }
            else
            {
                Information.Text += "图片已保存到:" + src + System.Environment.NewLine;
            }
            //结束操作
                        
        }
        public delegate void MyDebugInfo(string str);
        public void RealDataCallBack(Int32 lRealHandle, UInt32 dwDataType, ref byte pBuffer, UInt32 dwBufSize, IntPtr pUser)
        {            
        }
        public void DebugInfo(string str)
        {
            if (str.Length > 0)
            {
                str += "\n";               
            }
        }               
        /// 视频录像      
        private void recordbtn_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            folder data = new folder();
            data.Read();
                       
            if (data.data[0] == "" || data.data[1] == "")
            {
                Information.Text += "请先指定录像存放目录！" + System.Environment.NewLine;
                return;
            }
            string src = data.data[1]+ "/"+time.ToString("yyyy-MM-dd-hh-mm-ss") + ".mp4";   
            if (recordbtn.Text =="视频录像" )
            {
                bool result = CHCNetSDK.NET_DVR_SaveRealData(m_lRealHandle, src);
                if(result ==true)
                {
                    recordbtn.Text = "停止录像";
                    Information.Text += "录像开始！"+ System.Environment.NewLine;
                }
                else
                {
                    Information.Text += "录像失败！" + System.Environment.NewLine;    
                    uint nError = CHCNetSDK.NET_DVR_GetLastError();
                    Information.Text += "发生错误，错误代码：" + nError + System.Environment.NewLine;
                    if (nError == 12)
                    { Information.Text += "请先开启预览！" + System.Environment.NewLine; }
                    else if (nError == 34)
                    { Information.Text += "请检查录像存放目录！" + System.Environment.NewLine; }
                }
            }
            else
            {
                if (CHCNetSDK.NET_DVR_StopSaveRealData(m_lRealHandle) == true)
                {
                    recordbtn.Text = "视频录像";
                    Information.Text += "录像已保存到:" + src + System.Environment.NewLine;
                }
                else
                {
                    Information.Text += "结束录像失败！" + System.Environment.NewLine;    
                    uint nError = CHCNetSDK.NET_DVR_GetLastError();
                    Information.Text += "发生错误，错误代码：" + nError + System.Environment.NewLine;  
                }
            }
        }
        /*调整焦距和镜头距离是同一个函数，区别为传入的控制命令不同，各种控制命令查看
         SDK操作手册，这几个按钮可以点击也可以长按，长按时启动MouseDown事件，并使用timer计时，
         * 每隔一定的时间间隔就运行NET_DVR_PTZControl()函数，通过MouseUp事件结束计时，实现动态调焦和调距*/
        private void Information_TextChanged(object sender, EventArgs e)
        {
        }
        private void zoom_in_button_Click(object sender, EventArgs e)
        {
            bool result = CHCNetSDK.NET_DVR_PTZControl(m_lRealHandle,11,0);
            if(result==false)
            {               
                uint nError = CHCNetSDK.NET_DVR_GetLastError();
                if (nError == 12)
                { Information.Text += "请先启动预览！" + System.Environment.NewLine; }
            }
            bool result1 = CHCNetSDK.NET_DVR_PTZControl(m_lRealHandle, 11, 1);
        }
        private void zoom_out_button_Click(object sender, EventArgs e)
        {
            bool result = CHCNetSDK.NET_DVR_PTZControl(m_lRealHandle, 12, 0);
            if (result == false)
            {
                uint nError = CHCNetSDK.NET_DVR_GetLastError();
                if (nError == 12)
                { Information.Text += "请先启动预览！" + System.Environment.NewLine; }
            }
            bool result1 = CHCNetSDK.NET_DVR_PTZControl(m_lRealHandle, 12, 1);
        }
        private void timer_in_Tick(object sender, EventArgs e)
        {
            bool result = CHCNetSDK.NET_DVR_PTZControl(m_lRealHandle, 11, 0);
            if (result == false)
            {
                uint nError = CHCNetSDK.NET_DVR_GetLastError();
                if (nError == 12)
                { Information.Text += "请先启动预览！" + System.Environment.NewLine; }
            }
            bool result1 = CHCNetSDK.NET_DVR_PTZControl(m_lRealHandle, 11, 1);
        }
        private void timer_out_Tick(object sender, EventArgs e)
        {
            bool result = CHCNetSDK.NET_DVR_PTZControl(m_lRealHandle, 12, 0);
            if (result == false)
            {
                uint nError = CHCNetSDK.NET_DVR_GetLastError();
                if (nError == 12)
                { Information.Text += "请先启动预览！" + System.Environment.NewLine; }
            }
            bool result1 = CHCNetSDK.NET_DVR_PTZControl(m_lRealHandle, 12, 1);
        }
        private void zoom_in_button_MouseDown(object sender, MouseEventArgs e)
        {
            this.timer_in.Interval = 1;
            this.timer_in.Enabled = true;
        }
        private void zoom_in_button_MouseUp(object sender, MouseEventArgs e)
        {
            this.timer_in.Enabled = false;
        }
        private void zoom_out_button_MouseDown(object sender, MouseEventArgs e)
        {
            this.timer_out.Interval = 1;
            this.timer_out.Enabled = true;
        }
        private void zoom_out_button_MouseUp(object sender, MouseEventArgs e)
        {
            this.timer_out.Enabled = false;
        }
        private void focus_near_btn_Click(object sender, EventArgs e)
        {
            bool result = CHCNetSDK.NET_DVR_PTZControl(m_lRealHandle, 13, 0);
            if (result == false)
            {
                uint nError = CHCNetSDK.NET_DVR_GetLastError();
                if (nError == 12)
                { Information.Text += "请先启动预览！" + System.Environment.NewLine; }
            }
            bool result1 = CHCNetSDK.NET_DVR_PTZControl(m_lRealHandle, 13, 1);
        }
        private void focus_far_btn_Click(object sender, EventArgs e)
        {
            bool result = CHCNetSDK.NET_DVR_PTZControl(m_lRealHandle, 14, 0);
            if (result == false)
            {
                uint nError = CHCNetSDK.NET_DVR_GetLastError();
                if (nError == 12)
                { Information.Text += "请先启动预览！" + System.Environment.NewLine; }
            }
            bool result1 = CHCNetSDK.NET_DVR_PTZControl(m_lRealHandle, 14, 1);
        }
        private void timer_far_Tick(object sender, EventArgs e)
        {
            bool result = CHCNetSDK.NET_DVR_PTZControl(m_lRealHandle, 14, 0);
            if (result == false)
            {
                uint nError = CHCNetSDK.NET_DVR_GetLastError();
                if (nError == 12)
                { Information.Text += "请先启动预览！" + System.Environment.NewLine; }
            }
            bool result1 = CHCNetSDK.NET_DVR_PTZControl(m_lRealHandle, 14, 1);
        }
        private void timer_near_Tick(object sender, EventArgs e)
        {
            bool result = CHCNetSDK.NET_DVR_PTZControl(m_lRealHandle, 13, 0);
            if (result == false)
            {
                uint nError = CHCNetSDK.NET_DVR_GetLastError();
                if (nError == 12)
                { Information.Text += "请先启动预览！" + System.Environment.NewLine; }
            }
            bool result1 = CHCNetSDK.NET_DVR_PTZControl(m_lRealHandle, 13, 1);
        }
        private void focus_near_btn_MouseDown(object sender, MouseEventArgs e)
        {
            this.timer_near.Interval = 1;
            this.timer_near.Enabled = true;
        }
        private void focus_near_btn_MouseUp(object sender, MouseEventArgs e)
        {
            this.timer_near.Enabled = false;
        }
        private void focus_far_btn_MouseDown(object sender, MouseEventArgs e)
        {
            this.timer_far.Interval = 1;
            this.timer_far.Enabled = true;
        }
        private void focus_far_btn_MouseUp(object sender, MouseEventArgs e)
        {
            this.timer_far.Enabled = false;
        }
        private void reset_btn_Click(object sender, EventArgs e)
        {
            bool result = CHCNetSDK.NET_DVR_ResetLens(m_lRealHandle,1);
        }
        private void focus_help_btn_Click(object sender, EventArgs e)
        {

            bool result = CHCNetSDK.NET_DVR_FocusOnePush(m_lRealHandle, 1);
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            FolderDialog aa=new FolderDialog ();
       aa.DisplayDialog ();
       MessageBox.Show(aa.Path);
        }
        private void button2_Click(object sender, EventArgs e)
        {

            Set_Form set = new Set_Form();      
            set.Show();       
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        } 
    }
}
