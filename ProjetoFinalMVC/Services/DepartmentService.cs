using ProjetoFinalMVC.Data;
using ProjetoFinalMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinalMVC.Services
{
    public class DepartmentService
    {
        private readonly ProjetoFinalMVCContext _context;

        public DepartmentService(ProjetoFinalMVCContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }

        //public void Insert(Seller obj)
        //{
        //    obj.Deparment = _context.Department.First();
        //    _context.Add(obj);
        //    _context.SaveChanges();
        //}
    }
}
