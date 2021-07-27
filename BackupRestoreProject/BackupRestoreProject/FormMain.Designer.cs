namespace BackupRestoreProject
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnSaoLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.CheckboxPhucHoiTheoThoiGian = new DevExpress.XtraBars.BarCheckItem();
            this.btnTaoThietBi = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.DS = new BackupRestoreProject.DS();
            this.bdsDatabase = new System.Windows.Forms.BindingSource(this.components);
            this.DatabasesTableAdapter = new BackupRestoreProject.DSTableAdapters.DatabasesTableAdapter();
            this.tableAdapterManager = new BackupRestoreProject.DSTableAdapters.TableAdapterManager();
            this.DatabasesGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsOrderBackup = new System.Windows.Forms.BindingSource(this.components);
            this.OrderBackupTableAdapter = new BackupRestoreProject.DSTableAdapters.Order_BackupTableAdapter();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.dBNAMEToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.txbNameDatabase = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txbListBackup = new System.Windows.Forms.ToolStripTextBox();
            this.OrderBackupGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkSaoluu = new System.Windows.Forms.CheckBox();
            this.pnCheckLoaiRestore = new System.Windows.Forms.Panel();
            this.dateRestore = new DevExpress.XtraEditors.DateEdit();
            this.timeRestore = new DevExpress.XtraEditors.TimeEdit();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatabasesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsOrderBackup)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderBackupGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.panel3.SuspendLayout();
            this.pnCheckLoaiRestore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateRestore.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRestore.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeRestore.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnSaoLuu,
            this.btnPhucHoi,
            this.barButtonItem3,
            this.btnTaoThietBi,
            this.btnThoat,
            this.CheckboxPhucHoiTheoThoiGian});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSaoLuu),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPhucHoi),
            new DevExpress.XtraBars.LinkPersistInfo(this.CheckboxPhucHoiTheoThoiGian),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnTaoThietBi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThoat)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnSaoLuu
            // 
            this.btnSaoLuu.Caption = "Sao Lưu";
            this.btnSaoLuu.Id = 0;
            this.btnSaoLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSaoLuu.ImageOptions.Image")));
            this.btnSaoLuu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSaoLuu.ImageOptions.LargeImage")));
            this.btnSaoLuu.Name = "btnSaoLuu";
            this.btnSaoLuu.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSaoLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaoLuu_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục Hồi";
            this.btnPhucHoi.Id = 1;
            this.btnPhucHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.Image")));
            this.btnPhucHoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.LargeImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // CheckboxPhucHoiTheoThoiGian
            // 
            this.CheckboxPhucHoiTheoThoiGian.Caption = "Tham Số Phục Hồi Theo Thời Gian";
            this.CheckboxPhucHoiTheoThoiGian.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.CheckboxPhucHoiTheoThoiGian.Id = 6;
            this.CheckboxPhucHoiTheoThoiGian.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("CheckboxPhucHoiTheoThoiGian.ImageOptions.Image")));
            this.CheckboxPhucHoiTheoThoiGian.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("CheckboxPhucHoiTheoThoiGian.ImageOptions.LargeImage")));
            this.CheckboxPhucHoiTheoThoiGian.Name = "CheckboxPhucHoiTheoThoiGian";
            this.CheckboxPhucHoiTheoThoiGian.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.CheckboxPhucHoiTheoThoiGian.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.CheckboxPhucHoiTheoThoiGian_CheckedChanged);
            // 
            // btnTaoThietBi
            // 
            this.btnTaoThietBi.Caption = "Tạo Thiết Bị Sao Lưu";
            this.btnTaoThietBi.Id = 3;
            this.btnTaoThietBi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoThietBi.ImageOptions.Image")));
            this.btnTaoThietBi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTaoThietBi.ImageOptions.LargeImage")));
            this.btnTaoThietBi.Name = "btnTaoThietBi";
            this.btnTaoThietBi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnTaoThietBi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaoThietBi_ItemClick);
            // 
          
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 5;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(1321, 51);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 551);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1321, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 500);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1321, 51);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 500);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Tham Số Phục Hồi Theo Thời Gian";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsDatabase
            // 
            this.bdsDatabase.DataMember = "Databases";
            this.bdsDatabase.DataSource = this.DS;
            // 
            // DatabasesTableAdapter
            // 
            this.DatabasesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = BackupRestoreProject.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // DatabasesGridControl
            // 
            this.DatabasesGridControl.DataSource = this.bdsDatabase;
            this.DatabasesGridControl.Location = new System.Drawing.Point(12, 97);
            this.DatabasesGridControl.MainView = this.gridView1;
            this.DatabasesGridControl.MenuManager = this.barManager1;
            this.DatabasesGridControl.Name = "DatabasesGridControl";
            this.DatabasesGridControl.Size = new System.Drawing.Size(335, 462);
            this.DatabasesGridControl.TabIndex = 5;
            this.DatabasesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.DatabasesGridControl.Click += new System.EventHandler(this.databasesGridControl_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.gridView1.GridControl = this.DatabasesGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Danh Sách CSDL";
            this.gridColumn1.FieldName = "name";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 94;
            // 
            // bdsOrderBackup
            // 
            this.bdsOrderBackup.DataMember = "Order_Backup";
            this.bdsOrderBackup.DataSource = this.DS;
            // 
            // OrderBackupTableAdapter
            // 
            this.OrderBackupTableAdapter.ClearBeforeFill = true;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dBNAMEToolStripLabel,
            this.txbNameDatabase,
            this.toolStripLabel1,
            this.txbListBackup});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 51);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(1321, 27);
            this.fillToolStrip.TabIndex = 6;
            this.fillToolStrip.Text = "fillToolStrip";
            this.fillToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.fillToolStrip_ItemClicked);
            // 
            // dBNAMEToolStripLabel
            // 
            this.dBNAMEToolStripLabel.Name = "dBNAMEToolStripLabel";
            this.dBNAMEToolStripLabel.Size = new System.Drawing.Size(106, 24);
            this.dBNAMEToolStripLabel.Text = "Tên Database :";
            // 
            // txbNameDatabase
            // 
            this.txbNameDatabase.Name = "txbNameDatabase";
            this.txbNameDatabase.Size = new System.Drawing.Size(100, 27);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(140, 24);
            this.toolStripLabel1.Text = "Thứ tự bản sao lưu :";
            // 
            // txbListBackup
            // 
            this.txbListBackup.Name = "txbListBackup";
            this.txbListBackup.Size = new System.Drawing.Size(100, 27);
            this.txbListBackup.Click += new System.EventHandler(this.txbListBackup_Click);
            // 
            // OrderBackupGridControl
            // 
            this.OrderBackupGridControl.DataSource = this.bdsOrderBackup;
            this.OrderBackupGridControl.Location = new System.Drawing.Point(353, 97);
            this.OrderBackupGridControl.MainView = this.gridView2;
            this.OrderBackupGridControl.MenuManager = this.barManager1;
            this.OrderBackupGridControl.Name = "OrderBackupGridControl";
            this.OrderBackupGridControl.Size = new System.Drawing.Size(956, 248);
            this.OrderBackupGridControl.TabIndex = 6;
            this.OrderBackupGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.OrderBackupGridControl.Click += new System.EventHandler(this.OrderBackupGridControl_Click);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gridView2.GridControl = this.OrderBackupGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Bản sao lưu thứ";
            this.gridColumn2.FieldName = "position";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 94;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Diễn giải";
            this.gridColumn3.FieldName = "name";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 94;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Ngày giờ sao lưu";
            this.gridColumn4.DisplayFormat.FormatString = "DateTime \"yyyy-MM-dd HH:mm:ss\"";
            this.gridColumn4.FieldName = "backup_start_date";
            this.gridColumn4.MinWidth = 25;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 94;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "User sao lưu";
            this.gridColumn5.FieldName = "user_name";
            this.gridColumn5.MinWidth = 25;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            this.gridColumn5.Width = 94;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.checkSaoluu);
            this.panel3.Location = new System.Drawing.Point(353, 350);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(961, 55);
            this.panel3.TabIndex = 12;
            // 
            // checkSaoluu
            // 
            this.checkSaoluu.AutoSize = true;
            this.checkSaoluu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkSaoluu.Location = new System.Drawing.Point(156, 11);
            this.checkSaoluu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkSaoluu.Name = "checkSaoluu";
            this.checkSaoluu.Size = new System.Drawing.Size(668, 31);
            this.checkSaoluu.TabIndex = 0;
            this.checkSaoluu.Text = "Xóa tất cả các bản sao lưu cũ trong File trước khi sao lưu bản mới";
            this.checkSaoluu.UseVisualStyleBackColor = true;
            // 
            // pnCheckLoaiRestore
            // 
            this.pnCheckLoaiRestore.Controls.Add(this.dateRestore);
            this.pnCheckLoaiRestore.Controls.Add(this.timeRestore);
            this.pnCheckLoaiRestore.Controls.Add(this.textBox1);
            this.pnCheckLoaiRestore.Controls.Add(this.label1);
            this.pnCheckLoaiRestore.Location = new System.Drawing.Point(353, 409);
            this.pnCheckLoaiRestore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnCheckLoaiRestore.Name = "pnCheckLoaiRestore";
            this.pnCheckLoaiRestore.Size = new System.Drawing.Size(961, 151);
            this.pnCheckLoaiRestore.TabIndex = 75;
            // 
            // dateRestore
            // 
            this.dateRestore.EditValue = null;
            this.dateRestore.Location = new System.Drawing.Point(397, 32);
            this.dateRestore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateRestore.MenuManager = this.barManager1;
            this.dateRestore.Name = "dateRestore";
            this.dateRestore.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateRestore.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateRestore.Size = new System.Drawing.Size(189, 22);
            this.dateRestore.TabIndex = 68;
            // 
            // timeRestore
            // 
            this.timeRestore.EditValue = new System.DateTime(2021, 3, 26, 0, 0, 0, 0);
            this.timeRestore.Location = new System.Drawing.Point(621, 28);
            this.timeRestore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timeRestore.MenuManager = this.barManager1;
            this.timeRestore.Name = "timeRestore";
            this.timeRestore.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeRestore.Size = new System.Drawing.Size(191, 24);
            this.timeRestore.TabIndex = 69;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 77);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(955, 59);
            this.textBox1.TabIndex = 58;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Ngày giờ để phục hồi tại thời điểm đó:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 571);
            this.Controls.Add(this.pnCheckLoaiRestore);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.OrderBackupGridControl);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.DatabasesGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatabasesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsOrderBackup)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderBackupGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnCheckLoaiRestore.ResumeLayout(false);
            this.pnCheckLoaiRestore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateRestore.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateRestore.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeRestore.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnSaoLuu;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarCheckItem CheckboxPhucHoiTheoThoiGian;
        private DevExpress.XtraBars.BarButtonItem btnTaoThietBi;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private System.Windows.Forms.BindingSource bdsDatabase;
        private DS DS;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DSTableAdapters.DatabasesTableAdapter DatabasesTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel dBNAMEToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox txbNameDatabase;
        private DevExpress.XtraGrid.GridControl DatabasesGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private System.Windows.Forms.BindingSource bdsOrderBackup;
        private DSTableAdapters.Order_BackupTableAdapter OrderBackupTableAdapter;
        private DevExpress.XtraGrid.GridControl OrderBackupGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private System.Windows.Forms.ToolStripTextBox txbListBackup;
        private System.Windows.Forms.Panel pnCheckLoaiRestore;
        private DevExpress.XtraEditors.DateEdit dateRestore;
        private DevExpress.XtraEditors.TimeEdit timeRestore;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox checkSaoluu;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}