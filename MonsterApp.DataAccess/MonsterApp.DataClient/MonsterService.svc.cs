using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MonsterApp.DataClient.Models;
using MonsterApp.DataAccess;
using da=MonsterApp.DataAccess.Models;

namespace MonsterApp.DataClient
{
   // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MonsterService" in code, svc and config file together.
   // NOTE: In order to launch WCF Test Client for testing this service, please select MonsterService.svc or MonsterService.svc.cs at the Solution Explorer and start debugging.
   public class MonsterService : IMonsterService
   {
      private AdoData data = new AdoData();
      private Efdata ef = new Efdata();
      
      public List<GenderDAO> getGenders()
      {
         var g = new List<GenderDAO>();
         foreach (var gender in data.GetGenders())
         {
            g.Add(GenderMapper.maptoGenderDAO(gender));
         }
         return g;
      }

      public List<MonsterTypeDAO> getMonsterTypes()
      {
         var g = new List<MonsterTypeDAO>();
         foreach (var mt in data.GetMonsterType())
         {
            g.Add(MonsterTypeMapper.mapToMonsterTypeDAO(mt));
         }
         return g;
      }

      public List<TitleDAO> getTitles()
      {
         var g = new List<TitleDAO>();
         foreach (var title in data.GetTitles())
         {
            g.Add(TitleMapper.maptoTitleDAO(title));
         }
         return g;
      }
      public bool insertMonster(MonsterDAO monster)
      {
         var m = new Monster();
         m.Name = monster.Name;
         m.GenderId = monster.gender.Id;
         return ef.insertMonster(m);
      }
   }
}
