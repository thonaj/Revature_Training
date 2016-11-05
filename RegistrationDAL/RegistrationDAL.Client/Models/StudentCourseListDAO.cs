using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistrationDAL;
using System.Runtime.Serialization;

namespace RegistrationClient.Models
{
   [DataContract]
   public class StudentCourseListDAO
   {
      [DataMember]
      public int StudentCourseID { get; set; }
      [DataMember]
      public int studentID { get; set; }
      [DataMember]
      public int courseID { get; set; }
      [DataMember]
      public virtual CourseDAO Course { get; set; }
      [DataMember]
      public virtual StudentDAO Student { get; set; }
      [DataMember]
      public bool active { get; set; }
   }
}
