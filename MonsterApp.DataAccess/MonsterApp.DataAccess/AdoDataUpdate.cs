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
      public bool UpdateGender(Models.Gender gender)
      {
         var query = "update Monster.Gender set GenderName=@GenderName, Active=@Active where GenderId=@GenderId";
         var name = new SqlParameter("GenderName", gender.GenderName);
         var active = new SqlParameter("Active", gender.Active ? 1:0);
         var id = new SqlParameter("GenderId", gender.GenderID);
         return updateData(query, name, active, id) > 0;


      }
      public bool UpdateMonsterType(Models.MonsterType monsterType)
      {
         var query = "update Monster.MonsterType set TypeName=@TypeName, Active=@Active where MonsterTypeId=@MonsterTypeId";
         var name = new SqlParameter("TypeName", monsterType.TypeName);
         var active = new SqlParameter("Active", monsterType.Active ? 1 : 0);
         var id = new SqlParameter("MonsterTypeId", monsterType.MonsterTypeId);
         return updateData(query, name, active, id) > 0;
      }
      public bool UpdateTitle(Models.Title title)
      {
         var query = "update Monster.Title set TitleName=@TitleName, Active=@Active where TitleId=@TitleId";
         var name = new SqlParameter("TitleName", title.titleName);
         var active = new SqlParameter("Active", title.Active ? 1 : 0);
         var id = new SqlParameter("TitleId", title.titleId);         
         return updateData(query,name,active,id) > 0;
      }
      private int updateData(string query, params SqlParameter[] parameter)
      {
         int result;
         using (SqlConnection connection = new SqlConnection(connectionstring))
         {
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            cmd.Parameters.AddRange(parameter);
            result=cmd.ExecuteNonQuery();

         }
         return result;
      }
      
   }
}
