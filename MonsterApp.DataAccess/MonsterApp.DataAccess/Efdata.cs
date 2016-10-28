using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterApp.DataAccess
{
   public class Efdata
   {
      private MonsterDBEntities db = new MonsterDBEntities();
      public List<Gender> GetGenders()
      {
         return db.Genders.ToList();
      }
      public List<Title> getTitles()
      {
         return db.Titles.ToList();
      }
      public List<MonsterType> getMonsterTypes()

      {
         return db.MonsterTypes.ToList();
      }

      public bool InsertGender(Gender gender)
      {
         db.Genders.Add(gender);
         return db.SaveChanges() >0;
      }

      public bool insertMonster(Monster monster)
      {
         db.Monsters.Add(monster);
         return db.SaveChanges() > 0;
      }

      public bool changeGender(Gender gender, EntityState state )
      {
         var entry = db.Entry<Gender>(gender);
         entry.State = EntityState.Added;
         
         return db.SaveChanges() > 0;
      }
      public bool changeMonster(Monster monster, EntityState state)
      {
         var entry = db.Entry<Monster>(monster);
         entry.State = EntityState.Added;

         return db.SaveChanges() > 0;
      }
      public bool searchGender()
      {
         var actives = db.Genders.Where(a => a.Active);
         var inactives = db.Genders.Where(i => !i.Active);
         var ma = db.Genders.Where(m => m.GenderName.ToLower().Contains("ma"));
         return ma.Count() > 0;
      }
   }
}
