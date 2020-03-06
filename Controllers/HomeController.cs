using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentManagement.Models;
using StudentManagement.ViewModels;

namespace StudentManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        public HomeController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public IActionResult Index()
        {
         IEnumerable<Student> students=   _studentRepository.GetAllStudents();
            //返回学生列表
            return View(students);
        }

        public IActionResult Details()
        {
            //  Student model = _studentRepository.GetStudent(1);
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                student = _studentRepository.GetStudent(1),
                PageTitle = "Student Details"
            };
            
            return View(homeDetailsViewModel);//_studentRepository.GetStudent(1).Name;
        }
    }
}