using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BLL;
namespace TourismManageApp.UserGUI
{
    public partial class FrmDashboard : Form
    {
        TourismManageAppBLLDataContext db = new TourismManageAppBLLDataContext();
        public Tour tour1 = new Tour();
    
        FrmDashBroadBLL dashBroadBLL = new FrmDashBroadBLL();
        public FrmDashboard()
        {
            InitializeComponent();
         
        }
        private Image GetImage(object imageData)
        {
            if (imageData != null && imageData != DBNull.Value)
            {
                System.Data.Linq.Binary binaryImage = (System.Data.Linq.Binary)imageData;
                byte[] imageBytes = binaryImage.ToArray();
                MemoryStream ms = new MemoryStream(imageBytes);
                return Image.FromStream(ms);
            }

            return null; // hoặc một hình ảnh mặc định khác
        }
        public void tourBanChay()
        {
            var tourDatNhieuNhat = db.Tours.OrderByDescending(t => t.SoNguoiDat).FirstOrDefault();

            picHinh1.Image = GetImage(tourDatNhieuNhat.Hinh1);
            lblMaTour.Text = tourDatNhieuNhat.MaTour.ToString();
            lblTenTour.Text = tourDatNhieuNhat.TenTour;
            lblMoTa.Text = tourDatNhieuNhat.MoTa;
            lblGiaTour.Text = tourDatNhieuNhat.Gia.ToString()+ "đ/khách";
        }
        private void getDoanhThuNam()
        {
            chartRevenue.Series.Clear();
            chartRevenue.Series.Add("Doanh thu");
            HopDong HopDong = new HopDong();
            HopDong.NgayKyHD = new DateTime(Convert.ToInt32(cmbYear.Text), 1, 1); // Gán ngày đầu tiên của năm

            var dataTable = dashBroadBLL.ThongKe_DoanhThu_Nam(HopDong).AsEnumerable();

            var doanhThuData = dataTable.Select(row => new
            {
                Thang = row.Field<int>("Tháng"),
                ThanhTien = row.Field<decimal>("Thành tiền")
            });

            chartRevenue.DataSource = doanhThuData.ToList();
            chartRevenue.ChartAreas[0].AxisX.Interval = 1;
            chartRevenue.ChartAreas[0].AxisY.Interval = 1500000;
            chartRevenue.Series[0].XValueMember = "Thang";
            chartRevenue.Series[0].YValueMembers = "ThanhTien";
            chartRevenue.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            chartRevenue.Series.Add("Doanh thu2");
            chartRevenue.Series[1].XValueMember = "Thang";
            chartRevenue.Series[1].YValueMembers = "ThanhTien";
            chartRevenue.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartRevenue.ChartAreas[0].AxisX.LineColor = Color.Gray;
            chartRevenue.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Transparent;
            chartRevenue.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.Black;
            chartRevenue.Series[0].Palette = ChartColorPalette.Fire;
            chartRevenue.Series[1].Palette = ChartColorPalette.Fire;
            chartRevenue.Series[1].BorderWidth = 3;
            chartRevenue.ChartAreas[0].AxisY.LineColor = Color.Gray;
            chartRevenue.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Gray;
            chartRevenue.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.Black;
        }


        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            chartRevenue.Series.Clear();
            chartRevenue.Series.Add("Doanh thu");

            HopDong Hd = new HopDong();
            Hd.NgayKyHD = new DateTime(2023, 1, 1);

            var doanhThuData = dashBroadBLL.ThongKe_DoanhThu_Nam(Hd).AsEnumerable();

            chartRevenue.DataSource = doanhThuData.ToList();
            chartRevenue.ChartAreas[0].AxisX.Interval = 1;
            chartRevenue.ChartAreas[0].AxisY.Interval = 1500000;
            chartRevenue.Series[0].XValueMember = "Tháng";
            chartRevenue.Series[0].YValueMembers = "Thành tiền";
            chartRevenue.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            chartRevenue.Series.Add("Doanh thu2");
            chartRevenue.Series[1].XValueMember = "Tháng";
            chartRevenue.Series[1].YValueMembers = "Thành tiền";
            chartRevenue.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartRevenue.ChartAreas[0].AxisX.LineColor = Color.Gray;
            chartRevenue.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Transparent;
            chartRevenue.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.Black;
            chartRevenue.Series[0].Palette = ChartColorPalette.Fire;
            chartRevenue.Series[1].Palette = ChartColorPalette.Fire;
            chartRevenue.Series[1].BorderWidth = 3;
            chartRevenue.ChartAreas[0].AxisY.LineColor = Color.Gray;
            chartRevenue.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Gray;
            chartRevenue.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.Black;

            tourBanChay();

            cmbYear.Items.Add("-- Chọn năm --");
            cmbYear.SelectedIndex = 0;
            for (int a = 2021; a < 2024; a++)
            {
                cmbYear.Items.Add(a);
            }
            cmbYear.Text = "2023";

        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cmbYear.SelectedIndex != 0))
            {
                getDoanhThuNam();
            }
        }
    }
}
