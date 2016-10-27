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
      public bool insertGender(Gender gender)
      {
         var name = new SqlParameter("name", gender.GenderName);
         var query = "insert into Monster.Gender (GenderName, Active) values(@name, 1)";
         return InsertData(query, name)==1;
      }
      public bool insertMonsterType(MonsterType type)
      {
         var name = new SqlParameter("name", type.TypeName );
         var query = "insert into Monster.MonsterType (TypeName, Active) values(@name, 1)";
         int result;
         SqlCommand cmd;

         using (var connection = new SqlConnection(connectionstring))
         {
            connection.Open();
            cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add(name);
            result = cmd.ExecuteNonQuery();
            return result == 1;
         }
      }
      public bool insertMonsterTitle(Title title)
      {
         var name = new SqlParameter("name", title.titleName);
         var query = "insert into Monster.Title (TitleName, Active) values(@name, 1)";
         int result;
         SqlCommand cmd;

         using (var connection = new SqlConnection(connectionstring))
         {
            connection.Open();
            cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add(name);
            result = cmd.ExecuteNonQuery();
            return result == 1;
         }
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
