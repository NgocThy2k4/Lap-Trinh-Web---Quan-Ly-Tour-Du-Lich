using BLL;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourismManageApp.AdminGUI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace TourismManageApp.PublicGUI
{
    public partial class FrmDatTour : Form
    {
        FrmTaoTourBLL tao = new FrmTaoTourBLL();
        FrmDatTourBLL dat =     new FrmDatTourBLL();    
        public Tour tourDaChon = new Tour();
        public DatTour newDatTour = new DatTour();
        public int maNV;
        public FrmDatTour(int ma)
        {
            maNV = ma;
            InitializeComponent();
            btlDatTour.Enabled= false;
       
        }
        public void loadCot()
        {
            dgvTour.Columns[0].HeaderText = "Mã tour";
            dgvTour.Columns[1].HeaderText = "Tên tour";
            dgvTour.Columns[2].HeaderText = "Số ghế";
            dgvTour.Columns[3].HeaderText = "Ngày đi";
            dgvTour.Columns[4].HeaderText = "Ngày về";
            dgvTour.Columns[5].HeaderText = "Giá";
            


        }
        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void btnNgoaiNuoc_Click(object sender, EventArgs e)
        {

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
        TourismManageAppBLLDataContext db = new TourismManageAppBLLDataContext();
        private void dgvTour_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
               
                int maTour = Convert.ToInt32(dgvTour.SelectedRows[0].Cells[0].Value);
               
                // Sử dụng LINQ để lấy thông tin tour từ cơ sở dữ liệu
                var selectedTour = db.Tours.FirstOrDefault(t => t.MaTour == maTour);
                tourDaChon = selectedTour;
                if (selectedTour != null)
                {
                    lblTenTour.Text = selectedTour.TenTour;
                   
                    lblMoTa.Text = selectedTour.MoTa;
                   
                    lblGiaTour.Text = string.Format("{0:#,##0}", selectedTour.Gia) + "/Khách";
                  
                    // Nếu có hình, bạn có thể kiểm tra không null trước khi hiển thị
                    if (selectedTour.Hinh1 != null)
                        picHinh1.Image = GetImage(selectedTour.Hinh1);
                    if (selectedTour.Hinh2 != null)
                        picHinh2.Image = GetImage(selectedTour.Hinh2);
                    if (selectedTour.Hinh3 != null)
                        picHinh3.Image = GetImage(selectedTour.Hinh3);
                    if (selectedTour.Hinh4 != null)
                        picHinh4.Image = GetImage(selectedTour.Hinh4);

                    lblTGKH.Text = selectedTour.NgayDi.ToString();
                    dtpNgayDi.Value = selectedTour.NgayDi.Value;
                   
                    lblNoiKH.Text = selectedTour.DiemKhoiHanh;
                 
                    DateTime ngayDi = selectedTour.NgayDi ?? DateTime.MinValue; // Sử dụng DateTime.MinValue nếu NgayDi là null
                    DateTime ngayVe = selectedTour.NgayVe ?? DateTime.MinValue; // Sử dụng DateTime.MinValue nếu NgayVe là null

                    TimeSpan timeSpan = ngayVe.Subtract(ngayDi);

                    int soNgay = (int)timeSpan.TotalDays;

                    lblSoNgay.Text = soNgay.ToString() + " ngày";
                    int soGhe = selectedTour.SoGhe ?? 0; // Sử dụng 0 nếu SoGhe là null
                    int soNguoiDat = selectedTour.SoNguoiDat ?? 0; // Sử dụng 0 nếu SoNguoiDat là null

                    int soLuongConLai = soGhe - soNguoiDat;
                    lblSlot.Text = soLuongConLai.ToString();
                    if(soLuongConLai ==0)
                    {
                        btlDatTour.Enabled = false;
                    }
                    int SoDem = soNgay - 1;
                    lblTGnho.Text = lblSoNgay.Text + " " + SoDem + " đêm";
                    var phuongTien = selectedTour.PhuongTien;
                 
                    if (phuongTien != null)
                    {
                        lblPT.Text = phuongTien.LoaiPhuongTien;
                    }
                    else
                    {
                        lblPT.Text = "Không xác định"; // Hoặc giá trị mặc định nếu không có thông tin về phương tiện.
                    }
                    int maDiaDiem = selectedTour.MaDiaDiem ?? 0; // Sử dụng 0 nếu MaDiaDiem là null

                    var diaDiem = db.DiaDiems.FirstOrDefault(dd => dd.MaDiaDiem == maDiaDiem);
               
                    if (diaDiem != null)
                    {
                        label2.Text = diaDiem.TenDiaDiem;
                    }
                    else
                    {
                        label2.Text = "Không xác định"; // Hoặc bất kỳ giá trị mặc định nào bạn muốn hiển thị khi không tìm thấy địa điểm.
                    }






                    var loaiKhachSan = selectedTour.LoaiKhachSan;
              
                    if (loaiKhachSan != null)
                    {
                        lblKS.Text = loaiKhachSan.TenLoaiKS;
                    }
                    else
                    {
                        lblKS.Text = "Không xác định"; // Hoặc giá trị mặc định nếu không có thông tin về loại khách sạn.
                    }
                    lblMaTour.Text = selectedTour.MaTour.ToString();

                    if(selectedTour.TinhTrang=="Chưa diễn ra")
                    {
                        btlDatTour.Enabled = true;
                    }
                    else
                    {
                        btlDatTour.Enabled = false; 
                    }

                    DataGridViewRow row = dgvTour.Rows[e.RowIndex];

                    // Lấy thông tin từ row và hiển thị lên các control tương ứng
                    txtDiemKhoiHanh.Text =selectedTour.DiemKhoiHanh;
                    cmbDiemDen.SelectedValue = selectedTour.MaDiaDiem;
                    dtpNgayDi.Value = selectedTour.NgayDi.Value;
                    cmbPhuongTien.SelectedValue = selectedTour.MaPT;
                }
            }
        }

        private void FrmDatTour_Load(object sender, EventArgs e)
        {
            dgvTour.DataSource = tao.layDSTour();
            cmbDiemDen.DataSource = tao.layDiaDiem();
            cmbDiemDen.DisplayMember = "TenDiaDiem";
            cmbDiemDen.ValueMember = "MaDiaDiem";


            cmbPhuongTien.DataSource = tao.layDSPT();
            cmbPhuongTien.DisplayMember = "LoaiPhuongTien";
            cmbPhuongTien.ValueMember = "MaPT";
            loadCot();
            dgvTour.RowTemplate.Height = 40;
            dgvTour.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvTour.ColumnHeadersHeight = 40;
        }

        private void btlLocKQ_Click(object sender, EventArgs e)
        {
            string diemKhoiHanh = txtDiemKhoiHanh.Text;
            int maDiaDiem = Convert.ToInt32(cmbDiemDen.SelectedValue);
            DateTime ngayDi = dtpNgayDi.Value;
            int maPhuongTien = Convert.ToInt32(cmbPhuongTien.SelectedValue);
            dgvTour.DataSource = dat.timTour(diemKhoiHanh, maDiaDiem, ngayDi, maPhuongTien);
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            dgvTour.DataSource = tao.layDSTour();
        }
        
        
        private void btlDatTour_Click(object sender, EventArgs e)
        {
            try
            {
                int maTour = tourDaChon.MaTour;
                DateTime ngayLap = DateTime.Now;
                DatTour datTour = new DatTour
                {
                    NgayLap = ngayLap,
                    MaKH = null,
                    SLNguoiLon = null,
                    SLTreEm = null,
                    MaTour = maTour,
                   
                    TinhTrang = "Đang xử lý"
                };
                db.DatTours.InsertOnSubmit(datTour);
                db.SubmitChanges();
                newDatTour = datTour;


                FrmThongTinDatTour fr = new FrmThongTinDatTour(tourDaChon,newDatTour,maNV);
                FrmAdmin trangChu = (FrmAdmin)this.ParentForm;
                trangChu.OpenChildForm(fr);
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
            
        }
    }
}
