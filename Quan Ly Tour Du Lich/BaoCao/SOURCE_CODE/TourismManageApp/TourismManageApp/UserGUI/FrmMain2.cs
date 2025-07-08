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
namespace TourismManageApp.UserGUI
{
    public partial class FrmMain2 : Form
    {
        TourismManageAppBLLDataContext sql = new TourismManageAppBLLDataContext();
        public int maNV;
        public string tenNV;
        public FrmMain2(int ma, string ten)
        {
            InitializeComponent();
            maNV = ma;
            tenNV = ten;
            OpenChildForm(new FrmDashboard());
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
        private void btn_Tour_Click(object sender, EventArgs e)
        {

        }

        private void btn_TraCuu_Click(object sender, EventArgs e)
        {
            FrmSearch frmSearch = new FrmSearch();
            frmSearch.Show();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            btn_Home.Top = ((Control)sender).Top;
            OpenChildForm(new FrmDashboard());

        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            btn_Customer.Top = ((Control)sender).Top;
            OpenChildForm(new FrmKhachHang());
        }

        private void btn_Tick_Click(object sender, EventArgs e)
        {
            btn_Tick.Top = ((Control)sender).Top;
            OpenChildForm(new FrmDatVe());
        }

        private void btn_Chart_Click(object sender, EventArgs e)
        {
            btn_Chart.Top = ((Control)sender).Top;
            OpenChildForm(new FrmDashboard());
        }

        private void btn_Bell_Click(object sender, EventArgs e)
        {
            btn_Bell.Top = ((Control)sender).Top;
            OpenChildForm(new FrmThongBao());
        }

        private void btn_Pay_Click(object sender, EventArgs e)
        {
            btn_Pay.Top = ((Control)sender).Top;
            OpenChildForm(new FrmThanhToan());
        }

        private void btn_Setting_Click(object sender, EventArgs e)
        {
            btn_Setting.Top = ((Control)sender).Top;
            OpenChildForm(new FrmCaiDat());
        }

        private void btn_Out_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất không?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                this.Close();
                FrmLogin lg = new FrmLogin();
                lg.Show();

            }
        }
    }
}
