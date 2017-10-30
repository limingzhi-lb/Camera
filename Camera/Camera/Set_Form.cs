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
    public partial class Set_Form : Form
    {
        public Set_Form()
        {
            InitializeComponent();
        }
        /*该窗体是用来更改截图和录像存放目录，打开窗体时即打开path文件获取路径，放入textbox中，
         button按钮使用FolderDialog()可以选择系统目录并将返回值存入path中。*/
        private void Set_Form_Load(object sender, EventArgs e)
        {
            folder data = new folder();
            data.Read();
            textBox1.Text = data.data[0];
            textBox2.Text = data.data[1];
        }
        private void picture_set_btn_Click(object sender, EventArgs e)
        {

            FolderDialog aa = new FolderDialog();
            aa.DisplayDialog();
            if (aa.Path != null)
            {
                folder data = new folder();
                folder da = new folder();
                da.Read();
                data.Write(aa.Path + "\n" + da.data[1]);
            }
            folder s = new folder();
            s.Read();
            textBox1.Text = s.data[0];
            textBox2.Text = s.data[1];
        }
        private void video_set_btn_Click(object sender, EventArgs e)
        {
            FolderDialog aa = new FolderDialog();
            aa.DisplayDialog();
            if (aa.Path != null)
            {
                folder data = new folder();
                folder da = new folder();
                da.Read();
                data.Write(da.data[0] + "\n" + aa.Path);
            }
            folder s = new folder();
            s.Read();
            string d = s.data[0];
            textBox1.Text = d;
            textBox2.Text = s.data[1];
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
