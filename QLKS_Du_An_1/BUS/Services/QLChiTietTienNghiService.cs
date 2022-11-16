﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS.IServices;
using BUS.ViewModels;
using DAL.Repositories;
using DAL.IRepositories;
using DAL.Models;
namespace BUS.Services
{
    public class QLChiTietTienNghiService : IQLChiTietTienNghiService
    {
        private IChiTietTienNghiRepository _chiTienNghiRepository;
        private ILoaiTienNghiRepository _loaitnRepos;
        private IPhongRepository _PhongRepos;
        public QLChiTietTienNghiService()
        {
            _chiTienNghiRepository = new ChiTietTienNghiRepository();
            _loaitnRepos = new LoaiTienNghiRepository();
            _PhongRepos = new PhongRepository();
        }
        public string Add(ChiTietTienNghiView obj)
        {
            if (obj == null)
            {
                return "Không có đối tượng để thêm";
            }
            else
            {
                var cttn = new ChiTietTienNghi()
                {
                    ID = obj.ID,
                    MaCTTienNghi = obj.MaCTTienNghi,
                    IdPhong = obj.IdPhong,
                    TenCTTienNghi = obj.TenCTTienNghi,
                    IDLoaiTienNghi = obj.IDLoaiTienNghi,
                    
                };
                if (_chiTienNghiRepository.Add(cttn))
                {
                    return "Thêm tiện nghi thành công";
                }
                else
                {
                    return "Thêm tiện nghi thất bại";
                }
                
            };
        }
        
        public List<ChiTietTienNghiView> GetAll()
        {
            List<ChiTietTienNghiView> lst = new List<ChiTietTienNghiView>();
            lst = (from a in _chiTienNghiRepository.GetAll()
                   join b in _loaitnRepos.GetAll() on a.IDLoaiTienNghi equals b.ID
                   join c in _PhongRepos.GetAll() on a.IdPhong equals c.Id
                   select new ChiTietTienNghiView
                   {
                       ID = a.ID,
                       MaCTTienNghi = a.MaCTTienNghi,
                       IdPhong = a.IdPhong,
                       TenCTTienNghi = a.TenCTTienNghi,
                       IDLoaiTienNghi = a.IDLoaiTienNghi,
                       TenLoaiTienNghi = b.TenLoaiTienNghi,
                       MaPhong = c.MaPhong
                   }).ToList();
            return lst;
        }

        public string Remove(ChiTietTienNghiView obj)
        {
            if (obj == null)
            {
                return "Không có đối tượng để xóa";
            }
            else
            {
                var tn = _chiTienNghiRepository.GetAll().FirstOrDefault(a => a.ID == obj.ID);
                if (_chiTienNghiRepository.Remove(tn))
                {
                    return "Xóa tiện nghi thành công";
                }
                else
                {
                    return "Xóa tiện nghi thất bại";
                }
                
            }
        }

        public List<ChiTietTienNghiView> Search(string name)
        {
            var cttn = GetAll().Where(a => a.TenCTTienNghi.Contains(name)).ToList();
            return cttn;
        }

        public string Update(ChiTietTienNghiView obj)
        {
            if (obj == null)
            {
                return "Không tìm được đối tượng để sửa";
            }
            else
            {
                var ltn = _chiTienNghiRepository.GetAll().FirstOrDefault(a => a.ID == obj.ID);           
                ltn.MaCTTienNghi = obj.MaCTTienNghi;
                ltn.IdPhong = obj.IdPhong;
                ltn.TenCTTienNghi = obj.TenCTTienNghi;
                ltn.IDLoaiTienNghi = obj.IDLoaiTienNghi;
                if (_chiTienNghiRepository.Upadate(ltn))
                {
                    return "Sửa thông tin tiện nghi thành công";
                }
                else
                {
                    return "Sửa thông tin thất bại, vui lòng thử lại";
                }
            };
        }
    }
}