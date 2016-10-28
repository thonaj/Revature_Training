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
      //reference to db
      private MonsterDBEntities1 db = new MonsterDBEntities1();

      /// <summary>
      /// Public Get functions
      /// </summary>
      # region Get Functions
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

      public List<Monster> getMonsters()
      {
         return db.Monsters.ToList();
      }
      #endregion


      /// <summary>
      /// Public Insert Functions
      /// </summary>
      #region Insert Functions
      public bool InsertGender(Gender gender)
      {
         db.Genders.Add(gender);
         return db.SaveChanges() >0;
      }

      public bool InsertTitle(Title title)
      {
         db.Titles.Add(title);
         return db.SaveChanges() > 0;
      }

      public bool InsertMonsterType(MonsterType mt)
      {
         db.MonsterTypes.Add(mt);
         return db.SaveChanges() > 0;
      }

      public bool insertMonster(Monster monster)
      {
         db.Monsters.Add(monster);
         return db.SaveChanges() > 0;
      }
      #endregion


      /// <summary>
      /// Public Update Functions
      /// </summary>     
      #region Update Functions
      public bool updateTitle(Title title)
      {
         return changeTitle(title, EntityState.Modified);
      }
      public bool updateMonsterType(MonsterType mt)
      {
         return changeMonsterType(mt, EntityState.Modified);
      }
      public bool updateGender(Gender g)
      {
         return changeGender(g, EntityState.Modified);
      }
      public bool updateMonster(Monster m)
      {
         return changeMonster(m, EntityState.Modified);
      }
      #endregion


      /// <summary>
      /// Public delete functions
      /// </summary>      
      #region Delete Functions
      public bool deleteGender(Gender gender)
      {
         gender.Active = false;
         return changeGender(gender, EntityState.Modified);
      }
      public bool deleteTitle(Title title)
      {
         title.Active = false;
         return changeTitle(title, EntityState.Modified);
      }
      public bool deleteMonsterType(MonsterType monsterType)
      {
         monsterType.Active = false;
         return changeMonsterType(monsterType, EntityState.Modified);
      }
      public bool deleteMonster(Monster monster)
      {
         monster.Active = false;
         return changeMonster(monster, EntityState.Modified);
      }
      #endregion


      /// <summary>
      /// Private change Functions. Used for deletions and updates
      /// </summary>     
      #region Change Functions
      private bool changeGender(Gender gender, EntityState state )
      {
         var entry = db.Entry<Gender>(gender);
         entry.State = state;         
         return db.SaveChanges() > 0;
      }
      private bool changeMonster(Monster monster, EntityState state)
      {
         var entry = db.Entry<Monster>(monster);
         entry.State = state;
         return db.SaveChanges() > 0;
      }
      private bool changeTitle(Title title, EntityState state)
      {
         var entry = db.Entry<Title>(title);
         entry.State = state;
         return db.SaveChanges() > 0;
      }
      private bool changeMonsterType(MonsterType monstertype, EntityState state)
      {
         var entry = db.Entry<MonsterType>(monstertype);
         entry.State = state;
         return db.SaveChanges() > 0;
      }
      #endregion

      
      public bool searchGender(string key)
      {
         //var actives = db.Genders.Where(a => a.Active);
         //var inactives = db.Genders.Where(i => !i.Active);
         var ma = db.Genders.Where(m => m.GenderName.ToLower().Contains(key));
         return ma.Count() > 0;
      }
   }
}
