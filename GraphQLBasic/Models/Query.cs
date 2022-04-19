using GraphQLBasic.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLBasic.Models
{
    public class Query
    {
        IStudentService _studentService = null;

        public Query(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public List<Student> students => _studentService.GetStudents();
    }
}
