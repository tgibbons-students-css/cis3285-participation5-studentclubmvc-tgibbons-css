using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Unit5_student_club_MVC.Models
{
    public class StudentRepository : IStudentCRUDInterface
    {
        static List<IStudentInterface> myStudents = new List<IStudentInterface>();

        public StudentRepository()
        {
            if (myStudents.Count == 0)
            {
                // if list is empty, initialize it
                myStudents.Add(new StudentModel(1001, "Tom", 16));
                myStudents.Add(new StudentModel(1002, "Jen", 8));
                myStudents.Add(new StudentModel(1003, "Sabah", 16));
            }

        }

        public List<IStudentInterface>  getAllStudent()
        {
            return (myStudents);
        }

        public IStudentInterface getStudentById(int id)
        {
            foreach (IStudentInterface student in myStudents){
                if (student.Id == id)
                {
                    return (student);
                }
            }
            // if you can't find the correct student return the first one
            return (nullStudent());

        }

        private IStudentInterface nullStudent()
        {
            // create a null student
            IStudentInterface nullStudent = new StudentModel(-1,"Null Student",-999);
            return nullStudent;
        }

        public void AddStudent(IStudentInterface newStudent)
        {
            myStudents.Add(newStudent);
        }

        public void DeleteStudent(int studentId)
        {
            // search the list for the student that matches the student ID
            // DEBT --- Handle case when student id not found and index is -1
            int index = myStudents.FindIndex(student => (student.Id == studentId));
            myStudents.RemoveAt(index);
        }

        public void UpdateStudent(int studentId, IStudentInterface updatedStudent)
        {
            // search the list for the student that matches the student ID
            // DEBT --- Handle case when student id not found and index is -1
            int index = myStudents.FindIndex(student => (student.Id == studentId));
            if (index>=0)
            {
                // student found, update them
                myStudents[index] = updatedStudent;
            } 
            
        }
    }
}
