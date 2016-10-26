using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterApp.DataAccess
{
   /// <summary>
   /// monster gender
   /// </summary>
   public class Gender
   {
      public int GenderID { get; set; }
      public string GenderName { get; set; }
      public bool Active { get; set; }
   }
}
