using ProjetoFinalMVC.Data;
using ProjetoFinalMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.EntityFrameworkCore;

namespace ProjetoFinalMVC.Services
{
    public class DepartmentService
    {
        private readonly ProjetoFinalMVCContext _context;

        public DepartmentService(ProjetoFinalMVCContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }

        //public void Insert(Seller obj)
        //{
        //    obj.Deparment = _context.Department.First();
        //    _context.Add(obj);
        //    _context.SaveChanges();
        //}
    }
}
