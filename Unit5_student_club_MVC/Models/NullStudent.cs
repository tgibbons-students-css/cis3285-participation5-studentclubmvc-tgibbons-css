using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Unit5_student_club_MVC.Models
{
    public class NullStudent : IStudentInterface
    {

        // The Create view needs a parameterless constructor
        public NullStudent()
        {     
        }

        public NullStudent(int id, string name, int credits)
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Credits { get; set; }

    }
}
