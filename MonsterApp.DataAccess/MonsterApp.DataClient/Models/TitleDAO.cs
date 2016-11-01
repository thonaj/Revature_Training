using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MonsterApp.DataClient.Models
{
   [DataContract]
   public class TitleDAO
   {
      [DataMember]
      public int ID { get; set; }
      [DataMember]
      public string Name { get; set; }
   }
}