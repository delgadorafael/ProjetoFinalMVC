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

        public void Insert(Seller obj)
        {
            //obj.Deparment = _context.Department.First();
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
