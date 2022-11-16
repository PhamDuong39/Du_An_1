using BUS.IServices;
using BUS.ViewModels;
using DAL.IRepositories;
using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class ILoaiPhongService : IQLLoaiPhongService
    {
        ILoaiPhongRepository iLoaiPhongRepository;
        public ILoaiPhongService()
        {
            iLoaiPhongRepository = new LoaiPhongRepository();
        }

        public bool Add(LoaiPhongView loaiPhongView)
        {
           if(loaiPhongView == null) return false;
            var LoaiPhong = new LoaiPhong()
            {
                ID = loaiPhongView.ID,
                MaLoaiPhong = loaiPhongView.MaLoaiPhong,
                TenLoaiPhong = loaiPhongView.TenLoaiPhong,
                GiaNgay = loaiPhongView.GiaNgay,
                SoGiuong = loaiPhongView.SoGiuong,
            };
            return iLoaiPhongRepository.Add(LoaiPhong);
            
        }

        public List<LoaiPhongView> GetAll()
        {
            List<LoaiPhongView> _list = new List<LoaiPhongView>();
            _list=(from a in iLoaiPhongRepository.GetAll()
                   select new LoaiPhongView
                   {
                       ID = a.ID,
                       MaLoaiPhong=a.MaLoaiPhong,
                       TenLoaiPhong=a.TenLoaiPhong,
                       SoGiuong=a.SoGiuong,
                       GiaNgay=a.GiaNgay
                   }).ToList();
            return _list;
        }

        public bool Remove(LoaiPhongView loaiPhongView)
        {
            if(loaiPhongView==null) return false;
            var loaiPhong = iLoaiPhongRepository.GetAll().FirstOrDefault(c => c.ID == loaiPhongView.ID);
            return iLoaiPhongRepository.Remove(loaiPhong);
            
        }

        public bool Update(LoaiPhongView loaiPhongView)
        {
            if (loaiPhongView == null) return false;
            var loaiPhong = new LoaiPhong()
            {
                ID = loaiPhongView.ID,
                MaLoaiPhong = loaiPhongView.MaLoaiPhong,
                TenLoaiPhong = loaiPhongView.TenLoaiPhong,
                GiaNgay = loaiPhongView.GiaNgay,
                SoGiuong = loaiPhongView.SoGiuong,
            };
            return iLoaiPhongRepository.Upadate(loaiPhong);
        }
    }
}
