using BUS.ViewModels;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface IQLPhongService
    {
        List<PhongView> GetAll();
        bool Add(PhongView phongView);
        bool Remove(PhongView phongView);
        bool Update(PhongView phongView);
    }
}
