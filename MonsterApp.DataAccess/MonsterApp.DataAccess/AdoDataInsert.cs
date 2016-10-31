using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterApp.DataAccess
{
   public partial class AdoData
   {
      public bool insertGender(Models.Gender gender)
      {
         var name = new SqlParameter("name", gender.GenderName);
         var query = "insert into Monster.Gender (GenderName, Active) values(@name, 1)";
         return InsertData(query, name)==1;
      }


      public bool insertMonsterType(Models.MonsterType type)
      {
         var name = new SqlParameter("name", type.TypeName );
         var query = "insert into Monster.MonsterType (TypeName, Active) values(@name, 1)";
         return InsertData(query, name) == 1;
        
      }
      public bool insertMonsterTitle(Models.Title title)
      {
         var name = new SqlParameter("name", title.titleName);
         var query = "insert into Monster.Title (titleName, Active) values(@name, 1)";
         return InsertData(query, name) == 1;
        
      }

      public bool insertMonster(Models.Monster monster)
      {
         var name = new SqlParameter("Name", monster.Name);
         var gender = new SqlParameter("GenderId", monster.GenderId);
         var titleid = new SqlParameter("TitleId", monster.TitleId);
         var typeid = new SqlParameter("TypeId", monster.TypeId);
         var picturepath = new SqlParameter("PicturePath", monster.PicturePath);
         var query = "insert into Monster.Monster (GenderId, TitleId, TypeId, Name, PicturePath, Active) values (@GenderId, @TitleId, @TypeId, @Name, @PicturePath, 1)";
         return InsertData(query, gender, titleid, typeid, name, picturepath)==1;
      }

      private int InsertData(string query, params SqlParameter[] parameters)
      {
         int result;
         using (var connection = new SqlConnection(connectionstring))
         {            
            var cmd = new SqlCommand(query, connection);
            connection.Open();
            cmd.Parameters.AddRange(parameters);
            result = cmd.ExecuteNonQuery();            
         }
         return result;
      }
   }
}
