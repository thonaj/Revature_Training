using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterApp.DataAccess
{
   public class AdoData
   {
      private string connectionstring = ConfigurationManager.ConnectionStrings["MonsterDB"].ConnectionString;


      #region methods

      
      public List<Gender> GetGenders()
      {
         try
         {
            var ds = GetDataDisconnected("select * from Monster.Gender");
            var genders = new List<Gender>();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
               genders.Add(new Gender
               {
                  GenderID = int.Parse(row[0].ToString()),
                  GenderName = row[1].ToString(),
                  Active = bool.Parse(row[2].ToString())
               });
            }
            return genders;

         }
         catch (Exception)
         {

            return null;
         }


         
         
      }

      public List<MonsterType> GetMonsterType()
      {
         throw new NotImplementedException("todo");
      }

      public List<Title> GetTitles()
      {
         throw new NotImplementedException("todo");
      }

      #endregion

      private DataSet GetDataDisconnected(string query)
      {
         SqlDataAdapter da;
         DataSet ds;
         SqlCommand cmd;

         using (var connection = new SqlConnection(connectionstring))
         {
            cmd = new SqlCommand(query, connection);
            da = new SqlDataAdapter(cmd);

            da.Fill(ds=new DataSet());
         }

         return ds;
      }
   }
}
