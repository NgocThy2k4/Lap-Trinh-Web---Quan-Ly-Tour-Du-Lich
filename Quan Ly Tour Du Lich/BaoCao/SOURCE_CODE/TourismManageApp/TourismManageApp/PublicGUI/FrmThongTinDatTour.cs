using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using TourismManageApp.AdminGUI;
namespace TourismManageApp.PublicGUI
{
    public partial class FrmThongTinDatTour : Form
    {
        public Tour tourDaChon = new Tour();
        public DatTour newDatTour = new DatTour();
        FrmThongTinDatTourBLL tt = new FrmThongTinDatTourBLL();
        public int maNV;
        
        public FrmThongTinDatTour(Tour tour, DatTour datTour,int ma)
        {
            maNV = ma;
            tourDaChon = tour;
            newDatTour = datTour;
            InitializeComponent();
            loadData();
        }
        public void loadData()
        {
            lblMaTour.Text = tourDaChon.MaTour.ToString();
            lbMaDatTour.Text = newDatTour.MaDatTour.ToString();
            lblDateBatDauChuyenDi.Text = tourDaChon.NgayDi.ToString();
            lblDateKetThucChuyenDi.Text = tourDaChon.NgayVe.ToString();
            lblTenTour.Text = tourDaChon.TenTour;
            lblNoiKH.Text = tourDaChon.DiaDiem.TenDiaDiem;
            lblTGKH.Text = tourDaChon.GioKhoiHanh;
            label5.Text = tourDaChon.TenTour;
            lblNgayTaoHD.Text = newDatTour.NgayLap.ToString();
            picAnh1.Image = GetImage(tourDaChon.Hinh1);
            picAnh1N.Image = GetImage(tourDaChon.Hinh1);
            int soGhe = tourDaChon.SoGhe ?? 0; // Sử dụng 0 nếu SoGhe là null
            int soNguoiDat = tourDaChon.SoNguoiDat ?? 0; // Sử dụng 0 nếu SoNguoiDat là null

            int soLuongConLai = soGhe - soNguoiDat;

            lblSlot.Text = soLuongConLai.ToString();
            lblGiaTour.Text = tourDaChon.Gia.ToString();

            var tenNV = (from nv in db.NhanViens
                        where nv.MaNV == maNV
                        select nv.TenNV).SingleOrDefault();

            lbTenNV.Text = tenNV;
            dtpNgayLap.Value = DateTime.Now;
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
        private void FrmThongTinDatTour_Load(object sender, EventArgs e)
        {
            dgvTTKH.DataSource = tt.loadKH();
            cmbTT.DataSource = tt.loadThanhToan();
            cmbTT.DisplayMember = "TenTT";
            cmbTT.ValueMember = "MaTT";
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        TourismManageAppBLLDataContext db = new TourismManageAppBLLDataContext();
        private void dgvTTKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {

                int maKH = Convert.ToInt32(dgvTTKH.SelectedRows[0].Cells[0].Value);

                // Sử dụng LINQ để lấy thông tin tour từ cơ sở dữ liệu
                var selectedKH = db.DaiDienKHs.FirstOrDefault(t => t.MaKH == maKH);

                if (selectedKH != null)
                {
                    lblTenKH.Text = selectedKH.TenKH;
                    txtHoTen.Text = selectedKH.TenKH;
                    txtDiaChi.Text = selectedKH.DiaChi;
                    txtSDT.Text = selectedKH.Sdt;

                }
            }
        }

        private void btnTaoKH_Click(object sender, EventArgs e)
        {
            DaiDienKH kh = new DaiDienKH();
            kh.TenKH = txtHoTen.Text;
            kh.Sdt = txtSDT.Text;
            kh.DiaChi = txtDiaChi.Text;
            try
            {
                tt.taoKH(kh);

                dgvTTKH.DataSource = tt.loadKH();
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            dgvTTKH.DataSource = tt.loadKH();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            tt.loadKHTheoSTD(txtSDT.Text);
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
   
          
                int maKH = Convert.ToInt32(dgvTTKH.SelectedRows[0].Cells[0].Value);
                var datTourToUpdate = db.DatTours.FirstOrDefault(t => t.MaDatTour == newDatTour.MaDatTour);

               
                     datTourToUpdate.MaKH = maKH;
                     datTourToUpdate.NgayLap = dtpNgayLap.Value;
                     datTourToUpdate.TinhTrang = "Đã đặt";
                     datTourToUpdate.SLNguoiLon = Convert.ToInt32(numSLNgLon.Value);
                     datTourToUpdate.SLTreEm = Convert.ToInt32(numSLTreEm.Value);
                    
                HopDong hd = new HopDong();
                hd.TenHD = "Hợp đồng " + lblTenTour.Text + " của khách hàng" + lblTenKH.Text;
                hd.NgayKyHD = DateTime.Now;
                
                hd.MaNV = maNV;
                hd.MaDatTour = newDatTour.MaDatTour;
                hd.MaTT = int.Parse(cmbTT.SelectedValue.ToString());
                hd.TongTien = decimal.Parse(lblTongCong.Text);
                hd.NgayKyHD = dtpNgayLap.Value;
                HopDong newhd = new HopDong()
                {
                    TenHD = hd.TenHD,
                    NgayKyHD = hd.NgayKyHD,
                    MaNV = hd.MaNV,
                    MaDatTour = hd.MaDatTour,
                    MaTT = hd.MaTT,
                    TongTien = hd.TongTien,
                   
                };
            db.HopDongs.InsertOnSubmit(newhd);
            db.SubmitChanges();
            var tourDaChonToUpdate = db.Tours.FirstOrDefault(t => t.MaTour == tourDaChon.MaTour);
               tourDaChonToUpdate.SoNguoiDat = tourDaChonToUpdate.SoNguoiDat - int.Parse(lblSLTong.Text);
            




            MessageBox.Show("Hoàn tất đặt tour");
                FrmDatTour fr = new FrmDatTour( maNV);
                FrmAdmin trangChu = (FrmAdmin)this.ParentForm;
                trangChu.OpenChildForm(fr);
         


        }
        private void CapNhatTongCong()
        {
            // Lấy giá trị từ các numeric và label
            decimal giaTour = decimal.Parse(lblGiaTour.Text);
            decimal slNgLon = numSLNgLon.Value;
            decimal slTreEm = numSLTreEm.Value;

            // Tính toán tổng công
            decimal tongCong = (giaTour * slNgLon) + ((giaTour * slTreEm) * (80 / 100));

            // Cập nhật giá trị của lblTongCong
            lblTongCong.Text = tongCong.ToString();
            lblGiaNL.Text = (giaTour * slNgLon).ToString() + "đ";
            lblGiaTE.Text = ((giaTour * slTreEm) * ((decimal)80 / 100)).ToString() + "đ";
            lblSLTong.Text = (slNgLon+ slTreEm).ToString();
        }

        private void numSLNgLon_ValueChanged(object sender, EventArgs e)
        {
            CapNhatTongCong();
            KiemTraGioiHan();
        }

        private void numSLTreEm_ValueChanged(object sender, EventArgs e)
        {
            CapNhatTongCong();
            KiemTraGioiHan();
        }
        private void KiemTraGioiHan()
        {
            decimal tongSL = numSLNgLon.Value + numSLTreEm.Value;
            decimal lblSlotValue = decimal.Parse(lblSlot.Text);

            if (tongSL > lblSlotValue)
            {

                if (numSLNgLon.Value > lblSlotValue)
                {
                    numSLNgLon.Value = lblSlotValue;
                }

                if (numSLTreEm.Value > lblSlotValue - numSLNgLon.Value)
                {
                    numSLTreEm.Value = lblSlotValue - numSLNgLon.Value;
                }
            }
        }
    }
}
