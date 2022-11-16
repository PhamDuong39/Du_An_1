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
    public class QLPhieuThueService : IQLPhieuThueService
    {
        IPhieuThueRepository _iPhieuThueRepository;
        INhanVienRepository _iNhanVienRepository;
        IKhachHangRepository _iKhachHangRepository;
        List<PhieuThueView> _lstPhieuThueView;
        public QLPhieuThueService()
        {
            _iPhieuThueRepository = new PhieuThueRepository();
            _iKhachHangRepository = new KhachHangRepository();
            _iNhanVienRepository = new NhanVienRepository();
            _lstPhieuThueView = new List<PhieuThueView>();
        }
        
        public string Add(PhieuThueView khv)
        {
            if(khv == null)
            {
                return "Thêm thất bại";
            }
            else
            {
                PhieuThue pt = new PhieuThue()
                {
                    ID = khv.ID,
                    IdKH = khv.IdKH,
                    IdNV = khv.IdNV,
                    NgayLapPhieu = khv.NgayLapPhieu
                };
                if (_iPhieuThueRepository.Add(pt))
                {
                    return "Thêm thành công";
                }
                return "Thêm thất bại";
            }
            
            
        }

        public List<PhieuThueView> GetAll()
        {
            _lstPhieuThueView = (from a in _iPhieuThueRepository.GetAll()
                                 join b in _iKhachHangRepository.GetAll() on a.ID equals b.ID
                                 join c in _iNhanVienRepository.GetAll() on a.ID equals c.ID
                                 select new PhieuThueView()
                                 {
                                     ID = a.ID,
                                     TenKH = b.HovaTen,
                                     TenNV = c.TenNV
                                 }).ToList();
            return _lstPhieuThueView;
        }

        public string Remove(PhieuThueView khv)
        {
            if (khv == null)
            {
                return "Xóa thất bại";
            }
            else
            {
                var kh = _iPhieuThueRepository.GetAll().FirstOrDefault(p => p.ID == khv.ID);
                if (_iPhieuThueRepository.Remove(kh))
                {
                    return "Xóa thành công";
                }
                return "Xóa thất bại";
            }
        }

        public string Update(PhieuThueView khv)
        {
            if(khv == null)
            {
                return "Sửa thất bại";
            }
            else
            {
                var x = _iPhieuThueRepository.GetAll().FirstOrDefault(x => x.ID == khv.ID);
                x.IdKH = khv.IdKH;
                x.IdNV = khv.IdNV;
                x.NgayLapPhieu = khv.NgayLapPhieu;
                if (_iPhieuThueRepository.Upadate(x))
                {
                    return "Sửa thành công";
                }
                return "Sửa thất bại";

            }
            
        }
    }
}
