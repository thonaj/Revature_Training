using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterApp.DataAccess
{
   /// <summary>
   /// monster type
   /// </summary>
   public class MonsterType
   {
      public int MonsterTypeId { get; set; }
      public string TypeName { get; set; }
      public bool Active { get; set; }
   }
}
