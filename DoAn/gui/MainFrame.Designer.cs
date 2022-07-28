
namespace DoAn.gui
{
    partial class MainFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongTinNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNCC = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongTinNCC = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThemNCC = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongTinKH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThemKH = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblGioiThieu = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolbtnLamMoi = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnRight = new System.Windows.Forms.Panel();
            this.lblgt = new System.Windows.Forms.Label();
            this.picSilde4 = new System.Windows.Forms.PictureBox();
            this.picSilde3 = new System.Windows.Forms.PictureBox();
            this.picSilde2 = new System.Windows.Forms.PictureBox();
            this.picSlide1 = new System.Windows.Forms.PictureBox();
            this.pnLeft = new System.Windows.Forms.Panel();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNhapSach = new System.Windows.Forms.Button();
            this.btnHDBan = new System.Windows.Forms.Button();
            this.btnThongTinSach = new System.Windows.Forms.Button();
            this.btnTrangChu = new System.Windows.Forms.Button();
            this.pnNVDangNhap = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.lblNVDangNhap = new System.Windows.Forms.Label();
            this.picANHNVDangNhap = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.progress = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.userBaoCao1 = new DoAn.gui.userBaoCao();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSilde4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSilde3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSilde2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSlide1)).BeginInit();
            this.pnLeft.SuspendLayout();
            this.pnNVDangNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picANHNVDangNhap)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHeThong,
            this.mnuNhanVien,
            this.mnuNCC,
            this.mnuKH});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1150, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuHeThong
            // 
            this.mnuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDangXuat,
            this.mnuThoat});
            this.mnuHeThong.Name = "mnuHeThong";
            this.mnuHeThong.Size = new System.Drawing.Size(71, 20);
            this.mnuHeThong.Text = "Hệ Thống";
            // 
            // mnuDangXuat
            // 
            this.mnuDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("mnuDangXuat.Image")));
            this.mnuDangXuat.Name = "mnuDangXuat";
            this.mnuDangXuat.Size = new System.Drawing.Size(128, 22);
            this.mnuDangXuat.Text = "Đăng xuất";
            this.mnuDangXuat.Click += new System.EventHandler(this.mnuDangXuat_Click);
            // 
            // mnuThoat
            // 
            this.mnuThoat.Image = ((System.Drawing.Image)(resources.GetObject("mnuThoat.Image")));
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(128, 22);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // mnuNhanVien
            // 
            this.mnuNhanVien.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThongTinNhanVien,
            this.mnuDoiMatKhau});
            this.mnuNhanVien.Name = "mnuNhanVien";
            this.mnuNhanVien.Size = new System.Drawing.Size(73, 20);
            this.mnuNhanVien.Text = "Nhân viên";
            // 
            // mnuThongTinNhanVien
            // 
            this.mnuThongTinNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("mnuThongTinNhanVien.Image")));
            this.mnuThongTinNhanVien.Name = "mnuThongTinNhanVien";
            this.mnuThongTinNhanVien.Size = new System.Drawing.Size(180, 22);
            this.mnuThongTinNhanVien.Text = "Thông tin nhân viên";
            this.mnuThongTinNhanVien.Click += new System.EventHandler(this.mnuThongTinNhanVien_Click);
            // 
            // mnuDoiMatKhau
            // 
            this.mnuDoiMatKhau.Image = ((System.Drawing.Image)(resources.GetObject("mnuDoiMatKhau.Image")));
            this.mnuDoiMatKhau.Name = "mnuDoiMatKhau";
            this.mnuDoiMatKhau.Size = new System.Drawing.Size(180, 22);
            this.mnuDoiMatKhau.Text = "Đổi mật khẩu";
            this.mnuDoiMatKhau.Click += new System.EventHandler(this.mnuDoiMatKhau_Click);
            // 
            // mnuNCC
            // 
            this.mnuNCC.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThongTinNCC,
            this.mnuThemNCC});
            this.mnuNCC.Name = "mnuNCC";
            this.mnuNCC.Size = new System.Drawing.Size(93, 20);
            this.mnuNCC.Text = "Nhà cung cấp";
            // 
            // mnuThongTinNCC
            // 
            this.mnuThongTinNCC.Image = ((System.Drawing.Image)(resources.GetObject("mnuThongTinNCC.Image")));
            this.mnuThongTinNCC.Name = "mnuThongTinNCC";
            this.mnuThongTinNCC.Size = new System.Drawing.Size(200, 22);
            this.mnuThongTinNCC.Text = "Thông tin nhà cung cấp";
            this.mnuThongTinNCC.Click += new System.EventHandler(this.mnuThongTinNCC_Click);
            // 
            // mnuThemNCC
            // 
            this.mnuThemNCC.Image = ((System.Drawing.Image)(resources.GetObject("mnuThemNCC.Image")));
            this.mnuThemNCC.Name = "mnuThemNCC";
            this.mnuThemNCC.Size = new System.Drawing.Size(200, 22);
            this.mnuThemNCC.Text = "Thêm nhà cung cấp";
            this.mnuThemNCC.Click += new System.EventHandler(this.mnuThemNCC_Click);
            // 
            // mnuKH
            // 
            this.mnuKH.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThongTinKH,
            this.mnuThemKH});
            this.mnuKH.Name = "mnuKH";
            this.mnuKH.Size = new System.Drawing.Size(82, 20);
            this.mnuKH.Text = "Khách hàng";
            // 
            // mnuThongTinKH
            // 
            this.mnuThongTinKH.Image = ((System.Drawing.Image)(resources.GetObject("mnuThongTinKH.Image")));
            this.mnuThongTinKH.Name = "mnuThongTinKH";
            this.mnuThongTinKH.Size = new System.Drawing.Size(190, 22);
            this.mnuThongTinKH.Text = "Thông tin khách hàng";
            this.mnuThongTinKH.Click += new System.EventHandler(this.mnuThongTinKH_Click);
            // 
            // mnuThemKH
            // 
            this.mnuThemKH.Image = ((System.Drawing.Image)(resources.GetObject("mnuThemKH.Image")));
            this.mnuThemKH.Name = "mnuThemKH";
            this.mnuThemKH.Size = new System.Drawing.Size(190, 22);
            this.mnuThemKH.Text = "Thêm khách hàng";
            this.mnuThemKH.Click += new System.EventHandler(this.mnuThemKH_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblGioiThieu);
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1150, 33);
            this.panel2.TabIndex = 3;
            // 
            // lblGioiThieu
            // 
            this.lblGioiThieu.AutoSize = true;
            this.lblGioiThieu.BackColor = System.Drawing.Color.Transparent;
            this.lblGioiThieu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiThieu.Location = new System.Drawing.Point(43, 6);
            this.lblGioiThieu.Name = "lblGioiThieu";
            this.lblGioiThieu.Size = new System.Drawing.Size(151, 19);
            this.lblGioiThieu.TabIndex = 0;
            this.lblGioiThieu.Text = "Xin chào tất cả các bạn";
            this.lblGioiThieu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbtnLamMoi,
            this.toolStripSeparator4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1148, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolbtnLamMoi
            // 
            this.toolbtnLamMoi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbtnLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnLamMoi.Image")));
            this.toolbtnLamMoi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnLamMoi.Name = "toolbtnLamMoi";
            this.toolbtnLamMoi.Size = new System.Drawing.Size(24, 28);
            this.toolbtnLamMoi.Text = "Làm mới";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 31);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.pnRight);
            this.panel1.Controls.Add(this.pnLeft);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 57);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1150, 716);
            this.panel1.TabIndex = 4;
            // 
            // pnRight
            // 
            this.pnRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnRight.Controls.Add(this.lblgt);
            this.pnRight.Controls.Add(this.picSilde4);
            this.pnRight.Controls.Add(this.picSilde3);
            this.pnRight.Controls.Add(this.picSilde2);
            this.pnRight.Controls.Add(this.picSlide1);
            this.pnRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnRight.Location = new System.Drawing.Point(260, 0);
            this.pnRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnRight.Name = "pnRight";
            this.pnRight.Size = new System.Drawing.Size(890, 716);
            this.pnRight.TabIndex = 1;
            this.pnRight.Paint += new System.Windows.Forms.PaintEventHandler(this.pnRight_Paint);
            // 
            // lblgt
            // 
            this.lblgt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblgt.Font = new System.Drawing.Font("Vladimir Script", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblgt.Location = new System.Drawing.Point(26, 46);
            this.lblgt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblgt.Name = "lblgt";
            this.lblgt.Size = new System.Drawing.Size(836, 108);
            this.lblgt.TabIndex = 4;
            this.lblgt.Text = "Welcome to BookStore";
            this.lblgt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picSilde4
            // 
            this.picSilde4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.picSilde4.Image = global::DoAn.Properties.Resources.carouse03;
            this.picSilde4.Location = new System.Drawing.Point(28, 188);
            this.picSilde4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picSilde4.Name = "picSilde4";
            this.picSilde4.Size = new System.Drawing.Size(839, 465);
            this.picSilde4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSilde4.TabIndex = 3;
            this.picSilde4.TabStop = false;
            // 
            // picSilde3
            // 
            this.picSilde3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.picSilde3.Image = global::DoAn.Properties.Resources.unnamed;
            this.picSilde3.Location = new System.Drawing.Point(28, 189);
            this.picSilde3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picSilde3.Name = "picSilde3";
            this.picSilde3.Size = new System.Drawing.Size(839, 465);
            this.picSilde3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSilde3.TabIndex = 2;
            this.picSilde3.TabStop = false;
            // 
            // picSilde2
            // 
            this.picSilde2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.picSilde2.Image = global::DoAn.Properties.Resources.banner_hoi_sach;
            this.picSilde2.Location = new System.Drawing.Point(28, 189);
            this.picSilde2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picSilde2.Name = "picSilde2";
            this.picSilde2.Size = new System.Drawing.Size(839, 465);
            this.picSilde2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSilde2.TabIndex = 1;
            this.picSilde2.TabStop = false;
            // 
            // picSlide1
            // 
            this.picSlide1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.picSlide1.Image = global::DoAn.Properties.Resources.banner_201806;
            this.picSlide1.Location = new System.Drawing.Point(27, 189);
            this.picSlide1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picSlide1.Name = "picSlide1";
            this.picSlide1.Size = new System.Drawing.Size(840, 465);
            this.picSlide1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSlide1.TabIndex = 0;
            this.picSlide1.TabStop = false;
            // 
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.Color.Aqua;
            this.pnLeft.Controls.Add(this.btnBaoCao);
            this.pnLeft.Controls.Add(this.button1);
            this.pnLeft.Controls.Add(this.btnNhapSach);
            this.pnLeft.Controls.Add(this.btnHDBan);
            this.pnLeft.Controls.Add(this.btnThongTinSach);
            this.pnLeft.Controls.Add(this.btnTrangChu);
            this.pnLeft.Controls.Add(this.pnNVDangNhap);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnLeft.Location = new System.Drawing.Point(0, 0);
            this.pnLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(260, 716);
            this.pnLeft.TabIndex = 0;
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Image = ((System.Drawing.Image)(resources.GetObject("btnBaoCao.Image")));
            this.btnBaoCao.Location = new System.Drawing.Point(1, 648);
            this.btnBaoCao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(264, 54);
            this.btnBaoCao.TabIndex = 2;
            this.btnBaoCao.Text = "BÁO CÁO";
            this.btnBaoCao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBaoCao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 508);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 54);
            this.button1.TabIndex = 2;
            this.button1.Text = "HÓA ĐƠN NHẬP";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnHDNhap_Click);
            // 
            // btnNhapSach
            // 
            this.btnNhapSach.Image = ((System.Drawing.Image)(resources.GetObject("btnNhapSach.Image")));
            this.btnNhapSach.Location = new System.Drawing.Point(0, 578);
            this.btnNhapSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNhapSach.Name = "btnNhapSach";
            this.btnNhapSach.Size = new System.Drawing.Size(264, 54);
            this.btnNhapSach.TabIndex = 2;
            this.btnNhapSach.Text = "NHẬP SÁCH";
            this.btnNhapSach.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhapSach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhapSach.UseVisualStyleBackColor = true;
            this.btnNhapSach.Click += new System.EventHandler(this.btnNhapSach_Click);
            // 
            // btnHDBan
            // 
            this.btnHDBan.Image = ((System.Drawing.Image)(resources.GetObject("btnHDBan.Image")));
            this.btnHDBan.Location = new System.Drawing.Point(0, 436);
            this.btnHDBan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHDBan.Name = "btnHDBan";
            this.btnHDBan.Size = new System.Drawing.Size(264, 54);
            this.btnHDBan.TabIndex = 2;
            this.btnHDBan.Text = "HÓA ĐƠN BÁN";
            this.btnHDBan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHDBan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHDBan.UseVisualStyleBackColor = true;
            this.btnHDBan.Click += new System.EventHandler(this.btnHDBan_Click);
            // 
            // btnThongTinSach
            // 
            this.btnThongTinSach.Image = ((System.Drawing.Image)(resources.GetObject("btnThongTinSach.Image")));
            this.btnThongTinSach.Location = new System.Drawing.Point(1, 340);
            this.btnThongTinSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThongTinSach.Name = "btnThongTinSach";
            this.btnThongTinSach.Size = new System.Drawing.Size(264, 54);
            this.btnThongTinSach.TabIndex = 1;
            this.btnThongTinSach.Text = "THÔNG TIN SÁCH";
            this.btnThongTinSach.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThongTinSach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongTinSach.UseVisualStyleBackColor = true;
            this.btnThongTinSach.Click += new System.EventHandler(this.btnThongTinSach_Click);
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.Image = ((System.Drawing.Image)(resources.GetObject("btnTrangChu.Image")));
            this.btnTrangChu.Location = new System.Drawing.Point(0, 267);
            this.btnTrangChu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(264, 54);
            this.btnTrangChu.TabIndex = 1;
            this.btnTrangChu.Text = "TRANG CHỦ";
            this.btnTrangChu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTrangChu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTrangChu.UseVisualStyleBackColor = true;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // pnNVDangNhap
            // 
            this.pnNVDangNhap.BackColor = System.Drawing.Color.Aqua;
            this.pnNVDangNhap.Controls.Add(this.btnDangXuat);
            this.pnNVDangNhap.Controls.Add(this.lblNVDangNhap);
            this.pnNVDangNhap.Controls.Add(this.picANHNVDangNhap);
            this.pnNVDangNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnNVDangNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnNVDangNhap.Location = new System.Drawing.Point(0, 0);
            this.pnNVDangNhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnNVDangNhap.Name = "pnNVDangNhap";
            this.pnNVDangNhap.Size = new System.Drawing.Size(260, 232);
            this.pnNVDangNhap.TabIndex = 0;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.Image")));
            this.btnDangXuat.Location = new System.Drawing.Point(64, 189);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(136, 34);
            this.btnDangXuat.TabIndex = 2;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // lblNVDangNhap
            // 
            this.lblNVDangNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNVDangNhap.ForeColor = System.Drawing.Color.Red;
            this.lblNVDangNhap.Location = new System.Drawing.Point(43, 156);
            this.lblNVDangNhap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNVDangNhap.Name = "lblNVDangNhap";
            this.lblNVDangNhap.Size = new System.Drawing.Size(180, 28);
            this.lblNVDangNhap.TabIndex = 1;
            this.lblNVDangNhap.Text = "HỌ VÀ TÊN NHÂN VIÊN";
            this.lblNVDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picANHNVDangNhap
            // 
            this.picANHNVDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.picANHNVDangNhap.Location = new System.Drawing.Point(64, 14);
            this.picANHNVDangNhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picANHNVDangNhap.Name = "picANHNVDangNhap";
            this.picANHNVDangNhap.Size = new System.Drawing.Size(136, 135);
            this.picANHNVDangNhap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picANHNVDangNhap.TabIndex = 0;
            this.picANHNVDangNhap.TabStop = false;
            this.picANHNVDangNhap.Click += new System.EventHandler(this.picANHNVDangNhap_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.progress,
            this.toolStripLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 748);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1150, 25);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(42, 20);
            this.toolStripStatusLabel1.Text = "Status:";
            // 
            // progress
            // 
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(235, 19);
            // 
            // toolStripLabel
            // 
            this.toolStripLabel.Name = "toolStripLabel";
            this.toolStripLabel.Size = new System.Drawing.Size(0, 20);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // userBaoCao1
            // 
            this.userBaoCao1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.userBaoCao1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userBaoCao1.Location = new System.Drawing.Point(0, 0);
            this.userBaoCao1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userBaoCao1.Name = "userBaoCao1";
            this.userBaoCao1.Size = new System.Drawing.Size(1188, 881);
            this.userBaoCao1.TabIndex = 0;
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 773);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainFrame";
            this.Text = "MainFrame";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFrame_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSilde4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSilde3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSilde2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSlide1)).EndInit();
            this.pnLeft.ResumeLayout(false);
            this.pnNVDangNhap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picANHNVDangNhap)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuThongTinNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuDoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem mnuNCC;
        private System.Windows.Forms.ToolStripMenuItem mnuThongTinNCC;
        private System.Windows.Forms.ToolStripMenuItem mnuThemNCC;
        private System.Windows.Forms.ToolStripMenuItem mnuKH;
        private System.Windows.Forms.ToolStripMenuItem mnuThongTinKH;
        private System.Windows.Forms.ToolStripMenuItem mnuThemKH;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblGioiThieu;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolbtnLamMoi;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnRight;
        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.Panel pnNVDangNhap;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Label lblNVDangNhap;
        private System.Windows.Forms.PictureBox picANHNVDangNhap;
        private System.Windows.Forms.Button btnThongTinSach;
        private System.Windows.Forms.Button btnTrangChu;
        private System.Windows.Forms.Button btnNhapSach;
        private System.Windows.Forms.Button btnHDBan;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;

        private userBaoCao userBaoCao1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar progress;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLabel;
        private System.Windows.Forms.PictureBox picSlide1;
        private System.Windows.Forms.PictureBox picSilde4;
        private System.Windows.Forms.PictureBox picSilde3;
        private System.Windows.Forms.PictureBox picSilde2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblgt;
    }
}