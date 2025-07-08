using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using TourismManageApp.UserGUI;

namespace TourismManageApp
{
    public partial class FrmLogin : Form

    {

        FrmLoginBLL bll = new FrmLoginBLL();

        public string TaiKhoan { get; private set; }

        public int maNV;
        public string tenNV;
        public FrmLogin()
        {
            InitializeComponent();
            txtMatKhau.PasswordChar = '\u25CF';
        }

       

        private void guna2CustomCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CustomCheckBox1.Checked)
            {
                txtMatKhau.PasswordChar = '\0';
            }

            else
                txtMatKhau.PasswordChar = '\u25CF';
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (guna2CustomCheckBox1.Checked)
            {
                txtMatKhau.PasswordChar = '\0';
            }

            else
                txtMatKhau.PasswordChar = '\u25CF';
        }

        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            TaiKhoan = txtTaiKhoan.Text;

            string loggedInTaiKhoan = txtTaiKhoan.Text;
            string taiKhoan = txtTaiKhoan.Text;
            string matKhau = txtMatKhau.Text;

            bool dangNhapThanhCong = bll.checkDangNhap(taiKhoan, matKhau);

            if (dangNhapThanhCong)
            {
                int quyen = bll.LayQuyen(taiKhoan);
                bll.SetTenDangNhap(taiKhoan);
                if (quyen == 1)
                {
                    // Mở form admin
                    maNV = bll.LayMaNV(taiKhoan);
                    tenNV = bll.LayTenNV(taiKhoan);
                    FrmAdmin formAdmin = new FrmAdmin(maNV, tenNV);
                    formAdmin.Show();
                    this.Hide();
                }
                else if (quyen == 2)
                {
                    maNV = bll.LayMaNV(taiKhoan);
                    tenNV = bll.LayTenNV(taiKhoan);
                    // Mở form user
                    FrmMain2 frmuser = new FrmMain2(maNV, tenNV);
                    frmuser.Show();
                    this.Hide();
                }
                
            }
           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
