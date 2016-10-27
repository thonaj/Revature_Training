using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterApp.DataAccess.Models
{
   public class Title
   {
      /// <summary>
      /// list of titles
      /// </summary>
      public int titleId { get; set; }
      public string titleName { get; set; }
      public bool Active { get; set; }
   }
}
