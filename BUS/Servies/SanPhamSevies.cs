using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Servies
{
    public class SanPhamSevies
    {
       SanPhamRepos repos = new SanPhamRepos();
       public List<SanPham> GetAll()
        {
            return repos.GetAll();
        }
        public string Create(SanPham sanPham)
        {
            if (repos.CreateSP(sanPham))
            {
                return "Thêm thành công ";
            }
            else return "Thêm thất bại! ";

        }
    }
}
