using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Domain.Model
{
    public class Teacher
    {
        [Key]
        public string Name { get; set; } = null!;
        // Other properties as needed

        // Relationships
        public ICollection<Discipline> TaughtDisciplines { get; set; } = null!;
    }
}
