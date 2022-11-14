using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.IRepositories;
using DAL.Models;

namespace DAL.Repositories
{
    public class ChiTietTienNghiRepository : IChiTietTienNghiRepository
    {
        private QLKS_DA1_DbContext _Db;
        public bool Add(ChiTietTienNghi obj)
        {
            if (obj == null)
            {
                return false;
            }
            
            obj.ID = Guid.NewGuid();
            _Db.Add(obj);
            _Db.SaveChanges();
            return true;
        }

        public List<ChiTietTienNghi> GetAll()
        {
            return _Db.ChiTietTienNghis.ToList();
        }

        public bool Remove(ChiTietTienNghi obj)
        {
            if (obj == null)
            {
                return false;
            }
            var tienNghi = GetAll().FirstOrDefault(a => a.ID == obj.ID);
            _Db.Remove(tienNghi);
            _Db.SaveChanges();
            return true;
        }

        public bool Upadate(ChiTietTienNghi obj)
        {
            if (obj == null)
            {
                return false;
            }
            var x = _Db.ChiTietTienNghis.FirstOrDefault(a => a.ID == obj.ID);
            x.MaCTTienNghi = obj.TenCTTienNghi;
            x.TenCTTienNghi = obj.TenCTTienNghi;
            x.IDLoaiTienNghi = obj.IDLoaiTienNghi;
            _Db.Update(x);
            _Db.SaveChanges();
            return true;
        }
    }
}
