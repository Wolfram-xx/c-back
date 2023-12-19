﻿using WebApp.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfaces
{
    public interface IExamTypeRepository : IBaseRepository<ExamType>
    {
        Task<ExamType> GetByType(string type);
    }
}
