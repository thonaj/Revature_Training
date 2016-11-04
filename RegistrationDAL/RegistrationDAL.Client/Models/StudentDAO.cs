using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationClient.Models
{
   public class StudentDAO
   {
      public int studentID { get; set; }
      public string firstName { get; set; }
      public string middleName { get; set; }
      public string lastName { get; set; }
      public string major { get; set; }
   }
}
