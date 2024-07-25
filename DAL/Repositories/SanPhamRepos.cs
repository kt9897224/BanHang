using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class SanPhamRepos
    {
        Duan1Context _context = new Duan1Context();
        public SanPhamRepos()
        {
            _context = new Duan1Context();

        }
        public List<SanPham> GetAll()
        {
            return _context.SanPhams.ToList();
        }
        public SanPham GetByID(int id)
        {
            return _context.SanPhams.Find(id);
        }
        public bool CreateSP(SanPham sp)
        {
            try
            {
                _context.SanPhams.Add(sp);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }

    }
}
