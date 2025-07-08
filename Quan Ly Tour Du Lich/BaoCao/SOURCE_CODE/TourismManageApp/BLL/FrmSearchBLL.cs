using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class FrmSearchBLL
    {
        TourismManageAppBLLDataContext db = new TourismManageAppBLLDataContext();

        public List<Tour> GetTours()
        {
            var load = from l in db.Tours select l;
            return load.ToList();
        }

        

        public List<DaiDienKH> GetDaiDienKHs()
        {
            var load = from l in db.DaiDienKHs select l;
            return load.ToList();
        }
    
    }
}
