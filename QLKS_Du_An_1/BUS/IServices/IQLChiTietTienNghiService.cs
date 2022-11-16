using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS.ViewModels;
namespace BUS.IServices
{
    public interface IChiTietTienNghiService
    {
        public string Add(ChiTietTienNghiView obj);
        public string Update(ChiTietTienNghiView obj);
        public string Remove(ChiTietTienNghiView obj);
        public List<ChiTietTienNghiView> GetAll();
        public List<ChiTietTienNghiView> Search(string name);
    }
}
