using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace MonsterApp.DataClient.Models
{
   [DataContract]
   public class MonsterDAO
   {
      [DataMember]
      public int Id { get; set; }
      [DataMember]
      public string Name { get; set; }
      [DataMember]
      public GenderDAO gender { get; set; }
   }
}