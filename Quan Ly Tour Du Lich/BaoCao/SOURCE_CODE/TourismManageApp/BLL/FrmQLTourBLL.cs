using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FrmQLTourBLL
    {
        TourismManageAppBLLDataContext db = new TourismManageAppBLLDataContext();

        public FrmQLTourBLL()
        {
            
        }

        public List<Tour> layDSTour()
        {
            var list = from tour in db.Tours select tour;
            return list.ToList();
        }
        public List<DiaDiem> layDSDiaDiem()
        {
            var list = from dd in db.DiaDiems select dd;
            return list.ToList();
        }

        public List<Tour> searchTourTheoMa(int maTour)
        {
            var list = from tour in db.Tours
                       where tour.MaTour == maTour
                       select tour;
            return list.ToList();
        }

        public List<Tour> searchTourTheoDiaDiem(int maDiaDiem)
        {
            var list = from tour in db.Tours
                       where tour.MaDiaDiem == maDiaDiem
                       select tour;
            return list.ToList();
        }


    }
}
