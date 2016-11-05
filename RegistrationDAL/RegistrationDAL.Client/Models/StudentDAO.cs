using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationClient.Models
{
   [DataContract]
   public class StudentDAO
   {
      [DataMember]
      public int studentID { get; set; }
      [DataMember]
      public string firstName { get; set; }
      [DataMember]
      public string middleName { get; set; }
      [DataMember]
      public string lastName { get; set; }
      [DataMember]
      public string major { get; set; }
      [DataMember]
      public bool active { get; set; }
   }
}
