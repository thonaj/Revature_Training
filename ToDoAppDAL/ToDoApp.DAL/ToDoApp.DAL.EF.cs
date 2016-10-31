using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.DAL;
using ToDoApp;
namespace ToDoApp.DAL
{
   class ToDoApp
   {
      private ToDoAppDBEntities db = new ToDoAppDBEntities();
      private bool changeitem(Item item, EntityState state)

      {
         var entry = db.Entry<Item>(item);
         entry.State = state;
         return db.SaveChanges() > 0;
      }
      public List<Item> getItems()
      {
         return db.Items.ToList();
      }
      public bool insertItem(Item item)
      {
         return changeitem(item, EntityState.Added);
      }
      public bool updateItem(Item item)
      {
         return changeitem(item, EntityState.Modified);
      }
      public bool deleteItem(Item item)
      {
         return changeitem(item, EntityState.Deleted);
      }
      public bool setCompleted(Item item)
      {
         item.Completed = true;
         return changeitem(item, EntityState.Modified);
      }
      public bool setIncomplete(Item item)
      {
         item.Completed = false;
         return changeitem(item, EntityState.Modified);
      }
      public List<Item> getCompleted()
      {
         return db.Items.Where(i => ((i.Completed)?1) == 1);
      }
      public List<Item> getIncomplete()
      {
         return db.Items.Where(i => (i.Completed?1) != 0);
      }
   }
}
