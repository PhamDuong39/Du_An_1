using BUS.IServices;
using BUS.ViewModels;
using DAL.IRepositories;
using DAL.Models;
using DAL.Repositories;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class IPhongService : IQLPhongService
    {
        ILoaiPhongRepository iLoaiPhongRepository;
        IPhongRepository iPhongRepository;
        IChiTietTienNghiRepository iChiTietTienNghiRepository;
        public IPhongService()
        {
            iPhongRepository = new PhongRepository();
            iLoaiPhongRepository = new LoaiPhongRepository();
            iChiTietTienNghiRepository = new ChiTietTienNghiRepository();
        }
        public bool Add(PhongView obj)
        {
            if(obj == null)
            {
                return false;
            }
            else
            {
                var phong = new Phong
                {
                    Id = obj.Id,
                    MaPhong = obj.MaPhong,
                    TinhTrang = obj.TinhTrang,
                    IDLoaiPhong = obj.IDLoaiPhong,
                    IdCTTienNghi = obj.IdCTTienNghi
                };
                if (iPhongRepository.Add(phong)) return true;
                else { return false;}
            }
        }
        
        public List<PhongView> GetAll()
        {
            List<PhongView> _list = new List<PhongView>();
            _list = (from a in iPhongRepository.GetAll()
                     join c in iChiTietTienNghiRepository.GetAll() on a.Id equals c.IdPhong
                     join b in iLoaiPhongRepository.GetAll() on a.IDLoaiPhong equals b.ID
                     select new PhongView
                     {
                         Id = a.Id,
                         MaPhong = a.MaPhong,
                         TinhTrang = a.TinhTrang,
                         IDLoaiPhong = a.IDLoaiPhong,
                         IdCTTienNghi = c.ID,
                         TenLoaiPhong = b.TenLoaiPhong,
                         TenCTTienNghi = c.TenCTTienNghi
                     }).ToList();
            return _list;

        }

        public bool Remove(PhongView obj)
        {
            if (obj == null) return false;
            var phong = iPhongRepository.GetAll().FirstOrDefault(c => c.Id == obj.Id);
            return iPhongRepository.Remove(phong);
        }

        public bool Update(PhongView obj)
        {
            if (obj == null) return false;
            var phong = new Phong()
            {
                Id = obj.Id,
                MaPhong = obj.MaPhong,
                IDLoaiPhong = obj.IDLoaiPhong,
                IdCTTienNghi = obj.IdCTTienNghi,
                TinhTrang = obj.TinhTrang
            };
            return iPhongRepository.Upadate(phong);
        }
    }
}
