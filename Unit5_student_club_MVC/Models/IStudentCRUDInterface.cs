using System.Collections.Generic;
namespace Unit5_student_club_MVC.Models
{
    public interface IStudentCRUDInterface
    {
        public List<IStudentInterface> getAllStudent();
        public IStudentInterface getStudentById(int id);
        public void AddStudent(IStudentInterface newStudent);
        public void UpdateStudent(int studentId, IStudentInterface updatedStudent);
        public void DeleteStudent(int studentId);

    }

}
