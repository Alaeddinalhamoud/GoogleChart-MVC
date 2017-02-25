using GoogleChart_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleChart_MVC.Service
{
 public   interface IStudent
    {
        IList<Student> GetStudents { get; }
    }
}
