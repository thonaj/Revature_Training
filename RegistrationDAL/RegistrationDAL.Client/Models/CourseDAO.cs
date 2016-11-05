using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace RegistrationClient.Models
{
   [DataContract]
   public class CourseDAO
   {
      [DataMember]
      public int courseID { get; set; }
      [DataMember]
      public string courseName { get; set; }
      [DataMember]
      public string courseDept { get; set; }
      [DataMember]
      public int courseCapacity { get; set; }
      [DataMember]
      public string courseProfessor { get; set; }
      [DataMember]
      public TimeSpan startTime { get; set; }
      [DataMember]
      public TimeSpan endTime { get; set; }
      [DataMember]
      public Nullable<int> currentEnrollment { get; set; }
      [DataMember]
      public int courseCredits { get; set; }
      [DataMember]
      public bool active { get; set; }
   }
}
