using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentEntity02.Entites
{
    internal class Student
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string? Address { get; set; }
        [ForeignKey(nameof(Student.DeptId))]
        public int? DeptId { get; set; }
        public Department Department { get; set; }

    }
}
