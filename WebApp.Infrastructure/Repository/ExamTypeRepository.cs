using Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Domain.Model;
using WebApp.Infrastructure;

namespace Infrastructure.Repository
{
    internal class ExamTypeRepository : IExamTypeRepository
    {
        private readonly Context _context;
        public Context Unit
        {
            get
            {
                return _context;
            }
        }
        public async Task<List<ExamType>> GetAll()
        {
            return await _context.ExamTypes.Include(p => p.Name)
                .OrderBy(p => p.Name).ToListAsync();
        }

        public async Task<ExamType> GetByType(string type)
        {
            return await _context.ExamTypes
                .Where(p => p.Name == type)
                .Include(p => p.Name)
                .FirstOrDefaultAsync();
        }
    }
  }

