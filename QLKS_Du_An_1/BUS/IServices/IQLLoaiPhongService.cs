using BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface IQLLoaiPhongService
    {
        List<LoaiPhongView> GetAll();
        bool Add(LoaiPhongView loaiPhongView);
        bool Remove(LoaiPhongView loaiPhongView);
        bool Update(LoaiPhongView loaiPhongView);

    }
}
