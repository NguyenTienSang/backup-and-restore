using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace BackupRestoreProject
{
    public partial class FormLogin : DevExpress.XtraEditors.XtraForm
    {
        public FormLogin()
        {
            InitializeComponent();
            txbServerName.Text = "DESKTOP-TB0T8JJ\\TIENSANG".Trim();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txbServerName.Text.Trim() == "")
            {
                MessageBox.Show("Server name không được rỗng", "Báo lỗi đăng nhập", MessageBoxButtons.OK);
                txbServerName.Focus();
                return;
            }
            else if (txbLoginName.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản đăng nhập không được rỗng", "Báo lỗi đăng nhập", MessageBoxButtons.OK);
                txbLoginName.Focus();
                return;
            }
            else if (txbPassword.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu đăng nhập không được rỗng. Kiểm tra lại !", "Báo lỗi đăng nhập", MessageBoxButtons.OK);
                txbPassword.Focus();
                return;
            }
            else
            {
                Program.login = txbLoginName.Text;
                Program.password = txbPassword.Text;
                Program.servername = txbServerName.Text;
                if (Program.KetNoi() == 0) return;
                MessageBox.Show("Đăng nhập thành công", "", MessageBoxButtons.OK);
                this.Hide();
                Program.frmMain.Show();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}