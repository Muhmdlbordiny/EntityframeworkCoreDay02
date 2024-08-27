using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentEntity02.Entites
{
    internal class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Bouns { get; set; }
        public double Salary { get; set; }
        public string Address { get; set; }
        public int HourRate { get; set; }
        //[ForeignKey(nameof(Instructor.))]
        public int departmentId { get; set; }
        [InverseProperty(nameof(Department.instructor))]
        public Department department { get; set; }
    }
}
