using Microsoft.EntityFrameworkCore;
using MVCBasics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class EmployeeRepository
    {
        private readonly AppContext _context;

        public EmployeeRepository(AppContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<EmployeeModel>> Index()
        {
            return await _context.EmployeeModel.ToListAsync();
        }

        public async Task<EmployeeModel> Details(string id)
        {
            if (id == null)
            {
                return null;
            }

            return await _context.EmployeeModel
                .FirstOrDefaultAsync(m => m.ID == id);

        }

        public async void Create(EmployeeModel employeeModel)
        {
            _context.Add(employeeModel);
            await _context.SaveChangesAsync();
        }

        public async Task<EmployeeModel> Find(string id)
        {
            return await _context.EmployeeModel.FindAsync(id);
        }

        public async Task<EmployeeModel> Edit(string id, EmployeeModel employeeModel)
        {
            try
            {
                _context.Update(employeeModel);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeModelExists(employeeModel.ID))
                {
                    return null;
                }
                else
                {
                    throw;
                }
            }
            return employeeModel;
        }

        public async void DeleteConfirmed(string id)
        {
            var employeeModel = await _context.EmployeeModel.FindAsync(id);
            _context.EmployeeModel.Remove(employeeModel);
            await _context.SaveChangesAsync();
        }

        private bool EmployeeModelExists(string id)
        {
            return _context.EmployeeModel.Any(e => e.ID == id);
        }
    }
}
