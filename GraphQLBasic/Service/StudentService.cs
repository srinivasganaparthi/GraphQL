using GraphQLBasic.IService;
using GraphQLBasic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLBasic.Service
{
    public class StudentService : IStudentService
    {
       public List<Student> GetStudents()
        {
            List<Student> lst = new List<Student>();
            for (int i = 0; i < 9; i++)
            {
                lst.Add(new Student()
                {
                    StudentId = 1,
                    Name = "Student " + i,
                    Roll = 100 + i
                });
            }

            return lst;
        }

    }
}
