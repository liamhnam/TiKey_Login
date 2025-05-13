using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace TiKey_Login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnlock_Click(object sender, EventArgs e)
        {
            string scriptDir = AppDomain.CurrentDomain.BaseDirectory;
            string exePath = Path.Combine(scriptDir, ".DO_NOT_DELETE", "vc.exe");
            string arguments = "/d /f /q";

            if (File.Exists(exePath))
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = exePath,
                    Arguments = arguments,
                    UseShellExecute = false
                });
            }
            else
            {
                MessageBox.Show("Không tìm thấy vc.exe!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private async void btnunlock_Click(object sender, EventArgs e)
        {
            string scriptDir = AppDomain.CurrentDomain.BaseDirectory;
            string exePath = Path.Combine(scriptDir, ".DO_NOT_DELETE", "vc.exe");
            string vcContainer = Path.Combine(scriptDir, ".DO_NOT_DELETE", "vc-container.vc");

            string password = txtpw.Text.Trim();

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!File.Exists(exePath))
            {
                MessageBox.Show("Không tìm thấy file vc.exe", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Nếu checkbox được check, thì lock trước
            if (cbrol.Checked)
            {
                string lockArgs = "/d /f /q";

                var lockProcess = Process.Start(new ProcessStartInfo
                {
                    FileName = exePath,
                    Arguments = lockArgs,
                    UseShellExecute = false,
                    CreateNoWindow = true
                });

                await Task.Run(() => lockProcess.WaitForExit());
            }

            // Sau đó unlock
            string unlockArgs = $"/w /m label=TiKeyATTT /c n /v \"{vcContainer}\" /a /nowaitdlg y /b /q /e /p \"{password}\"";

            if (!cbrol.Checked)
            {
                unlockArgs += " /m ro"; // thêm chế độ chỉ đọc nếu không check
            }

            Process.Start(new ProcessStartInfo
            {
                FileName = exePath,
                Arguments = unlockArgs,
                UseShellExecute = false,
                CreateNoWindow = true
            });
        }


        private void btnreset_Click(object sender, EventArgs e)
        {

        }
    }
}
