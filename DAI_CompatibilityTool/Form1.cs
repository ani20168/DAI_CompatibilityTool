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
using System.Globalization;
using System.Threading;

namespace DAI_CompatibilityTool
{
    public partial class Form1 : Form
    {
        string gamepath="";

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (Directory.Exists(@"C:\ProgramData\DAI_tool"))       //記憶上次路徑
            {
                path_show.Text = File.ReadAllText(@"C:\ProgramData\DAI_tool\temp.txt");
                gamepath = path_show.Text.Replace(@"\DragonAgeInquisition.exe", "");
                status();
            }
        }

        int status()       //確認是否兼容
        {
            if (gamepath == "")
            {
                status_show.Text = "未知";
                return 2;
            }

            if (Directory.Exists(gamepath + @"\Update\Patch_ModManagerMerge"))
            {
                status_show.Text = "不兼容";
                return 0;
            }
            else
            {
                status_show.Text = "完整兼容";
                return 1;
            }
        }

        private void on_button_Click(object sender, EventArgs e)
        {
            if (gamepath != "")
            {
                if (status() == 0)
                {
                    Directory.Move(gamepath + @"\Update\Patch", gamepath + @"\Update\Patch_O");
                    Directory.Move(gamepath + @"\Update\Patch_ModManagerMerge", gamepath + @"\Update\Patch");
                    status();
                    
                    if (Directory.Exists(gamepath + @"\ModData"))           //刪除MODDATA
                        Directory.Delete(gamepath + @"\ModData", true);
                    MessageBox.Show("已開啟兼容，您可以使用Frosty開啟遊戲了", "提示");
                }
                else
                {
                    MessageBox.Show("目前為兼容模式，您可以使用Frosty開啟遊戲了","提示");
                }
                
            }
            else
            {
                MessageBox.Show("尚未選擇路徑", "提示",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void off_button_Click(object sender, EventArgs e)
        {
            if (gamepath != "")
            {
                if (status() == 1)
                {

                    if (Directory.Exists(gamepath + @"\Update\Patch_O")) //關閉兼容的例外狀況
                    {
                        Directory.Move(gamepath + @"\Update\Patch", gamepath + @"\Update\Patch_ModManagerMerge");
                        Directory.Move(gamepath + @"\Update\Patch_O", gamepath + @"\Update\Patch");
                        MessageBox.Show("兼容已關閉", "提示");
                    }
                    else
                        MessageBox.Show("找不到原始Patch資料夾", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    status();
                }
                else
                    MessageBox.Show("目前兼容已關閉", "提示");
            }
            else
            {
                MessageBox.Show("尚未選擇路徑", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void path_button_Click(object sender, EventArgs e)      //指定路徑
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "DAI Executable file| DragonAgeInquisition.exe";
            file.RestoreDirectory = true;
            if (file.ShowDialog() == DialogResult.OK)
            {
                path_show.Text = file.FileName;
                gamepath = path_show.Text.Replace(@"\DragonAgeInquisition.exe", "");
                status();
                if (path_show.Text != "")
                {
                    Directory.CreateDirectory(@"C:\ProgramData\DAI_tool");      //記憶路徑
                    File.WriteAllText(@"C:\ProgramData\DAI_tool\temp.txt", path_show.Text);
                }
            }
            
        }

        private void language_button_Click(object sender, EventArgs e)
        {
            if (Thread.CurrentThread.CurrentUICulture.Name == "zh-TW")
            {
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en");
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("zh-TW");
            }
            this.Controls.Clear(); this.InitializeComponent();
        }
    }
}
