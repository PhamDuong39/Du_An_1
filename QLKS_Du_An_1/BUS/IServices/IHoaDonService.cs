using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS.ViewModels;

namespace BUS.IServices
{
    public interface IHoaDonService
    {
        public string Add(HoaDonView obj);
        public string Update(HoaDonView obj);
        public string Remove(HoaDonView obj);
        public List<HoaDonView> GetListHD();
        public List<HoaDonView> GetCTHoaDon();
        public List<HoaDonView> Search(string keyWord);
    }
}
