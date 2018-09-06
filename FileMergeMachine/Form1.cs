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
using System.Diagnostics;
namespace FileMergeMachine
{
    public partial class FileMergeMachine : Form
    {
        private string folder_path;
        public static string[] folder_files;
        public static string dest_file;
        public FileMergeMachine()
        {
            InitializeComponent();
        }

        private void btnSelectDirectory_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer;
            if(folderBrowserDialog1.ShowDialog()== DialogResult.OK)
            {
                folder_path = folderBrowserDialog1.SelectedPath;
            }
        }

        private void BtnSearchAllFile_Click(object sender, EventArgs e)
        {
            if(Directory.Exists(folder_path))
            {
                folder_files = Directory.GetFiles(folder_path, FileNameStrBox.Text, SearchOption.AllDirectories);
                listBox1.Items.Clear();
                int selected_index = 0;
                foreach(string folder_file in folder_files)
                {
                    selected_index = listBox1.Items.Add(folder_file);
                    listBox1.SetSelected(selected_index, true);
                }
            }
        }

        private void BtnUpMove_Click(object sender, EventArgs e)
        {
            int sel_index = listBox2.SelectedIndex;
            string sel_str = listBox2.SelectedItem.ToString();
            if(sel_index>0)
            {
                listBox2.Items[sel_index] = listBox2.Items[sel_index - 1];
                listBox2.Items[sel_index - 1] = sel_str;
                listBox2.SetSelected(sel_index, false);
                listBox2.SetSelected(sel_index-1, true);
            }
        }

        private void BtnDownMove_Click(object sender, EventArgs e)
        {
            int sel_index = listBox2.SelectedIndex;
            string sel_str = listBox2.SelectedItem.ToString();
            if (sel_index < listBox2.Items.Count-1)
            {
                listBox2.Items[sel_index] = listBox2.Items[sel_index + 1];
                listBox2.Items[sel_index + 1] = sel_str;
                listBox2.SetSelected(sel_index, false);
                listBox2.SetSelected(sel_index + 1, true);
            }
        }

        private void BtnTargetFileName_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "选择要合并后的文件";
            saveFileDialog1.InitialDirectory = System.Environment.SpecialFolder.DesktopDirectory.ToString();
            saveFileDialog1.OverwritePrompt = false;
            if(saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                dest_file = saveFileDialog1.FileName;
                lblNewFileName.Text = dest_file;
            }
        }

        private void BtnMerge_Click(object sender, EventArgs e)
        {
            if(File.Exists(dest_file))
            {
                File.Delete(dest_file);
            }
            FileStream fs_dest = new FileStream(dest_file, FileMode.CreateNew, FileAccess.Write);
            byte[] DataBuffer = new byte[100000];
            byte[] file_name_buf;
            FileStream fs_source = null;
            int read_len;
            FileInfo fi_a = null;
            for(int i = 0; i<listBox2.Items.Count;i++)
            {
                fi_a = new FileInfo(listBox2.Items[i].ToString());
                file_name_buf = Encoding.Default.GetBytes(fi_a.Name);
                //写入文件名
                if (checkBoxAddName.Checked == true)
                {
                    fs_dest.Write(file_name_buf, 0, file_name_buf.Length);
                    //换行
                    fs_dest.WriteByte((byte)13);
                    fs_dest.WriteByte((byte)10);
                }
                fs_source = new FileStream(fi_a.FullName, FileMode.Open, FileAccess.Read);
                read_len = fs_source.Read(DataBuffer, 0, 100000);
                while(read_len>0)
                {
                    fs_dest.Write(DataBuffer, 0, read_len);
                    read_len = fs_source.Read(DataBuffer, 0, 100000);
                }
                //换行
                if (checkBoxSwitchLine.Checked == true)
                {
                    fs_dest.WriteByte((byte)13);
                    fs_dest.WriteByte((byte)10);
                }
                fs_source.Close();
            }
            fs_source.Dispose();
            fs_dest.Flush();
            fs_dest.Close();
            fs_dest.Dispose();
            if (checkBoxOpenTarget.Checked == true)
            {
                Process.Start(dest_file);
            }
        }

        private void BtnAddToSet_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem);
        }

        private void BtnClearSet_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void BtnQuitSet_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void BtnAddSingleFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = System.Environment.SpecialFolder.DesktopDirectory.ToString();
            openFileDialog1.Title = "请选择文件";
            openFileDialog1.Filter = "所有文件(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                listBox2.Items.Add(Path.GetFullPath(openFileDialog1.FileName));
            }
        }

        private void BtnOpenSelectedContext_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItems.Count > 0)
            {
                Process.Start(listBox2.SelectedItem.ToString());
            }
        }
    }
}
