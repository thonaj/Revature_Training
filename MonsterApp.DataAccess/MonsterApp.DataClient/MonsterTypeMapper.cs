using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MonsterApp.DataAccess.Models;
using MonsterApp.DataClient.Models;


namespace MonsterApp.DataClient
{
   public class MonsterTypeMapper
   {
      public static MonsterTypeDAO maptoMonsterTypeDAO(MonsterType monsterType)
      {
         var g = new GenderDAO();
         g.Id = monsterType.MonsterTypeId;
         g.name = monsterType.TypeName;
         return g;
      }
   }
}