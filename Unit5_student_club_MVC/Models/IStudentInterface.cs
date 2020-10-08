using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Unit5_student_club_MVC.Models
{
    public interface IStudentInterface
    {
        // Property declaration:
        public int Id { get; set; }
        public string Name { get; set; }
        public int Credits { get; set; }
    }
}
