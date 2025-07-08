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
namespace TourismManageApp.PublicGUI
{
    public partial class FrmQLHopDong : Form
    {
        TourismManageAppBLLDataContext db = new TourismManageAppBLLDataContext();   
        public FrmQLHopDong()
        {
            InitializeComponent();
            loaddata();
            dtGVHopDong.RowTemplate.Height = 40;
            dtGVHopDong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtGVHopDong.ColumnHeadersHeight = 40;
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
        public void loaddata()
        {
            var list = from hd in db.HopDongs
                       select new
                       {
                           hd.MaHD,
                           hd.TenHD,
                           hd.MaDatTour,
                           hd.NgayKyHD,
                           hd.MaNV,
                           hd.MaTT,
                           hd.TongTien
                       };
            dtGVHopDong.DataSource = list;
        }
    }
}
