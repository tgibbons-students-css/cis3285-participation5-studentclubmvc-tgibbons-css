using System.Collections.Generic;
namespace Unit5_student_club_MVC.Models
{
    public interface IStudentCRUDInterface
    {
        public List<StudentModel> getAllStudent();
        public StudentModel getStudentById(int id);
        public void AddStudent(StudentModel newStudent);
        public void UpdateStudent(int studentId, StudentModel updatedStudent);
        public void DeleteStudent(int studentId);

    }

}
