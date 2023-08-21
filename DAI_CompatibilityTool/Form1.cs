using System;
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

        //回傳資源檔字串
        public static string GetResxString(string key)
        {
            return Properties.Resources.ResourceManager.GetString(key);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Directory.Exists(@"C:\ProgramData\DAI_tool"))       //記憶上次路徑
            {
                path_show.Text = File.ReadAllText(@"C:\ProgramData\DAI_tool\temp.txt");
                gamepath = path_show.Text.Replace(@"\DragonAgeInquisition.exe", "");
                Status();
            }
        }

        int Status()       //確認是否兼容
        {
            if (gamepath == "")
            {
                status_show.Text = GetResxString("unknown");
                return 2;
            }

            if (Directory.Exists(gamepath + @"\Update\Patch_ModManagerMerge"))
            {
                status_show.Text = GetResxString("incompatible");
                return 0;
            }
            else
            {
                status_show.Text = GetResxString("fully_compatible");
                return 1;
            }
        }

        private void on_button_Click(object sender, EventArgs e)
        {
            if (gamepath == "")
            {
                MessageBox.Show(GetResxString("no_path_selected_message"), GetResxString("messagebox_title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (Status() == 0)
            {
                Directory.Move(gamepath + @"\Update\Patch", gamepath + @"\Update\Patch_O");
                Directory.Move(gamepath + @"\Update\Patch_ModManagerMerge", gamepath + @"\Update\Patch");
                Status();
                    
                if (Directory.Exists(gamepath + @"\ModData"))           //刪除MODDATA
                    Directory.Delete(gamepath + @"\ModData", true);
                MessageBox.Show(GetResxString("active_mode_message"),GetResxString("messagebox_title"));
            }
            else
            {
                MessageBox.Show(GetResxString("current_is_active_mode_message"), GetResxString("messagebox_title"));
            }
        }

        private void off_button_Click(object sender, EventArgs e)
        {
            if (gamepath == "")
            {
                MessageBox.Show(GetResxString("no_path_selected_message"), GetResxString("messagebox_title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (Status() == 1)
            {

                if (Directory.Exists(gamepath + @"\Update\Patch_O")) //關閉兼容的例外狀況
                {
                    Directory.Move(gamepath + @"\Update\Patch", gamepath + @"\Update\Patch_ModManagerMerge");
                    Directory.Move(gamepath + @"\Update\Patch_O", gamepath + @"\Update\Patch");
                    MessageBox.Show(GetResxString("inactive_mode_message"), GetResxString("messagebox_title"));
                }
                else
                    MessageBox.Show(GetResxString("cannot_find_patch_folder"), GetResxString("error"), MessageBoxButtons.OK, MessageBoxIcon.Error);

                Status();
            }
            else
            {
                MessageBox.Show(GetResxString("current_is_inactive_mode_message"), GetResxString("messagebox_title"));
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
                Status();
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
                Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en");
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("zh-TW");
                Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("zh-TW");
            }
            this.Controls.Clear(); this.InitializeComponent();
            Status();
        }
    }
}
