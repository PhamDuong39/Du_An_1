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
        private IChiTietPhieuThueRepository _chiTietPhieuThueRepository;
        private IKhachHangRepository _khachHangRepository;
        private INhanVienRepository _nhanVienRepository;
        private IPhongRepository _phongRepository;
        private IHoaDonChiTietRepository _hoaDonChiTietRepository;
        private IDichVuRepository _dichVuRepository;
        private IPhieuThueRepository _phieuThueRepository;

        public HoaDonService()
        {
            _hoaDonRepository = new HoaDonRepository();
            _validations = new Validations();
            _chiTietPhieuThueRepository = new ChiTietPhieuThueRepository();
            _khachHangRepository = new KhachHangRepository();
            _nhanVienRepository = new NhanVienRepository();
            _phongRepository = new PhongRepository();
            _hoaDonChiTietRepository = new HoaDonChiTietRepository();
            _dichVuRepository = new DichVuRepository();
            _phieuThueRepository = new PhieuThueRepository();
        }
        private string Validate(HoaDonView obj)
        {
            return string.Empty;
        }
        public string Add(HoaDonView obj)
        {
            throw new NotImplementedException();
        }

        public List<HoaDonView> GetCTHoaDon()
        {
            List<HoaDonView> _lst = new List<HoaDonView>();
            _lst = (from a in _hoaDonRepository.GetAll()
                    join b in _chiTietPhieuThueRepository.GetAll() on a.IdCTPhieuThue equals b.IdPhieuThue
                    join c in _hoaDonChiTietRepository.GetAll() on a.Id equals c.IdHoaDon
                    join d in _dichVuRepository.GetAll() on c.IdDichVu equals d.Id
                    join e in _phieuThueRepository.GetAll() on b.IdPhieuThue equals e.ID
                    join f in _nhanVienRepository.GetAll() on e.IdNV equals f.ID
                    join g in _khachHangRepository.GetAll() on e.IdKH equals g.ID
                    join h in _phongRepository.GetAll() on b.IdPhong equals h.Id
                    select new HoaDonView()
                    {
                        Id = a.Id,
                        MaHD = a.MaHD,
                        NgayTaoHD = a.NgayTaoHD,
                        IdCTPhieuThue = a.IdCTPhieuThue,
                        NgayBatDau = b.NgayBatDau,
                        NgayKetThuc = b.NgayKetThuc,
                        IdKH = g.ID,
                        TenKH = g.HovaTen,
                        IdNV = f.ID,
                        TenNV = f.TenNV,
                        IdPhong = h.Id,
                        MaPhong = h.MaPhong,
                        IdDichVu = c.IdDichVu,
                        SoLuongDichVu = c.SoLuong,
                        DonGia = c.DonGia,
                        TenDichVu = d.TenDichVu,
                        TongTien = 9999
                    }).ToList();
            return _lst;
        }
        public List<HoaDonView> GetListHD()
        {
            List<HoaDonView> _lst = new List<HoaDonView>();
            _lst = (from a in _hoaDonRepository.GetAll()
                    join b in _chiTietPhieuThueRepository.GetAll() on a.IdCTPhieuThue equals b.IdPhieuThue
                    join e in _phieuThueRepository.GetAll() on b.IdPhieuThue equals e.ID
                    join f in _nhanVienRepository.GetAll() on e.IdNV equals f.ID
                    join g in _khachHangRepository.GetAll() on e.IdKH equals g.ID
                    join h in _phongRepository.GetAll() on b.IdPhong equals h.Id
                    select new HoaDonView()
                    {
                        Id = a.Id,
                        MaHD = a.MaHD,
                        NgayTaoHD = a.NgayTaoHD,
                        TenKH = g.HovaTen,
                        TenNV = f.TenNV,
                        NgayKetThuc = DateTime.Now,
                        MaPhong = h.MaPhong
                    }).ToList();
            return _lst;
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
            return GetCTHoaDon().Where(c => c.MaHD.ToUpper().Contains(keyWord.ToUpper())).ToList();
        }
    }
}
