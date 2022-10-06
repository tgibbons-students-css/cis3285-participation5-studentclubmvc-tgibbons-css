using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Unit5_student_club_MVC.Models;

namespace Unit5_student_club_MVC.Controllers
{
    public class StudentController : Controller
    {
        // Our link to the list of students in the Models folder
        IStudentCRUDInterface studentRepo = new StudentRepository();

        public StudentController()
        {
            // we are not using this constructor any more
        }


        // GET: StudentController
        public ActionResult Index()
        {
            return View("Index", studentRepo.getAllStudent());
        }

        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            return View("Details",studentRepo.getStudentById(id));
        }


        // GET: SampleController/Create
        public ActionResult Create()
        {
            // This display the initial view when creating a student
            return View();
        }

        // POST: SampleController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            // This is run after the user clicks the Create button
            // The collection is a map that contains the data fields
            try
            {
                IStudentInterface newStudent = new StudentModel();
                // Retrieve form data using form collection
                newStudent.Id = Int32.Parse(collection["Id"]);
                newStudent.Name = collection["Name"];
                newStudent.Credits = Int32.Parse(collection["Credits"]);
                studentRepo.AddStudent(newStudent);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            // This displays the edit view when it is first openned
            // The student that matches the id parameter must be passed to the view
            return View("Edit", studentRepo.getStudentById(id));
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            // This is run after the user edits a student
            // The collection is a map that contains the data fields from the view
            try
            {
                IStudentInterface updatedStudent = new StudentModel();
                // Retrieve form data using form collection
                updatedStudent.Id = id;
                updatedStudent.Name = collection["Name"];
                updatedStudent.Credits = Int32.Parse(collection["Credits"]);
                studentRepo.UpdateStudent(id, updatedStudent);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                studentRepo.DeleteStudent(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
