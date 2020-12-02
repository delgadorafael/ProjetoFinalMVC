using ProjetoFinalMVC.Data;
using ProjetoFinalMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoFinalMVC.Services.Exceptions;

namespace ProjetoFinalMVC.Services
{
    public class SellerService
    {
        private readonly ProjetoFinalMVCContext _context;

        public SellerService(ProjetoFinalMVCContext context)
        {
            _context = context;
        }

        public async Task<List<Seller>> FindAllAsync()
        {
            return await _context.Seller.ToListAsync();
        }

        public async Task<Seller> FindByIdAsync(int id)
        {
            //return _context.Seller.Find(id);
            return await _context.Seller.Include(x => x.Deparment).FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task InsertAsync(Seller obj)
        {
            //obj.Deparment = _context.Department.First();
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveAsync(int id)
        {
            var obj = await _context.Seller.FindAsync(id);
            _context.Seller.Remove(obj);
            //_context.Seller.Remove(seller); caso parametro fosse o objeto vendedor
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Seller obj)
        {
            bool hasAny = await _context.Seller.AnyAsync(x => x.Id == obj.Id);

            if (!hasAny)
                throw new NotFoundException("ID not found!");

            try
            {
                _context.Update(obj);
                await _context.SaveChangesAsync();
            }
            catch(DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}
