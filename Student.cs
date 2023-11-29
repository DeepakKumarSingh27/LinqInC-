using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqOperations
{
    public class Student
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public List<string> subjects { get; set; }
        public static List<Student> GetAllStudents()
        {
                List<Student> listStudents = new List<Student>
                {
                    new Student
                    {
                    Name = "Tom",Gender = "Male",subjects = new List<string> {"ASP.NET","C#"}
                    },
                     new Student
                    {
                    Name = "Mike",Gender = "Male",subjects = new List<string> {"ADO.NET","C#","AjAx"}
                    },
               

                    new Student
                {
                    Name = "DoM",Gender = "Male",subjects = new List<string> {"JAVA","C#"}
                },
                    new Student
                {
                    Name = "BOM",Gender = "Male",subjects = new List<string> {"ASP.NET","C#"}
                },
                };
            return listStudents;
        }    

    }
}

