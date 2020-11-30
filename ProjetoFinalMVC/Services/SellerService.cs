using ProjetoFinalMVC.Data;
using ProjetoFinalMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinalMVC.Services
{
    public class SellerService
    {
        private readonly ProjetoFinalMVCContext _context;

        public SellerService(ProjetoFinalMVCContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public Seller FindById(int id)
        {
            return _context.Seller.Find(id);
            //return _context.Seller.FirstOrDefault(x => x.Id == id);
        }

        public void Insert(Seller obj)
        {
            //obj.Deparment = _context.Department.First();
            _context.Add(obj);
            _context.SaveChanges();
        }

        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            //_context.Seller.Remove(seller); caso parametro fosse o objeto vendedor
            _context.SaveChanges();
        }
    }
}
