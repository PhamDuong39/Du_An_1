﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.IRepositories;
using DAL.Models;

namespace DAL.Repositories
{
    public class ChucVuRepository : IChucVuRepository
    {
        private QLKS_DA1_DbContext _db;
        public ChucVuRepository()
        {
            _db = new QLKS_DA1_DbContext();
        }
        public bool Add(ChucVu obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (_db.ChucVus.FirstOrDefault(c => c.MaCV == obj.MaCV) != null) return false;
            obj.ID = Guid.NewGuid();
            _db.Add(obj);
            _db.SaveChanges();
            return true;
        }

        public List<ChucVu> GetAll()
        {
            return _db.ChucVus.ToList();
        }

        public bool Remove(ChucVu obj)
        {
            if (obj == null)
            {
                return false;
            }
            int indext = GetAll().FindIndex(c => c.ID == obj.ID);
            if (indext == -1) return false;
            _db.Remove(obj);
            _db.SaveChanges();
            return true;
        }

        public bool Upadate(ChucVu obj)
        {
            if (obj == null)
            {
                return false;
            }
            int indext = GetAll().FindIndex(c => c.ID == obj.ID);
            if (indext == -1) return false;
            _db.Update(obj);
            _db.SaveChanges();
            return true;
        }
    }
}