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
    public partial class FrmSearch : Form
    {
        FrmSearchBLL bll = new FrmSearchBLL();
        
        public FrmSearch()
        {
            InitializeComponent();
        }

        private void FrmSearch_Load(object sender, EventArgs e)
        {

        }

        private void btn_Tour_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = bll.GetTours();
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = bll.GetDaiDienKHs();
        }

        private void btn_Tick_Click(object sender, EventArgs e)
        {

        }

        private void btn_KhachSan_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Out_Click(object sender, EventArgs e)
        {

            this.Hide();
            
        }

        
    }
}
