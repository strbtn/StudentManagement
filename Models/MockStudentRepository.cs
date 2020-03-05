using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Models
{
    public class MockStudentRepository:IStudentRepository
    {
        private List<Student> _students;

        public MockStudentRepository()
        {
            _students = new List<Student>()
            {
                new Student { Id=1, Name="张三", ClassName="一年级", Email="hello1@deali.cn" },
                new Student { Id=2, Name="李四", ClassName="三年级", Email="hello2@deali.cn" },
                new Student { Id=3, Name="王二麻子", ClassName="四年级", Email="hello3@deali.cn" },
            };
        }

        public Student GetStudent(int Id)
        {
            // throw new NotImplementedException();
            return _students[Id];
        }

        //public Student Add(Student student)
        //{
        //    throw new NotImplementedException();
        //}

        //public Student Delete(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<Student> GetAll()
        //{
        //    throw new NotImplementedException();
        //}

        //public Student GetById(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public Student Update(Student updatedStudent)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
