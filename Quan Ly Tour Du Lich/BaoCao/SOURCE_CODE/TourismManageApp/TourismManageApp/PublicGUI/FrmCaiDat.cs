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
namespace TourismManageApp
{
    public partial class FrmCaiDat : Form
    {
        private FrmCaiDatBLL bll = new FrmCaiDatBLL();
        public FrmCaiDat()
        {
            InitializeComponent();
        }

        private void nguoiDungBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nguoiDungBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tourismManageAppDataSet);

        }

        private void FrmCaiDat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tourismManageAppDataSet.NguoiDung' table. You can move, or remove it, as needed.
         

        }

       
        private void btnThayDoi_Click_1(object sender, EventArgs e)
        {
            string tenDangNhap = FrmLoginBLL.TenDangNhap;
            string matKhauCu = txtMKHienTai.Text;
            string matKhauMoi = txtMKMoi.Text;
            string xacNhanMatKhau = btnXacNhanMK.Text;

            //Kiểm tra mật khẩu cũ
            if (bll.KiemTraMatKhauCu(tenDangNhap, matKhauCu))
            {
                //Thực hiện đổi mật khẩu
                if (bll.DoiMatKhau(tenDangNhap, matKhauMoi, xacNhanMatKhau))
                {
                    MessageBox.Show("Đổi mật khẩu thành công!");
                }
                else
                {
                    MessageBox.Show("Xác nhận mật khẩu mới không khớp!");
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ không đúng!");
            }
        }
    }
}
