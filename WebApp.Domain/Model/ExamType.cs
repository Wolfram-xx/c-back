using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Domain.Model
{

    public class ExamType
    {
        [Key]
        public int ID { get; set; } = 0!;
        public string Name { get; set; } = null!;

        public ICollection<Discipline> TypeToGG { get; set; } = null!;
    }
}
