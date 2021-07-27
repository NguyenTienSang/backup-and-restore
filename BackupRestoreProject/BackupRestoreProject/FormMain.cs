using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace BackupRestoreProject
{

   // select database_name, backup_set_id, position, recovery_model from msdb.dbo.backupset
   

   //RESTORE DATABASE QLThuVien WITH RECOVERY

   //EXEC msdb.dbo.sp_delete_database_backuphistory @database_name = 'QLThuVien';
    //sp_dropdevice 'DEV_', 'delfile'
    public partial class FormMain : DevExpress.XtraEditors.XtraForm
    {

        int listbackup = 0;
        String NameDevice = "";
        int listbackuplastest = 0;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.Databases' table. You can move, or remove it, as needed.
            this.DatabasesTableAdapter.Connection.ConnectionString = Program.connstr;
            this.DatabasesTableAdapter.Fill(this.DS.Databases);
            bdsDatabase.Position = 0;
            databasesGridControl_Click(sender, e);
            pnCheckLoaiRestore.Hide();
        }

        private void LoadListBackup()
        {
            if (txbNameDatabase.Text.Trim() == "") return;
            try
            {
                this.OrderBackupTableAdapter.Connection.ConnectionString = Program.connstr;
                this.OrderBackupTableAdapter.Fill(this.DS.Order_Backup, txbNameDatabase.Text.Trim());
                if (bdsOrderBackup.Count == 0)
                {
                    listbackup = 0;
                }
                else
                {
                    listbackup = int.Parse(((DataRowView)bdsOrderBackup[0])["position"].ToString());
                }
                txbListBackup.Text = listbackup.ToString();
                CheckCountDevice();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message + "  .Sai ở hàm Load cac ban sao luu");
            }
        }


        private void CheckCountDevice()
        {
            String sql = "SELECT  COUNT(name)  FROM  sys.backup_devices  WHERE  name  =  N'DEV_" + txbNameDatabase.Text.Trim() + "'";
            Program.myReader = Program.ExecSqlDataReader(sql);
            if (Program.myReader == null) return;
            Program.myReader.Read();

            //CÓ DEVICE THÌ ẨN NÚT TẠO DEVICE 
            if (Program.myReader.GetInt32(0) > 0)
            {
                if (listbackup == 0)
                {
                    btnPhucHoi.Enabled = CheckboxPhucHoiTheoThoiGian.Enabled = false;
                }
                else
                {
                    btnPhucHoi.Enabled = CheckboxPhucHoiTheoThoiGian.Enabled = true;
                }
                btnSaoLuu.Enabled = true;
                btnTaoThietBi.Enabled = false;

                NameDevice = "DEV_" + txbNameDatabase.Text.Trim();

            }
            // CHƯA CÓ DEVICE THÌ CHO TẠO MỚI
            else
            {
                btnSaoLuu.Enabled = btnPhucHoi.Enabled = CheckboxPhucHoiTheoThoiGian.Enabled = false;
                btnTaoThietBi.Enabled = true;
            }
            Program.myReader.Close();

        }

        public int CreateDevice(String tenDatabase)
        {
            String CreateDevice = "EXEC sp_addumpdevice 'disk' , 'DEV_" + tenDatabase.Trim() + "' , '" + Program.URLDEV + tenDatabase.Trim() + ".bak'";
            int kiemtra = Program.ExecSqlNonQuery(CreateDevice, Program.connstr, "");
            if (kiemtra != 0)
            {
                MessageBox.Show("Lỗi khi tạo mới device");
                return 0;
            }
            else
            {
                return 1;
            }
        }


        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.OrderBackupTableAdapter.Fill(this.DS.Order_Backup, txbNameDatabase.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnSaoLuu_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (NameDevice.Trim() == "" || txbNameDatabase.Text.Trim() == "")
            {
                return;
            }
            else
            {
                if (checkSaoluu.Checked == true)
                {
                    DialogResult mes1 = MessageBox.Show("Bạn muốn sao lưu ghi đè lên file cũ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (mes1 == DialogResult.Yes)
                    {
                        String xoadevice = "EXEC sp_dropdevice 'DEV_" + txbNameDatabase.Text.Trim() + "', 'delfile'";
                        int kiemtra = Program.ExecSqlNonQuery(xoadevice, Program.connstr, "");
                        if (kiemtra != 0)
                        {
                            MessageBox.Show("Lỗi khi xóa device sao lưu");
                            return;
                        }
                        int tam = CreateDevice(txbNameDatabase.Text.Trim());
                        if (tam == 0)
                        {
                            MessageBox.Show("Lỗi khi sao lưu");
                            return;
                        }
                        NameDevice = "DEV_" + txbNameDatabase.Text.Trim();
                        String cmd = "BACKUP DATABASE " + txbNameDatabase.Text.Trim() + " TO " + NameDevice.Trim() + " WITH INIT";  // ghi đè lên file hiện tại
                        kiemtra = Program.ExecSqlNonQuery(cmd, Program.connstr, "");
                        if (kiemtra != 0)
                        {
                            MessageBox.Show("Lỗi khi sao lưu");
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Sao lưu thành công");
                            LoadListBackup();
                            checkSaoluu.Checked = false;
                            return;
                        }
                    }
                }
                else
                {
                    DialogResult mes2 = MessageBox.Show("Bạn muốn sao lưu ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (mes2 == DialogResult.Yes)
                    {

                        String cmd = "BACKUP DATABASE " + txbNameDatabase.Text.Trim() + " TO " + NameDevice.Trim(); // sao lưu thường
                        int kiemtra = Program.ExecSqlNonQuery(cmd, Program.connstr, "");
                        if (kiemtra != 0)
                        {
                            MessageBox.Show("Lỗi khi sao lưu");
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Sao lưu thành công");
                            LoadListBackup();
                            return;
                        }
                    }
                }
            }
        }

        private void btnPhucHoi_ItemClick(object sender, ItemClickEventArgs e)
        {

            if(this.bdsOrderBackup.Count == 0)
            {
                MessageBox.Show("Chưa có bản sao lưu để phục hồi", "", MessageBoxButtons.OK);
                return;
            }
            if(listbackup == 0)
            {
                MessageBox.Show("Chưa chọn một bản sao lưu để phục hồi", "", MessageBoxButtons.OK);
                return;
            }
            if(Program.conn != null && Program.conn.State == ConnectionState.Open)
            {
                Program.conn.Close();
            }
            if(txbNameDatabase.Text.Trim() == "" || NameDevice == "")
            {
                return;
            }
            String strRestore = " ALTER DATABASE " + txbNameDatabase.Text.Trim()
                    + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE " +
                    " USE tempdb ";
            if (CheckboxPhucHoiTheoThoiGian.Checked == false)
            {
                strRestore += "RESTORE DATABASE " + txbNameDatabase.Text.Trim()
                    + " FROM   " + NameDevice + " WITH FILE =  " + listbackup + ", REPLACE  "
                    + " ALTER DATABASE  " + txbNameDatabase.Text.Trim() + " SET MULTI_USER";

                int kiemtra = Program.ExecSqlNonQuery(strRestore, Program.connstr, "Lỗi phục hồi CSDL");
                if (kiemtra != 0)
                {
                    MessageBox.Show("Lỗi Restore!!!");
                    return;
                }
                else
                {
                    MessageBox.Show("Restore về bản thứ "+ txbListBackup + " thành công");
                    return;
                }
            }
            else
            {
                //sau thời điểm bản full và trước thời điểm xảy ra sự cố ít nhất 3 phút
                DateTime NgaygioBK = (DateTime)((DataRowView)bdsOrderBackup[bdsOrderBackup.Position])["backup_start_date"];
                // Lay thoigian nguoi dug chon
                string timeU = dateRestore.DateTime.Year + "-" + dateRestore.DateTime.Month + "-" + dateRestore.DateTime.Day + " " +
                    timeRestore.Time.Hour + ":" + (timeRestore.Time.Minute) + ":" + timeRestore.Time.Second;
                DateTime ThoiDiemUS;
                ThoiDiemUS = DateTime.Parse(timeU);

                if ((dateRestore.DateTime.Date < NgaygioBK.Date) || (dateRestore.DateTime.Date == NgaygioBK.Date && ThoiDiemUS.TimeOfDay.Ticks < NgaygioBK.TimeOfDay.Ticks))
                {
                    MessageBox.Show("Thời điểm muốn phục hồi phải sau thời điểm bản backup đã chọn.", "", MessageBoxButtons.OK);
                    return;
                }
                if (ThoiDiemUS > DateTime.Now)
                {
                    MessageBox.Show("Thời điểm muốn phục hồi phải trước thời điểm hiện tại", "", MessageBoxButtons.OK);
                    return;
                }
                if ((MessageBox.Show("Bạn chắc chắn muốn phục hồi database " + txbNameDatabase.Text + " về ngày " + ThoiDiemUS + " ?", "", MessageBoxButtons.OKCancel) == DialogResult.OK))
                {
                    try
                    {

                        strRestore = "ALTER DATABASE " + txbNameDatabase.Text.Trim() + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE \n" +
                           " BACKUP LOG " + txbNameDatabase.Text.Trim() + " TO DISK ='" + Program.URL + "/" + "DEV_" +
                           txbNameDatabase.Text.Trim() + ".trn' WITH INIT, NORECOVERY; \n" + " USE tempdb \n " +
                           " RESTORE DATABASE " + txbNameDatabase.Text.Trim() + " FROM DEV_" + txbNameDatabase.Text.Trim() + " WITH FILE = " + listbackup + ",NORECOVERY; \n" +
                           " RESTORE DATABASE " + txbNameDatabase.Text.Trim() + " FROM DISK= '" + Program.URL + "/" + "DEV_" + txbNameDatabase.Text.Trim() + ".trn' " +
                           " WITH STOPAT= '" + timeU + "' \n" +
                           " ALTER DATABASE  " + txbNameDatabase.Text.Trim() + " SET MULTI_USER ";
                        int kiemtra = Program.ExecSqlNonQuery(strRestore, Program.connstr, "Lỗi phục hồi csdl.");
                        if (kiemtra == 0)
                        {
                            MessageBox.Show("Phục hồi cơ sở dữ liệu thành công.", "", MessageBoxButtons.OK);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi Restore:\n" + ex, "", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void CheckboxPhucHoiTheoThoiGian_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            if (CheckboxPhucHoiTheoThoiGian.Checked == true)
            {
                pnCheckLoaiRestore.Show();
                dateRestore.DateTime = DateTime.Now;
                timeRestore.Time = DateTime.Now;
            }
            else
            {
                pnCheckLoaiRestore.Hide();
            }
        }

        private void btnTaoThietBi_ItemClick(object sender, ItemClickEventArgs e)
        {
            int tam = CreateDevice(txbNameDatabase.Text.Trim());
            if (tam == 0)
            {
                MessageBox.Show("Lỗi khi sao lưu");
                return;
            }
            else
            {
                MessageBox.Show("Đã tạo Device!!!");
            }
            btnSaoLuu.Enabled = true;
            btnTaoThietBi.Enabled = false;
        }

       

        private void btnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult mes = MessageBox.Show("Bạn muốn thoát ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (mes == DialogResult.Yes)
            {
                this.Close();
                Program.frmLogin.Close();
            }
        }

        private void fillToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                this.OrderBackupTableAdapter.Fill(this.DS.Order_Backup, txbNameDatabase.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void databasesGridControl_Click(object sender, EventArgs e)
        {
            try
            {
                if (bdsDatabase.Position == -1 || bdsDatabase.Count == 0 || bdsDatabase.DataSource == null)
                {
                    txbNameDatabase.Text = "";
                }
                else
                {
                    txbNameDatabase.Text = ((DataRowView)bdsDatabase[bdsDatabase.Position])["name"].ToString();
                }
                LoadListBackup();
                txbNameDatabase.Text = ((DataRowView)bdsDatabase[bdsDatabase.Position])["name"].ToString();
                CheckCountDevice();
                NameDevice = "DEV_" + txbNameDatabase.Text.Trim();
               listbackuplastest = bdsOrderBackup.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void OrderBackupGridControl_Click(object sender, EventArgs e)
        {
            listbackup = int.Parse(((DataRowView)bdsOrderBackup[bdsOrderBackup.Position])["position"].ToString());
            txbListBackup.Text = listbackup.ToString();
        }

        private void txbListBackup_Click(object sender, EventArgs e)
        {

        }
    }
}