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
    internal class DisciplineRepository : IDisciplineRepository
    {
        private readonly Context _context;
        public Context Unit
        {
            get
            {
                return _context;
            }
        }
        public DisciplineRepository(Context context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<List<Discipline>> GetAll()
        {
            return await _context.Disciplines
                .Include(p => p.Hours)
                .OrderBy(p => p.Name).ToListAsync();
        }



    }
}

