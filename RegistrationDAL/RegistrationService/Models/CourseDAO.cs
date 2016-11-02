using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistrationService.Models
{
   public class CourseDAO
   {
      public int courseID { get; set; }
      public string courseName { get; set; }
      public string courseDept { get; set; }
      public int courseCapacity { get; set; }
      public string courseProfessor { get; set; }
      public System.TimeSpan startTime { get; set; }
      public System.TimeSpan endTime { get; set; }
      public Nullable<int> currentEnrollment { get; set; }
      public int courseCredits { get; set; }
      public bool active { get; set; }
   }
}