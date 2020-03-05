using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Models
{
  public interface IStudentRepository
    {
        Student GetStudent(int Id);
      //  Student GetById(int id);

        //Student Add(Student student);

        //IEnumerable<Student> GetAll();

        //Student Update(Student updatedStudent);

        //Student Delete(int id);
    }
}
