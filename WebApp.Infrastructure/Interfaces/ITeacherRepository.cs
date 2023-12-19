using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Domain.Model;

namespace Infrastructure.Interfaces
{
    public interface ITeacherRepository : IBaseRepository<Teacher>
    {
        Task<Teacher> Get(string name);
    }
}
