
namespace TourismManageApp
{
    partial class FrmCaiDat
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
            this.label1 = new System.Windows.Forms.Label();
            this.tourismManageAppDataSet = new TourismManageApp.TourismManageAppDataSet();
            this.nguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nguoiDungTableAdapter = new TourismManageApp.TourismManageAppDataSetTableAdapters.NguoiDungTableAdapter();
            this.tableAdapterManager = new TourismManageApp.TourismManageAppDataSetTableAdapters.TableAdapterManager();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThayDoi = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnXacNhanMK = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMKMoi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMKHienTai = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tourismManageAppDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(719, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "CÀI ĐẶT";
            // 
            // tourismManageAppDataSet
            // 
            this.tourismManageAppDataSet.DataSetName = "TourismManageAppDataSet";
            this.tourismManageAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nguoiDungBindingSource
            // 
            this.nguoiDungBindingSource.DataMember = "NguoiDung";
            this.nguoiDungBindingSource.DataSource = this.tourismManageAppDataSet;
            // 
            // nguoiDungTableAdapter
            // 
            this.nguoiDungTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DaiDienKHTableAdapter = null;
            this.tableAdapterManager.DatTourTableAdapter = null;
            this.tableAdapterManager.DichVuTableAdapter = null;
            this.tableAdapterManager.HopDongTableAdapter = null;
            this.tableAdapterManager.KhachSanTableAdapter = null;
            this.tableAdapterManager.NganHangTableAdapter = null;
            this.tableAdapterManager.NguoiDungTableAdapter = this.nguoiDungTableAdapter;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhanQuyenTableAdapter = null;
            this.tableAdapterManager.PhuongTienTableAdapter = null;
            this.tableAdapterManager.ThanhToanTableAdapter = null;
            this.tableAdapterManager.TinhTrangDatTourTableAdapter = null;
            this.tableAdapterManager.TinhTrangTourTableAdapter = null;
            this.tableAdapterManager.TourTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TourismManageApp.TourismManageAppDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThayDoi);
            this.groupBox2.Controls.Add(this.btnXacNhanMK);
            this.groupBox2.Controls.Add(this.txtMKMoi);
            this.groupBox2.Controls.Add(this.txtMKHienTai);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox2.Location = new System.Drawing.Point(560, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 485);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thay đổi mật khẩu";
            // 
            // btnThayDoi
            // 
            this.btnThayDoi.BorderRadius = 7;
            this.btnThayDoi.CheckedState.Parent = this.btnThayDoi;
            this.btnThayDoi.CustomImages.Parent = this.btnThayDoi;
            this.btnThayDoi.FillColor = System.Drawing.Color.Navy;
            this.btnThayDoi.FillColor2 = System.Drawing.Color.Gray;
            this.btnThayDoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThayDoi.ForeColor = System.Drawing.Color.White;
            this.btnThayDoi.HoverState.Parent = this.btnThayDoi;
            this.btnThayDoi.Location = new System.Drawing.Point(168, 357);
            this.btnThayDoi.Name = "btnThayDoi";
            this.btnThayDoi.ShadowDecoration.Parent = this.btnThayDoi;
            this.btnThayDoi.Size = new System.Drawing.Size(123, 53);
            this.btnThayDoi.TabIndex = 116;
            this.btnThayDoi.Text = "Thay đổi";
            this.btnThayDoi.Click += new System.EventHandler(this.btnThayDoi_Click_1);
            // 
            // btnXacNhanMK
            // 
            this.btnXacNhanMK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnXacNhanMK.DefaultText = "";
            this.btnXacNhanMK.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnXacNhanMK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.btnXacNhanMK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.btnXacNhanMK.DisabledState.Parent = this.btnXacNhanMK;
            this.btnXacNhanMK.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.btnXacNhanMK.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnXacNhanMK.FocusedState.Parent = this.btnXacNhanMK;
            this.btnXacNhanMK.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnXacNhanMK.HoverState.Parent = this.btnXacNhanMK;
            this.btnXacNhanMK.Location = new System.Drawing.Point(36, 290);
            this.btnXacNhanMK.Name = "btnXacNhanMK";
            this.btnXacNhanMK.PasswordChar = '\0';
            this.btnXacNhanMK.PlaceholderText = "";
            this.btnXacNhanMK.SelectedText = "";
            this.btnXacNhanMK.ShadowDecoration.Parent = this.btnXacNhanMK;
            this.btnXacNhanMK.Size = new System.Drawing.Size(369, 36);
            this.btnXacNhanMK.TabIndex = 5;
            // 
            // txtMKMoi
            // 
            this.txtMKMoi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMKMoi.DefaultText = "";
            this.txtMKMoi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMKMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMKMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMKMoi.DisabledState.Parent = this.txtMKMoi;
            this.txtMKMoi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMKMoi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMKMoi.FocusedState.Parent = this.txtMKMoi;
            this.txtMKMoi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMKMoi.HoverState.Parent = this.txtMKMoi;
            this.txtMKMoi.Location = new System.Drawing.Point(36, 206);
            this.txtMKMoi.Name = "txtMKMoi";
            this.txtMKMoi.PasswordChar = '\0';
            this.txtMKMoi.PlaceholderText = "";
            this.txtMKMoi.SelectedText = "";
            this.txtMKMoi.ShadowDecoration.Parent = this.txtMKMoi;
            this.txtMKMoi.Size = new System.Drawing.Size(369, 36);
            this.txtMKMoi.TabIndex = 4;
            // 
            // txtMKHienTai
            // 
            this.txtMKHienTai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMKHienTai.DefaultText = "";
            this.txtMKHienTai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMKHienTai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMKHienTai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMKHienTai.DisabledState.Parent = this.txtMKHienTai;
            this.txtMKHienTai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMKHienTai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMKHienTai.FocusedState.Parent = this.txtMKHienTai;
            this.txtMKHienTai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMKHienTai.HoverState.Parent = this.txtMKHienTai;
            this.txtMKHienTai.Location = new System.Drawing.Point(36, 122);
            this.txtMKHienTai.Name = "txtMKHienTai";
            this.txtMKHienTai.PasswordChar = '\0';
            this.txtMKHienTai.PlaceholderText = "";
            this.txtMKHienTai.SelectedText = "";
            this.txtMKHienTai.ShadowDecoration.Parent = this.txtMKHienTai;
            this.txtMKHienTai.Size = new System.Drawing.Size(369, 36);
            this.txtMKHienTai.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(58, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(220, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "Xác nhận mật khẩu mới";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(58, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 25);
            this.label10.TabIndex = 1;
            this.label10.Text = "Mật khẩu mới";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(58, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(166, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "Mật khẩu hiện tại";
            // 
            // FrmCaiDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 862);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCaiDat";
            this.Text = "Cài Đặt";
            this.Load += new System.EventHandler(this.FrmCaiDat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tourismManageAppDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private TourismManageAppDataSet tourismManageAppDataSet;
        private System.Windows.Forms.BindingSource nguoiDungBindingSource;
        private TourismManageAppDataSetTableAdapters.NguoiDungTableAdapter nguoiDungTableAdapter;
        private TourismManageAppDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2GradientButton btnThayDoi;
        private Guna.UI2.WinForms.Guna2TextBox btnXacNhanMK;
        private Guna.UI2.WinForms.Guna2TextBox txtMKMoi;
        private Guna.UI2.WinForms.Guna2TextBox txtMKHienTai;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}