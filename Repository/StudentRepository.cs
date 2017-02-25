using GoogleChart_MVC.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GoogleChart_MVC.Models;

namespace GoogleChart_MVC.Repository
{
    public class StudentRepository : IStudent
    {
        public IList<Student> GetStudents
        {
            get
            {
                List<Student> Students = new List<Student>();

                Students.Add(new Student() { StudentId = 1, FirstName = "Alaeddin", LastName = "Alhamoud", Country="SYR"});
                Students.Add(new Student() { StudentId = 2, FirstName = "John", LastName = "Adam", Country = "USA" });
                Students.Add(new Student() { StudentId = 3, FirstName = "Adam", LastName = "Danielle", Country = "France" });
                Students.Add(new Student() { StudentId = 4, FirstName = "Oprah", LastName = "Porter", Country = "UK" });
                Students.Add(new Student() { StudentId = 5, FirstName = "Miriam", LastName = "Aristotle", Country = "UK" });
                Students.Add(new Student() { StudentId = 6, FirstName = "Amos", LastName = "Wynne", Country = "RU" });
                Students.Add(new Student() { StudentId = 7, FirstName = "Grant", LastName = "Chloe", Country = "RU" });
                Students.Add(new Student() { StudentId = 8, FirstName = "Orla", LastName = "Anjolie", Country = "KSA" });
                Students.Add(new Student() { StudentId = 9, FirstName = "Charity", LastName = "Amela", Country = "UAE" });
                Students.Add(new Student() { StudentId = 10, FirstName = "Marsden", LastName = "Zachary", Country = "UAE" });

                return Students;
            }
        }
    }
}