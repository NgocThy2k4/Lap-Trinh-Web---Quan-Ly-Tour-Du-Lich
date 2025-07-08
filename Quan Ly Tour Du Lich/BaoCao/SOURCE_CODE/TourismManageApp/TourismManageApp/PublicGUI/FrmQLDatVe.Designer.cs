namespace TourismManageApp.PublicGUI
{
    partial class FrmQLDatVe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grbLocKQ = new System.Windows.Forms.GroupBox();
            this.btnHuyDat = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnTimMaHD = new Guna.UI2.WinForms.Guna2CircleButton();
            this.txtMaTour = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaDatTour = new Guna.UI2.WinForms.Guna2TextBox();
            this.btlLocKQ = new Guna.UI2.WinForms.Guna2GradientButton();
            this.dtpNgayLap = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblNgayDi = new System.Windows.Forms.Label();
            this.lblDiemDi = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTinhTrangVe = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtGVDatVe = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnThanhToan = new Guna.UI2.WinForms.Guna2GradientButton();
            this.grbLocKQ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVDatVe)).BeginInit();
            this.SuspendLayout();
            // 
            // grbLocKQ
            // 
            this.grbLocKQ.Controls.Add(this.btnThanhToan);
            this.grbLocKQ.Controls.Add(this.btnHuyDat);
            this.grbLocKQ.Controls.Add(this.btnTimMaHD);
            this.grbLocKQ.Controls.Add(this.txtMaTour);
            this.grbLocKQ.Controls.Add(this.label1);
            this.grbLocKQ.Controls.Add(this.txtMaDatTour);
            this.grbLocKQ.Controls.Add(this.btlLocKQ);
            this.grbLocKQ.Controls.Add(this.dtpNgayLap);
            this.grbLocKQ.Controls.Add(this.lblNgayDi);
            this.grbLocKQ.Controls.Add(this.lblDiemDi);
            this.grbLocKQ.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbLocKQ.ForeColor = System.Drawing.Color.MidnightBlue;
            this.grbLocKQ.Location = new System.Drawing.Point(6, 69);
            this.grbLocKQ.Name = "grbLocKQ";
            this.grbLocKQ.Size = new System.Drawing.Size(390, 761);
            this.grbLocKQ.TabIndex = 123;
            this.grbLocKQ.TabStop = false;
            this.grbLocKQ.Text = "Tìm vé đã đặt";
            // 
            // btnHuyDat
            // 
            this.btnHuyDat.BorderRadius = 10;
            this.btnHuyDat.CheckedState.Parent = this.btnHuyDat;
            this.btnHuyDat.CustomImages.Parent = this.btnHuyDat;
            this.btnHuyDat.FillColor = System.Drawing.Color.Navy;
            this.btnHuyDat.FillColor2 = System.Drawing.Color.Gray;
            this.btnHuyDat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyDat.ForeColor = System.Drawing.Color.White;
            this.btnHuyDat.HoverState.Parent = this.btnHuyDat;
            this.btnHuyDat.Location = new System.Drawing.Point(187, 399);
            this.btnHuyDat.Name = "btnHuyDat";
            this.btnHuyDat.ShadowDecoration.Parent = this.btnHuyDat;
            this.btnHuyDat.Size = new System.Drawing.Size(121, 37);
            this.btnHuyDat.TabIndex = 236;
            this.btnHuyDat.Text = "Hủy đặt tour";
            this.btnHuyDat.Click += new System.EventHandler(this.btnHuyDat_Click);
            // 
            // btnTimMaHD
            // 
            this.btnTimMaHD.BackColor = System.Drawing.Color.White;
            this.btnTimMaHD.BorderThickness = 1;
            this.btnTimMaHD.CheckedState.Parent = this.btnTimMaHD;
            this.btnTimMaHD.CustomImages.Parent = this.btnTimMaHD;
            this.btnTimMaHD.FillColor = System.Drawing.Color.White;
            this.btnTimMaHD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTimMaHD.ForeColor = System.Drawing.Color.White;
            this.btnTimMaHD.HoverState.Parent = this.btnTimMaHD;
            this.btnTimMaHD.Image = global::TourismManageApp.Properties.Resources.Search1;
            this.btnTimMaHD.Location = new System.Drawing.Point(315, 111);
            this.btnTimMaHD.Name = "btnTimMaHD";
            this.btnTimMaHD.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnTimMaHD.ShadowDecoration.Parent = this.btnTimMaHD;
            this.btnTimMaHD.Size = new System.Drawing.Size(37, 37);
            this.btnTimMaHD.TabIndex = 235;
            this.btnTimMaHD.Click += new System.EventHandler(this.btnTimMaHD_Click);
            // 
            // txtMaTour
            // 
            this.txtMaTour.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.txtMaTour.BorderRadius = 7;
            this.txtMaTour.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaTour.DefaultText = "";
            this.txtMaTour.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaTour.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaTour.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaTour.DisabledState.Parent = this.txtMaTour;
            this.txtMaTour.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaTour.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaTour.FocusedState.Parent = this.txtMaTour;
            this.txtMaTour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaTour.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaTour.HoverState.Parent = this.txtMaTour;
            this.txtMaTour.Location = new System.Drawing.Point(23, 206);
            this.txtMaTour.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMaTour.Name = "txtMaTour";
            this.txtMaTour.PasswordChar = '\0';
            this.txtMaTour.PlaceholderText = "";
            this.txtMaTour.SelectedText = "";
            this.txtMaTour.ShadowDecoration.Parent = this.txtMaTour;
            this.txtMaTour.Size = new System.Drawing.Size(283, 36);
            this.txtMaTour.TabIndex = 234;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 233;
            this.label1.Text = "Mã tour";
            // 
            // txtMaDatTour
            // 
            this.txtMaDatTour.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.txtMaDatTour.BorderRadius = 7;
            this.txtMaDatTour.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaDatTour.DefaultText = "";
            this.txtMaDatTour.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaDatTour.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaDatTour.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaDatTour.DisabledState.Parent = this.txtMaDatTour;
            this.txtMaDatTour.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaDatTour.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaDatTour.FocusedState.Parent = this.txtMaDatTour;
            this.txtMaDatTour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaDatTour.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaDatTour.HoverState.Parent = this.txtMaDatTour;
            this.txtMaDatTour.Location = new System.Drawing.Point(25, 111);
            this.txtMaDatTour.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMaDatTour.Name = "txtMaDatTour";
            this.txtMaDatTour.PasswordChar = '\0';
            this.txtMaDatTour.PlaceholderText = "";
            this.txtMaDatTour.SelectedText = "";
            this.txtMaDatTour.ShadowDecoration.Parent = this.txtMaDatTour;
            this.txtMaDatTour.Size = new System.Drawing.Size(283, 36);
            this.txtMaDatTour.TabIndex = 127;
            // 
            // btlLocKQ
            // 
            this.btlLocKQ.BorderRadius = 10;
            this.btlLocKQ.CheckedState.Parent = this.btlLocKQ;
            this.btlLocKQ.CustomImages.Parent = this.btlLocKQ;
            this.btlLocKQ.FillColor = System.Drawing.Color.Navy;
            this.btlLocKQ.FillColor2 = System.Drawing.Color.Gray;
            this.btlLocKQ.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlLocKQ.ForeColor = System.Drawing.Color.White;
            this.btlLocKQ.HoverState.Parent = this.btlLocKQ;
            this.btlLocKQ.Location = new System.Drawing.Point(28, 399);
            this.btlLocKQ.Name = "btlLocKQ";
            this.btlLocKQ.ShadowDecoration.Parent = this.btlLocKQ;
            this.btlLocKQ.Size = new System.Drawing.Size(121, 37);
            this.btlLocKQ.TabIndex = 26;
            this.btlLocKQ.Text = "Lọc kết quả";
            this.btlLocKQ.Click += new System.EventHandler(this.btlLocKQ_Click);
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.BorderRadius = 7;
            this.dtpNgayLap.Checked = true;
            this.dtpNgayLap.CheckedState.Parent = this.dtpNgayLap;
            this.dtpNgayLap.FillColor = System.Drawing.Color.LightGray;
            this.dtpNgayLap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayLap.HoverState.Parent = this.dtpNgayLap;
            this.dtpNgayLap.Location = new System.Drawing.Point(25, 285);
            this.dtpNgayLap.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayLap.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.ShadowDecoration.Parent = this.dtpNgayLap;
            this.dtpNgayLap.Size = new System.Drawing.Size(283, 36);
            this.dtpNgayLap.TabIndex = 12;
            this.dtpNgayLap.Value = new System.DateTime(2022, 1, 1, 14, 38, 19, 504);
            // 
            // lblNgayDi
            // 
            this.lblNgayDi.AutoSize = true;
            this.lblNgayDi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayDi.Location = new System.Drawing.Point(24, 261);
            this.lblNgayDi.Name = "lblNgayDi";
            this.lblNgayDi.Size = new System.Drawing.Size(80, 21);
            this.lblNgayDi.TabIndex = 11;
            this.lblNgayDi.Text = "Ngày đặt";
            // 
            // lblDiemDi
            // 
            this.lblDiemDi.AutoSize = true;
            this.lblDiemDi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiemDi.Location = new System.Drawing.Point(24, 71);
            this.lblDiemDi.Name = "lblDiemDi";
            this.lblDiemDi.Size = new System.Drawing.Size(56, 21);
            this.lblDiemDi.TabIndex = 2;
            this.lblDiemDi.Text = "Mã vé";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(435, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 21);
            this.label5.TabIndex = 126;
            this.label5.Text = "Tình trạng đặt tour:";
            // 
            // cmbTinhTrangVe
            // 
            this.cmbTinhTrangVe.BackColor = System.Drawing.Color.Transparent;
            this.cmbTinhTrangVe.BorderRadius = 7;
            this.cmbTinhTrangVe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTinhTrangVe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTinhTrangVe.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTinhTrangVe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTinhTrangVe.FocusedState.Parent = this.cmbTinhTrangVe;
            this.cmbTinhTrangVe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTinhTrangVe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbTinhTrangVe.HoverState.Parent = this.cmbTinhTrangVe;
            this.cmbTinhTrangVe.ItemHeight = 30;
            this.cmbTinhTrangVe.ItemsAppearance.Parent = this.cmbTinhTrangVe;
            this.cmbTinhTrangVe.Location = new System.Drawing.Point(430, 29);
            this.cmbTinhTrangVe.Name = "cmbTinhTrangVe";
            this.cmbTinhTrangVe.ShadowDecoration.Parent = this.cmbTinhTrangVe;
            this.cmbTinhTrangVe.Size = new System.Drawing.Size(291, 36);
            this.cmbTinhTrangVe.TabIndex = 125;
            this.cmbTinhTrangVe.SelectedIndexChanged += new System.EventHandler(this.cmbTinhTrangVe_SelectedIndexChanged);
            // 
            // dtGVDatVe
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.dtGVDatVe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dtGVDatVe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGVDatVe.BackgroundColor = System.Drawing.Color.White;
            this.dtGVDatVe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGVDatVe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtGVDatVe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGVDatVe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dtGVDatVe.ColumnHeadersHeight = 4;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGVDatVe.DefaultCellStyle = dataGridViewCellStyle11;
            this.dtGVDatVe.EnableHeadersVisualStyles = false;
            this.dtGVDatVe.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtGVDatVe.Location = new System.Drawing.Point(402, 80);
            this.dtGVDatVe.Name = "dtGVDatVe";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGVDatVe.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dtGVDatVe.RowHeadersVisible = false;
            this.dtGVDatVe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGVDatVe.Size = new System.Drawing.Size(1034, 788);
            this.dtGVDatVe.TabIndex = 124;
            this.dtGVDatVe.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dtGVDatVe.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtGVDatVe.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtGVDatVe.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtGVDatVe.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtGVDatVe.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtGVDatVe.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtGVDatVe.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtGVDatVe.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtGVDatVe.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtGVDatVe.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtGVDatVe.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtGVDatVe.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtGVDatVe.ThemeStyle.HeaderStyle.Height = 4;
            this.dtGVDatVe.ThemeStyle.ReadOnly = false;
            this.dtGVDatVe.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtGVDatVe.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtGVDatVe.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtGVDatVe.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dtGVDatVe.ThemeStyle.RowsStyle.Height = 22;
            this.dtGVDatVe.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtGVDatVe.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtGVDatVe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGVDatVe_CellClick);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BorderRadius = 10;
            this.btnThanhToan.CheckedState.Parent = this.btnThanhToan;
            this.btnThanhToan.CustomImages.Parent = this.btnThanhToan;
            this.btnThanhToan.FillColor = System.Drawing.Color.Navy;
            this.btnThanhToan.FillColor2 = System.Drawing.Color.Gray;
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.HoverState.Parent = this.btnThanhToan;
            this.btnThanhToan.Location = new System.Drawing.Point(100, 482);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.ShadowDecoration.Parent = this.btnThanhToan;
            this.btnThanhToan.Size = new System.Drawing.Size(121, 37);
            this.btnThanhToan.TabIndex = 237;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // FrmQLDatVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 862);
            this.Controls.Add(this.grbLocKQ);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbTinhTrangVe);
            this.Controls.Add(this.dtGVDatVe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmQLDatVe";
            this.Text = "FrmQLDatVe";
            this.Load += new System.EventHandler(this.FrmQLDatVe_Load);
            this.grbLocKQ.ResumeLayout(false);
            this.grbLocKQ.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVDatVe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbLocKQ;
        private Guna.UI2.WinForms.Guna2CircleButton btnTimMaHD;
        private Guna.UI2.WinForms.Guna2TextBox txtMaTour;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtMaDatTour;
        private Guna.UI2.WinForms.Guna2GradientButton btlLocKQ;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayLap;
        private System.Windows.Forms.Label lblNgayDi;
        private System.Windows.Forms.Label lblDiemDi;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTinhTrangVe;
        private Guna.UI2.WinForms.Guna2DataGridView dtGVDatVe;
        private Guna.UI2.WinForms.Guna2GradientButton btnHuyDat;
        private Guna.UI2.WinForms.Guna2GradientButton btnThanhToan;
    }
}