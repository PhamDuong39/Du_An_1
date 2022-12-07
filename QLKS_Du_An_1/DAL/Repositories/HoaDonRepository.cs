﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.IRepositories;
using DAL.Models;

namespace DAL.Repositories
{
    public class HoaDonRepository : IHoaDonRepository
    {
        private QLKS_DA1_DbContext _db;
        public HoaDonRepository()
        {
            _db = new QLKS_DA1_DbContext();
        }
        public bool Add(HoaDon obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (_db.HoaDons.FirstOrDefault(c => c.MaHD == obj.MaHD) != null) return false;
            obj.Id = Guid.NewGuid();
            _db.Add(obj);
            _db.SaveChanges();
            return true;
        }

        public List<HoaDon> GetAll()
        {
            return _db.HoaDons.ToList();
        }

        public bool Remove(HoaDon obj)
        {
            if (obj == null)
            {
                return false;
            }
            int indext = GetAll().FindIndex(c => c.Id == obj.Id);
            if (indext == -1) return false;
            _db.Remove(obj);
            _db.SaveChanges();
            return true;
        }

        public bool Upadate(HoaDon obj)
        {
            if (obj == null)
            {
                return false;
            }
            var indext = GetAll().FirstOrDefault(c => c.Id == obj.Id);
            if (indext == null) return false;
            indext.TrangThai = obj.TrangThai;
            _db.Update(indext);
            _db.SaveChanges();
            return true;
        }
    }
}
