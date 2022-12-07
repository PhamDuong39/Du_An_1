using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.IRepositories;
using DAL.Models;

namespace DAL.Repositories
{
    public class DichVuRepository : IDichVuRepository
    {
        private QLKS_DA1_DbContext _db;
        public DichVuRepository()
        {
            _db = new QLKS_DA1_DbContext();
        }
        public bool Add(DichVu obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (_db.DichVus.FirstOrDefault(c => c.MaDichVu == obj.MaDichVu) != null) return false;
            obj.Id = Guid.NewGuid();
            _db.Add(obj);
            _db.SaveChanges();
            return true;
        }

        public List<DichVu> GetAll()
        {
            return _db.DichVus.ToList();
        }

        public bool Remove(DichVu obj)
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

        public bool Upadate(DichVu obj)
        {
            if (obj == null)
            {
                return false;
            }
            int indext = GetAll().FindIndex(c => c.Id == obj.Id);
            if (indext == -1) return false;
            _db.Update(obj);
            _db.SaveChanges();
            return true;
        }
    }
}
