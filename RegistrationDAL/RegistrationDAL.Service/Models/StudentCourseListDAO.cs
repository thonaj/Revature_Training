using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistrationDAL;

namespace RegistrationClient.Models
{
   public class StudentCourseListDAO
   {
      public int StudentCourseID { get; set; }
      public int studentID { get; set; }
      public int courseID { get; set; }      
      public virtual CourseDAO Course { get; set; }
      public virtual StudentDAO Student { get; set; }
   }
}
