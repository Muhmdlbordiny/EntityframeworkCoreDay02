using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentEntity02.Entites
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime HiringDate { get; set; }
        [ForeignKey(nameof(Department.InstructorId))]
        public int? InstructorId { get; set; }
        public Instructor Instructor { get; set; }
        public List <Instructor> instructor { get; set; }
    }
}
