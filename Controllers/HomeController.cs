using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentManagement.Models;

namespace StudentManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        public HomeController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public string Index()
        {
            //返回学生名字
            return _studentRepository.GetStudent(1).Name;
        }

        public IActionResult Details()
        {
            Student model = _studentRepository.GetStudent(1);
            return View( model);//_studentRepository.GetStudent(1).Name;
        }
    }
}