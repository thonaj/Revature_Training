using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using da=MonsterApp.DataAccess.Models;
using MonsterApp.DataClient.Models;


namespace MonsterApp.DataClient
{
   public class MonsterTypeMapper
   {
      public static MonsterTypeDAO mapToMonsterTypeDAO(da.MonsterType monsterType)
      {
         var g = new MonsterTypeDAO();
         g.Id = monsterType.MonsterTypeId;
         g.name = monsterType.TypeName;
         return g;
      }
      public static da.MonsterType mapToMonsterType(MonsterTypeDAO monsterType)
      {
         var g = new da.MonsterType();
         g.MonsterTypeId = monsterType.Id;
         g.TypeName = monsterType.name;
         return g;
      }
   }
}