using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FrmDashBroadBLL
    {
        TourismManageAppBLLDataContext ql = new TourismManageAppBLLDataContext();
        public FrmDashBroadBLL() { }
        public DataTable ThongKe_DoanhThu_Nam(HopDong hopdong)
        {

            var query = from hd in ql.HopDongs
                        where hd.NgayKyHD.Value.Year == hopdong.NgayKyHD.Value.Year
                        group hd by hd.NgayKyHD.Value.Month into g
                        select new
                        {
                            Thang = g.Key,
                            ThanhTien = g.Sum(x => x.TongTien)
                        };
            
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Tháng", typeof(int));
            dataTable.Columns.Add("Thành tiền", typeof(decimal));

            foreach (var item in query)
            {
                dataTable.Rows.Add(item.Thang, item.ThanhTien);
            }

            return dataTable;
        }
    }
}

