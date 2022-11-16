using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS.IServices;
using BUS.ViewModels;
using DAL.IRepositories;
using DAL.Repositories;
using BUS.Ultilities;

namespace BUS.Services
{
    public class HoaDonService : IHoaDonService
    {
        private IHoaDonRepository _hoaDonRepository;
        private Validations _validations;
        public HoaDonService()
        {
            _hoaDonRepository = new HoaDonRepository();
            _validations = new Validations();
        }
        private string Validate(HoaDonView obj)
        {
            if (_validations.CheckRong(obj.MaHD) == false) return "Nhập đầy đủ dữ liệu";
            if (_validations.CheckRong(obj.TenKH) == false) return "Nhập đầy đủ dữ liệu";
            if (_validations.CheckRong(obj.TenNV) == false) return "Nhập đầy đủ dữ liệu";
            if (_validations.CheckRong(obj.MaHD) == false) return "Nhập đầy đủ dữ liệu";
            return string.Empty;
        }
        public string Add(HoaDonView obj)
        {
            throw new NotImplementedException();
        }

        public List<HoaDonView> GetAll()
        {
            throw new NotImplementedException();
        }

        public string Remove(HoaDonView obj)
        {
            throw new NotImplementedException();
        }

        public string Update(HoaDonView obj)
        {
            throw new NotImplementedException();
        }

        public List<HoaDonView> Search(string keyWord)
        {
            throw new NotImplementedException();
        }
    }
}
