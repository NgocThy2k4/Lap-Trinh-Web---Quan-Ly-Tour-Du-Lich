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
using BLL;
namespace TourismManageApp.AdminGUI
{
    public partial class FrmThemTour : Form
    {
        FrmMainBLL tour = new FrmMainBLL();
        public FrmThemTour()
        {
            InitializeComponent();
          
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

        FrmTaoTourBLL tao = new FrmTaoTourBLL();

        Tour Tour = new Tour();
        string imgLocation1, imgLocation2, imgLocation3, imgLocation4;

        private void btnHinh4_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png|*.png|jpeg|*.jpg|bmp|*.bmp|all files|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation4 = dialog.FileName.ToString();
                picHinh4.ImageLocation = imgLocation4;
            }
        }

        private void btnHinh3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png|*.png|jpeg|*.jpg|bmp|*.bmp|all files|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation3 = dialog.FileName.ToString();
                picHinh3.ImageLocation = imgLocation3;
            }
        }

        private void btnHinh2_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png|*.png|jpeg|*.jpg|bmp|*.bmp|all files|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation2 = dialog.FileName.ToString();
                picHinh2.ImageLocation = imgLocation2;
            }
        }

        private void btnAnh1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png|*.png|jpeg|*.jpg|bmp|*.bmp|all files|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation1 = dialog.FileName.ToString();
                picHinh1.ImageLocation = imgLocation1;
            }
        }
        void ResetBox()
        {
            txtTenTour.Clear();
            txtMoTa.Clear();
            numSL.Value = 0;
            dtpNgayDi.Value = DateTime.Now;
            dtpNgayKT.Value = DateTime.Now;
            txtGioKhoiHanh.Clear();
            cmbPT.SelectedIndex = 0;
            txtDiemKhoiHanh.Clear();
            cmbKS.SelectedIndex = 0;
            txtGiaTour.Clear();
        }

        void OpenBox()
        {
            txtTenTour.ReadOnly = false;
            txtMoTa.ReadOnly = false;
            numSL.Enabled = true;
            dtpNgayDi.Enabled = true;
            dtpNgayKT.Enabled = true;
            txtGioKhoiHanh.Enabled = true;
            cmbPT.Enabled = true;
            txtDiemKhoiHanh.Enabled = true;
            cmbDDen.Enabled = true;
            cmbKS.Enabled = true;
            txtGiaTour.Enabled = true;
            btnAnh1.Enabled = true;
            btnHinh2.Enabled = true;
            btnHinh3.Enabled = true;
            btnHinh4.Enabled = true;
        }

        void CloseBox()
        {
            txtTenTour.ReadOnly = true;
            txtMoTa.ReadOnly = true;
            numSL.Enabled = false;
            dtpNgayDi.Enabled = false;
            dtpNgayKT.Enabled = false;
            txtGioKhoiHanh.Enabled = false;
            cmbPT.Enabled = false;
            txtDiemKhoiHanh.Enabled = false;
            cmbKS.Enabled = false;
            cmbDDen.Enabled = false;
            txtGiaTour.Enabled = false;
            btnAnh1.Enabled = false;
            btnHinh2.Enabled = false;
            btnHinh3.Enabled = false;
            btnHinh4.Enabled = false;
        }

        bool checkThemSua = false;
        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetBox();
            ResetInf();
            OpenBox();
            checkThemSua = true;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnTroVe.Enabled = true;
            txtMaTour.Enabled = false;
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
           
            if (checkThemSua == true)
            {
                if (checkData())
                {


                    
                    Tour.TenTour = txtTenTour.Text;
                    Tour.MoTa = txtMoTa.Text;
                    Tour.SoGhe = Convert.ToInt32(numSL.Value);
                    Tour.NgayDi = Convert.ToDateTime(dtpNgayDi.Text);
                    Tour.NgayVe = Convert.ToDateTime(dtpNgayKT.Value);

                    byte[] images1 = null;
                    FileStream Stream1 = new FileStream(imgLocation1, FileMode.Open, FileAccess.Read);
                    BinaryReader brs1 = new BinaryReader(Stream1);
                    images1 = brs1.ReadBytes((int)Stream1.Length);

                    byte[] images2 = null;
                    FileStream Stream2 = new FileStream(imgLocation2, FileMode.Open, FileAccess.Read);
                    BinaryReader brs2 = new BinaryReader(Stream2);
                    images2 = brs2.ReadBytes((int)Stream2.Length);

                    byte[] images3 = null;
                    FileStream Stream3 = new FileStream(imgLocation3, FileMode.Open, FileAccess.Read);
                    BinaryReader brs3 = new BinaryReader(Stream3);
                    images3 = brs3.ReadBytes((int)Stream3.Length);

                    byte[] images4 = null;
                    FileStream Stream4 = new FileStream(imgLocation4, FileMode.Open, FileAccess.Read);
                    BinaryReader brs4 = new BinaryReader(Stream4);
                    images4 = brs4.ReadBytes((int)Stream4.Length);
                    Tour.Hinh1 = images1;
                    Tour.Hinh2 = images2;
                    Tour.Hinh3 = images3;
                    Tour.Hinh4 = images4;
                    Tour.Gia = Convert.ToDecimal(txtGiaTour.Text);
                    Tour.GioKhoiHanh = txtGioKhoiHanh.Text;
                    Tour.MaPT = int.Parse(cmbPT.SelectedValue.ToString());
                    Tour.DiemKhoiHanh = txtDiemKhoiHanh.Text;
                    Tour.MaDiaDiem = int.Parse(cmbDDen.SelectedValue.ToString());
                    Tour.MaLoaiKS = int.Parse(cmbKS.SelectedValue.ToString());
                    Tour.TinhTrang = "Chưa diễn ra";
                    try
                    {
                        tao.themTour(Tour);
                        imgLocation1 = null;
                        imgLocation2 = null;
                        imgLocation3 = null;
                        imgLocation4 = null;
                        //ShowAllTour();
                        CloseBox();
                        MessageBox.Show("Nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnLuu.Enabled = false;
                        btnThem.Enabled = true;

                        activeForm = null;
                        lblSlot.Text = numSL.Value.ToString();
                        lblTGKH.Text = dtpNgayDi.Value.ToString();
                        lblSoNgay.Text = (dtpNgayKT.Value.Date - dtpNgayDi.Value.Date).ToString("dd") + " ngày";
                        lblTGnho.Text = (dtpNgayKT.Value.Date - dtpNgayDi.Value.Date).ToString("dd") + " ngày " + (Convert.ToInt32((dtpNgayKT.Value.Date - dtpNgayDi.Value.Date).ToString("dd")) - 1).ToString() + " đêm";
                        lblPT.Text = cmbPT.Text;
                        lblNoiKH.Text = txtDiemKhoiHanh.Text;
                        lblDiemDen.Text = cmbDDen.Text;
                        lblKS.Text = cmbKS.Text;
                        lblTenTour.Text = txtTenTour.Text;
                        lblMoTa.Text = txtMoTa.Text;
                        lblGiaTour.Text = string.Format("{0:#,##0}", decimal.Parse(txtGiaTour.Text.ToString())) + " đ/khách";

                        dgvTour.DataSource = tao.layDSTour();
                        txtMaTour.Enabled = true;
                        tour.CapNhapTrangThaiChung();
                    }



                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã có lỗi xảy ra, xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtTenTour.Focus();
                    }

                    

                }
                
            }
            if (checkThemSua == false)
            {

                if (checkData1())
                {
                    int maTour = int.Parse(txtMaTour.Text);

                    // Tìm tour cần sửa từ cơ sở dữ liệu
                    var tourToUpdate = db.Tours.FirstOrDefault(t => t.MaTour == maTour);

                    if (tourToUpdate != null)
                    {
                        tourToUpdate.TenTour = txtTenTour.Text;
                        tourToUpdate.MoTa = txtMoTa.Text;
                        tourToUpdate.SoGhe = Convert.ToInt32(numSL.Value);
                        tourToUpdate.NgayDi = Convert.ToDateTime(dtpNgayDi.Text);
                        tourToUpdate.NgayVe = Convert.ToDateTime(dtpNgayKT.Value);

                        // Cập nhật hình ảnh nếu có đường dẫn ảnh
                        if (imgLocation1 != null)
                        {
                            byte[] images1 = null;
                            FileStream Stream1 = new FileStream(imgLocation1, FileMode.Open, FileAccess.Read);
                            BinaryReader brs1 = new BinaryReader(Stream1);
                            images1 = brs1.ReadBytes((int)Stream1.Length);
                            tourToUpdate.Hinh1 = images1;
                        }
                        if (imgLocation1 == null)
                        {
                            MemoryStream ms1 = new MemoryStream();
                            picHinh1.Image.Save(ms1, picHinh1.Image.RawFormat);
                            pic1 = ms1.GetBuffer();
                            tourToUpdate.Hinh1 = pic1;
                        }

                        if (imgLocation2 != null)
                        {
                            byte[] images2 = null;
                            FileStream Stream2 = new FileStream(imgLocation2, FileMode.Open, FileAccess.Read);
                            BinaryReader brs2 = new BinaryReader(Stream2);
                            images2 = brs2.ReadBytes((int)Stream2.Length);
                            tourToUpdate.Hinh2 = images2;
                        }

                        if (imgLocation2 == null)
                        {
                            MemoryStream ms1 = new MemoryStream();
                            picHinh2.Image.Save(ms1, picHinh2.Image.RawFormat);
                            pic2 = ms1.GetBuffer();
                            tourToUpdate.Hinh2 = pic2;
                        }

                        if (imgLocation3 != null)
                        {
                            byte[] images3 = null;
                            FileStream Stream3 = new FileStream(imgLocation3, FileMode.Open, FileAccess.Read);
                            BinaryReader brs3 = new BinaryReader(Stream3);
                            images3 = brs3.ReadBytes((int)Stream3.Length);
                            tourToUpdate.Hinh3 = images3;
                        }
                        if (imgLocation3 == null)
                        {
                            MemoryStream ms1 = new MemoryStream();
                            picHinh3.Image.Save(ms1, picHinh3.Image.RawFormat);
                            pic3 = ms1.GetBuffer();
                            tourToUpdate.Hinh3 = pic3;
                        }


                        if (imgLocation4 != null)
                        {
                            byte[] images4 = null;
                            FileStream Stream4 = new FileStream(imgLocation4, FileMode.Open, FileAccess.Read);
                            BinaryReader brs4 = new BinaryReader(Stream4);
                            images4 = brs4.ReadBytes((int)Stream4.Length);
                            tourToUpdate.Hinh4 = images4;
                        }
                        if (imgLocation4 == null)
                        {
                            MemoryStream ms1 = new MemoryStream();
                            picHinh4.Image.Save(ms1, picHinh4.Image.RawFormat);
                            pic4 = ms1.GetBuffer();
                            tourToUpdate.Hinh4 = pic4;
                        }
                        int newMaPT = ((PhuongTien)cmbPT.SelectedItem).MaPT;
                        int newMaLoaiKS = ((LoaiKhachSan)cmbKS.SelectedItem).MaLoaiKS;


                        if (tourToUpdate.MaPT != newMaPT)
                        {
                            tourToUpdate.PhuongTien.MaPT = newMaPT;
                      
                        }
                        tourToUpdate.Gia = Convert.ToDecimal(txtGiaTour.Text);
                        tourToUpdate.GioKhoiHanh = txtGioKhoiHanh.Text;
                       
                        tourToUpdate.DiemKhoiHanh = txtDiemKhoiHanh.Text;
                        tourToUpdate.MaDiaDiem = int.Parse(cmbDDen.SelectedValue.ToString());

                        if (tourToUpdate.MaLoaiKS != newMaLoaiKS)
                        {
                            tourToUpdate.LoaiKhachSan.MaLoaiKS = newMaLoaiKS;

                        }
                        //tourToUpdate.MaLoaiKS = int.Parse(cmbKS.SelectedValue.ToString());

                        try
                        {
                            db.SubmitChanges();
                            imgLocation1 = null;
                            imgLocation2 = null;
                            imgLocation3 = null;
                            imgLocation4 = null;

                            dgvTour.DataSource = tao.layDSTour();
                            CloseBox();
                            MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnLuu.Enabled = false;
                            btnThem.Enabled = true;

                            lblSlot.Text = numSL.Value.ToString();
                            lblTGKH.Text = dtpNgayDi.Value.ToString();
                            lblSoNgay.Text = (dtpNgayKT.Value.Date - dtpNgayDi.Value.Date).ToString("dd") + " ngày";
                            lblTGnho.Text = (dtpNgayKT.Value.Date - dtpNgayDi.Value.Date).ToString("dd") + " ngày " + (Convert.ToInt32((dtpNgayKT.Value.Date - dtpNgayDi.Value.Date).ToString("dd")) - 1).ToString() + " đêm";
                            lblPT.Text = cmbPT.Text;
                            lblNoiKH.Text = txtDiemKhoiHanh.Text;
                            lblDiemDen.Text = cmbDDen.Text;
                            lblKS.Text = cmbKS.Text;
                            lblTenTour.Text = txtTenTour.Text;
                            lblMoTa.Text = txtMoTa.Text;
                            lblGiaTour.Text = string.Format("{0:#,##0}", decimal.Parse(txtGiaTour.Text.ToString())) + " đ/khách";
                            txtMaTour.Enabled = true;
                            tour.CapNhapTrangThaiChung();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Đã có lỗi xảy ra, xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            txtTenTour.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy tour cần sửa.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }
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
        private void loadClick()
        {

            Tour.MaTour = Convert.ToInt32(dgvTour.SelectedRows[0].Cells[0].Value);
            DataTable dataTable2 = new DataTable();
            //dataTable2 = bllTour.GetAllTour2(Tour);
            //txtMaTour.Text = dataTable2.Rows[0]["MATOUR"].ToString();
            //txtTenTour.Text = dataTable2.Rows[0]["TENTOUR"].ToString();
            //txtMoTa.Text = dataTable2.Rows[0]["MOTA"].ToString();
            //numSL.Value = Convert.ToDecimal(dataTable2.Rows[0]["SOLUONGCONLAI"]);
            //dtpNgayDi.Value = Convert.ToDateTime(dataTable2.Rows[0]["NGAYDITOUR"]);
            //dtpNgayKT.Value = Convert.ToDateTime(dataTable2.Rows[0]["NGAYKETTHUC"]);
            //cmbLoaiTour.SelectedValue = dataTable2.Rows[0]["MALTOUR"].ToString();
            //cmbPT.SelectedValue = dataTable2.Rows[0]["MAPT"].ToString();
            //cmbDiemDi.SelectedValue = dataTable2.Rows[0]["MADDI"].ToString();
            //cmbDDen.SelectedValue = dataTable2.Rows[0]["MADDEN"].ToString();
            //cmbKS.SelectedValue = dataTable2.Rows[0]["MALKS"].ToString();
            //txtGiaTour.Text = dataTable2.Rows[0]["GIATOUR"].ToString();
        }
        byte[] pic1, pic2, pic3, pic4;

        private void FrmThemTour_Load(object sender, EventArgs e)
        {
            cmbDDen.DataSource = tao.layDiaDiem();
            cmbDDen.DisplayMember = "TenDiaDiem";
            cmbDDen.ValueMember = "MaDiaDiem";

            cmbKS.DataSource = tao.layDSKS();
            cmbKS.DisplayMember = "TenLoaiKS";
            cmbKS.ValueMember = "MaLoaiKS";

            cmbPT.DataSource = tao.layDSPT();
            cmbPT.DisplayMember = "LoaiPhuongTien";
            cmbPT.ValueMember = "MaPT";

            dgvTour.DataSource = tao.layDSTour();
            loadCot();
            dgvTour.RowTemplate.Height = 40;
            dgvTour.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvTour.ColumnHeadersHeight = 40;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            OpenBox();
            txtMaTour.ReadOnly = true;
            checkThemSua = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnTroVe.Enabled = true;
            txtMaTour.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaTour.Text == "")
            {
                MessageBox.Show("Chưa chọn Tour", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            else
            {
                if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    Tour.MaTour = int.Parse(txtMaTour.Text);

                    try
                    {
                        tao.xoaTour(Tour.MaTour);
                        ResetInf();
                        ResetBox();
                        btnSua.Enabled = false;
                        btnXoa.Enabled = false;
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dgvTour.DataSource = tao.layDSTour();
                    }

                    catch
                    {
                        MessageBox.Show("Đã có lỗi xảy ra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }

                }
            }
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hủy thao tác??", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ResetInf();
                ResetBox();
                CloseBox();
                btnThem.Enabled = true;
                btnLuu.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnTroVe.Enabled = false;
            }
        }

        private void dgvTour_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        TourismManageAppBLLDataContext db = new TourismManageAppBLLDataContext();
        private void dtGVKhachSan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                CloseBox();

                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnLuu.Enabled = false;
                btnXoa.Enabled = true;
                loadClick();
                int maTour = Convert.ToInt32(dgvTour.SelectedRows[0].Cells[0].Value);
                txtMaTour.Text = maTour.ToString();
                // Sử dụng LINQ để lấy thông tin tour từ cơ sở dữ liệu
                var selectedTour = db.Tours.FirstOrDefault(t => t.MaTour == maTour);

                if (selectedTour != null)
                {
                    lblTenTour.Text = selectedTour.TenTour;
                    txtTenTour.Text = selectedTour.TenTour;
                    lblMoTa.Text = selectedTour.MoTa;
                    txtMoTa.Text = selectedTour.MoTa;
                    lblGiaTour.Text = string.Format("{0:#,##0}", selectedTour.Gia) + "/Khách";
                    txtGiaTour.Text = string.Format("{0:#,##0}", selectedTour.Gia);
                    txtGioKhoiHanh.Text = selectedTour.GioKhoiHanh;
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
                    dtpNgayKT.Value = selectedTour.NgayVe.Value;
                    lblNoiKH.Text = selectedTour.DiemKhoiHanh;
                    txtDiemKhoiHanh.Text = selectedTour.DiemKhoiHanh;
                    DateTime ngayDi = selectedTour.NgayDi ?? DateTime.MinValue; // Sử dụng DateTime.MinValue nếu NgayDi là null
                    DateTime ngayVe = selectedTour.NgayVe ?? DateTime.MinValue; // Sử dụng DateTime.MinValue nếu NgayVe là null

                    TimeSpan timeSpan = ngayVe.Subtract(ngayDi);

                    int soNgay = (int)timeSpan.TotalDays;

                    lblSoNgay.Text = soNgay.ToString() + " ngày";
                    int soGhe = selectedTour.SoGhe ?? 0; // Sử dụng 0 nếu SoGhe là null
                    int soNguoiDat = selectedTour.SoNguoiDat ?? 0; // Sử dụng 0 nếu SoNguoiDat là null

                    int soLuongConLai = soGhe - soNguoiDat;
                    lblSlot.Text = soLuongConLai.ToString();

                    int SoDem = soNgay - 1;
                    lblTGnho.Text = lblSoNgay.Text + " " + SoDem + " đêm";
                    var phuongTien = selectedTour.PhuongTien;
                    cmbPT.Text = phuongTien.LoaiPhuongTien;    
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
                    cmbDDen.Text = diaDiem.TenDiaDiem;
                    if (diaDiem != null)
                    {
                        lblDiemDen.Text = diaDiem.TenDiaDiem;
                    }
                    else
                    {
                        lblDiemDen.Text = "Không xác định"; // Hoặc bất kỳ giá trị mặc định nào bạn muốn hiển thị khi không tìm thấy địa điểm.
                    }

                    

                   


                    var loaiKhachSan = selectedTour.LoaiKhachSan;
                    cmbKS.Text = loaiKhachSan.TenLoaiKS;
                    if (loaiKhachSan != null)
                    {
                        lblKS.Text = loaiKhachSan.TenLoaiKS;
                    }
                    else
                    {
                        lblKS.Text = "Không xác định"; // Hoặc giá trị mặc định nếu không có thông tin về loại khách sạn.
                    }
                    lblMaTour.Text = selectedTour.MaTour.ToString();
                    txtMaTour.Enabled = false;
                }
            }
        }

        private void ResetInf()
        {
            lblTenTour.Text = "Tên Tour";
            lblMoTa.Text = "Mô tả";
            lblGiaTour.Text = "Giá Tour";
            picHinh1.Image = null;
            picHinh2.Image = null;
            picHinh3.Image = null;
            picHinh4.Image = null;
            lblTGKH.Text = "TG khởi hành";
            lblNoiKH.Text = "Nơi khởi hành";
            lblSoNgay.Text = "Số ngày";
            lblSlot.Text = "Số lượng";
            lblTGnho.Text = "Thời gian";
            lblPT.Text = "Phương tiện";
            lblDiemDen.Text = "Điểm đến";
            lblKS.Text = "Khách sạn";
            lblMaTour.Text = "Mã Tour";
        }
        private bool checkData()
        {
            string notice = "";
            if (string.IsNullOrEmpty(txtTenTour.Text))
            {
                notice += "\nChưa nhập tên Tour!";
                txtTenTour.Focus();
            }

            if (string.IsNullOrEmpty(txtMoTa.Text))
            {
                notice += "\nChưa nhập mô tả!";
                txtMoTa.Focus();
            }

            if (numSL.Value == 0)
            {
                notice += "\nChưa nhập tên số lượng!";
            }

            if (string.IsNullOrEmpty(txtGiaTour.Text))
            {
                notice += "\nChưa nhập giá Tour!";
                txtGiaTour.Focus();
            }

            if (dtpNgayKT.Value <= dtpNgayDi.Value)
            {
                notice += "\nNgày kết thúc phải lớn hơn ngày khởi hành!";
            }

            if (dtpNgayDi.Value < DateTime.Now)
            {
                notice += "\nNgày khởi hành phải lớn hơn ngày hôm nay!";
            }

            if (dtpNgayKT.Value < DateTime.Now)
            {
                notice += "Ngày kết thúc phải lớn hơn ngày hôm nay!";
            }


            if (imgLocation1 == null)
            {
                notice += "\nChưa thêm ảnh 1!";
            }

            if (imgLocation2 == null)
            {
                notice += "\nChưa thêm ảnh 2!";
            }

            if (imgLocation3 == null)
            {
                notice += "\nChưa thêm ảnh 3!";
            }

            if (imgLocation4 == null)
            {
                notice += "\nChưa thêm ảnh 4!";
            }

            if ((dtpNgayDi.Value < DateTime.Now) || (dtpNgayKT.Value < DateTime.Now) || (string.IsNullOrEmpty(txtTenTour.Text)) || (string.IsNullOrEmpty(txtMoTa.Text)) || (numSL.Value == 0) || (string.IsNullOrEmpty(txtGiaTour.Text) || (dtpNgayKT.Value <= dtpNgayDi.Value) || (imgLocation1 == null) || (imgLocation2 == null) || (imgLocation3 == null) || (imgLocation4 == null)))
            {
                MessageBox.Show(notice, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        private bool checkData1()
        {
            string notice = "";

            if (string.IsNullOrEmpty(txtTenTour.Text))
            {
                notice += "\nChưa nhập tên Tour!";
                txtTenTour.Focus();
            }

            if (string.IsNullOrEmpty(txtMoTa.Text))
            {
                notice += "\nChưa nhập mô tả!";
                txtMoTa.Focus();
            }

            if (string.IsNullOrEmpty(txtGiaTour.Text))
            {
                notice += "\nChưa nhập giá Tour!";
                txtGiaTour.Focus();
            }

            if (dtpNgayKT.Value <= dtpNgayDi.Value)
            {
                notice += "\nNgày kết thúc phải lớn hơn ngày khởi hành!";
            }

            if (dtpNgayDi.Value < DateTime.Now)
            {
                notice += "\nNgày khởi hành phải lớn hơn ngày hôm nay!";
            }

            if (dtpNgayKT.Value < DateTime.Now)
            {
                notice += "\nNgày kết thúc phải lớn hơn ngày hôm nay!";
            }

            if ((dtpNgayDi.Value < DateTime.Now) || (dtpNgayKT.Value < DateTime.Now) || (string.IsNullOrEmpty(txtTenTour.Text)) || (string.IsNullOrEmpty(txtMoTa.Text)) || (string.IsNullOrEmpty(txtGiaTour.Text) || (dtpNgayKT.Value <= dtpNgayDi.Value)))
            {
                MessageBox.Show(notice, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
    }
}
