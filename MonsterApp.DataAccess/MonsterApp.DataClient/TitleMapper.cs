using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MonsterApp.DataClient.Models;
using da = MonsterApp.DataAccess.Models;
namespace MonsterApp.DataClient
{
   public class TitleMapper
   {
      public static TitleDAO maptoTitleDAO(da.Title title)
      {
         var g = new TitleDAO();
         g.ID = title.titleId;
         g.Name = title.titleName;
         return g;
      }
      public static da.Title mapToTitle(TitleDAO title)
      {
         var t = new da.Title();
         t.titleId = title.ID;
         t.titleName = title.Name;
         return t;
      }
   }
}