using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Unit5_student_club_MVC.Models
{
    public class StudentModel : IStudentInterface
    {
        int id;
        string name;
        int credits;

        // The Create view needs a parameterless constructor
        public StudentModel ()
        {
            //Debt -- create a blank student here
        }

        public StudentModel(int id, string name, int credits)
        {
            this.id = id;
            this.name = name;
            this.credits = credits;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Credits { get => credits; set => credits = value; }

    }
}
