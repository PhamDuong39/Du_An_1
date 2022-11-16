﻿using BUS.IServices;
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
        public string Add(PhongView obj)
        {
            if(obj == null)
            {
                return "Không có đối tượng truyền vào";
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
                if (iPhongRepository.Add(phong))
                {
                    return "Thêm phòng thành công";
                }
                else 
                {
                    return "Thêm phòng không thành công";
                };
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

        public string Remove(PhongView obj)
        {
            if (obj == null) return "Không có đối tượng truyền vào";
            var phong = iPhongRepository.GetAll().FirstOrDefault(c => c.Id == obj.Id);
            if (iPhongRepository.Remove(phong))
            {
                return "Xóa phòng thành công";
            }
            else
            {
                return "Xóa phòng không thành công";
            }
        }

        public string Update(PhongView obj)
        {
            if (obj == null) return "Không có đối tượng truyền vào";
            var phong = new Phong()
            {
                Id = obj.Id,
                MaPhong = obj.MaPhong,
                IDLoaiPhong = obj.IDLoaiPhong,
                IdCTTienNghi = obj.IdCTTienNghi,
                TinhTrang = obj.TinhTrang
            };
            if (iPhongRepository.Upadate(phong))
            {
                return "Sửa Phòng thành công";
            }
            else
            {
                return "Sửa Phòng không thành công"; 
            }

        }
    }
}
