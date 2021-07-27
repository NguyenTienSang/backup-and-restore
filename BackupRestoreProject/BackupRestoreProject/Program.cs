using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Data.SqlClient;
using System.Data;

namespace BackupRestoreProject
{
    static class Program
    {
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static SqlDataReader myReader;
        public static String servername = "";
        public static String username = "";
        public static String login = "";
        public static String password = "";

        public static String URL = "D:/Documents/HK2/CHUYENDECONGNGHEPHANMEM/BACKUP/TIME";
        public static String URLDEV = "D:/Documents/HK2/CHUYENDECONGNGHEPHANMEM/BACKUP/DEV/";
        public static String database = "QLVT";
        public static FormLogin frmLogin;
        public static FormMain frmMain;

        public static int KetNoi() //null thì lỗi, không null thì chạy
        {
            if (Program.conn != null && Program.conn.State == System.Data.ConnectionState.Open)
            {
                Program.conn.Close();
            }

            try
            {
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                                Program.database + ";User ID=" + Program.login + ";Password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Program.connstr);
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu. \nBạn xem lại Username và Password.\n" + ex.Message, "Lỗi kết nối!", MessageBoxButtons.OK);
                return 0;
            }
        }

        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 600; // Đợi lệnh chạy. đơn vị: giây.
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader();
                return myreader;
            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static int ExecSqlNonQuery(String lenh, String connect, string error)
        {
            conn = new SqlConnection(connect);
            SqlCommand Sqlcmd = new SqlCommand(lenh, conn);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 600; //10 phut
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                int loi = Sqlcmd.ExecuteNonQuery();
                conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("Error converting data type varchar to int"))
                {
                    MessageBox.Show("Format lại các cột kiểu char qua int");
                }
                else
                {
                    MessageBox.Show(error + "\n" + ex.Message);
                }
                conn.Close();
                return (ex.State);// trạng thái lỗi gửi từ RAISERROR trong sql server qua
            }
        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmMain = new FormMain();
            frmLogin = new FormLogin();
            Application.Run(frmLogin);
        }
    }
}
