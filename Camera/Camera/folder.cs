using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.IO;

namespace Camera
{
    class folder
    {
        byte[] byData = new byte[100];
        char[] charData = new char[1000];
        public string[] data =new string[500];
        public void Read()
        {
            try
            { 
            StreamReader sr = new StreamReader("path.txt", Encoding.Default);
            int i = 0;
            while ((data[i] = sr.ReadLine()) != null)
            {
                i++;
            }           
            sr.Close();
            }
            catch
            {
                FileStream fs = new FileStream("path.txt", FileMode.Create);
                //获得字节数组
                byte[] da = System.Text.Encoding.Default.GetBytes("D:\nD:");
                //开始写入
                fs.Write(da, 0, da.Length);
                //清空缓冲区、关闭流
                fs.Flush();
                fs.Close();
                StreamReader sr = new StreamReader("path.txt", Encoding.Default);
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
            FileStream fs = new FileStream("path.txt", FileMode.Create);
            //获得字节数组
            byte[] data = System.Text.Encoding.Default.GetBytes(path);
            //开始写入
            fs.Write(data, 0, data.Length);
            //清空缓冲区、关闭流
            fs.Flush();
            fs.Close();
        }
    }
    public class FolderDialog : FolderNameEditor
    {
        FolderNameEditor.FolderBrowser fDialog = new
        System.Windows.Forms.Design.FolderNameEditor.FolderBrowser();
        public FolderDialog()
        {
        }
        public DialogResult DisplayDialog()
        {
            return DisplayDialog("请选择一个文件夹");
        }
        public DialogResult DisplayDialog(string description)
        {
            fDialog.Description = description;
            return fDialog.ShowDialog();
        }
        public string Path
        {
            get
            {
                return fDialog.DirectoryPath;
            }
        }
       ~FolderDialog()
        {
            fDialog.Dispose();
        }
    }
}
