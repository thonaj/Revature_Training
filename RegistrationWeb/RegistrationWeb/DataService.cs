using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistrationWeb.RegistrationService;
using RegistrationWeb.Models;


namespace RegistrationWeb.Logic
{
   public class DataService
   {
      private RegistrationServiceClient rsc = new RegistrationServiceClient();
      public List<StudentDTO> getStudents()
      {
         rsc.getStudentCourseList().FirstOrDefault().
      }
   }
}
