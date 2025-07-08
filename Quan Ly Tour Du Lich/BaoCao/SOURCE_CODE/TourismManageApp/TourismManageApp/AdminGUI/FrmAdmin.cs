using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourismManageApp.AdminGUI;
using TourismManageApp.UserGUI;
using TourismManageApp.PublicGUI;
using BLL;

namespace TourismManageApp
{
    public partial class FrmAdmin : Form
    {
        FrmMainBLL tour = new FrmMainBLL();
       
        public int maNV;
   
        public string tenNV;
        public FrmAdmin(int ma,string ten)
        {
            maNV = ma;
            tenNV = ten;    
            InitializeComponent();
           
            tour.CapNhapTrangThaiChung();
            label2.Text = "Chào "+tenNV;
           
        }
        private Form currentformchild;
     
        public void OpenChildForm(Form child)
        {
            if (currentformchild != null)
                currentformchild.Close();
            currentformchild = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            bunifuPanel_child.Controls.Add(child);
            bunifuPanel_child.Width = child.Width;

            bunifuPanel_child.BringToFront();
            child.Show();
        }
        private void btn_Customer_Click(object sender, EventArgs e)
        {
         
            OpenChildForm(new FrmThemTour());
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            tour.CapNhapTrangThaiChung();
        }

        private void btn_Tick_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmQLNhanVien());
        }

        private void btn_TraCuu_Click(object sender, EventArgs e)
        {
          
            OpenChildForm(new PublicGUI.FrmDatTour(maNV));
        }

        private void btn_Bell_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmQLTTKhachHang());
        }

        private void btn_Setting_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmCaiDat());
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmDashboard());
        }

        private void btn_Chart_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmQLTaiKhoan());
        }

        private void btn_Pay_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmQLHopDong());
        }

        private void btn_PhanCong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmQLDatVe(maNV));
        }

        private void btn_Out_Click(object sender, EventArgs e)
        {
            FrmLogin lg = new FrmLogin ();
            this.Hide();
            lg.Show();
        }
    }
}
