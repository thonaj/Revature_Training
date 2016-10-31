using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonsterApp.DataAccess.Models;


namespace MonsterApp.DataAccess
{
   public partial class AdoData
   {
      private string connectionstring = ConfigurationManager.ConnectionStrings["MonsterDB"].ConnectionString;


      #region methods


      public List<Models.Gender> GetGenders()
      {
         try
         {
            var ds = GetDataDisconnected("select * from Monster.Gender");
            var genders = new List<Models.Gender>();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
               genders.Add(new Models.Gender
               {
                  GenderID = int.Parse(row[0].ToString()),

                  GenderName = row[1].ToString(),
                  Active = bool.Parse(row[2].ToString())
               });
            }
            return genders;

         }
         catch (Exception ex)
         {

            return null;
         }




      }

      public List<Models.MonsterType> GetMonsterType()
      {
         try
         {
            var ds = GetDataDisconnected("select * from Monster.MonsterType");
            var monsterTypes = new List<Models.MonsterType>();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
               monsterTypes.Add(new Models.MonsterType
               {
                  MonsterTypeId = int.Parse(row[0].ToString()),
                  TypeName = row[1].ToString(),
                  Active = bool.Parse(row[2].ToString())
               });
            }
            return monsterTypes;

         }
         catch (Exception ex)
         {

            return null;
         }

      }

      public List<Models.Title> GetTitles()
      {
         try
         {
            var ds = GetDataDisconnected("select * from Monster.Title");
            var titles = new List<Models.Title>();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
               titles.Add(new Models.Title
               {
                  titleId = int.Parse(row[0].ToString()),
                  titleName = row[1].ToString(),
                  Active = bool.Parse(row[2].ToString())
               });
            }
            return titles;
         }
         catch (Exception ex)
         {
            return null;
         }
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
            ds = new DataSet();
            da.Fill(ds);
         }

         return ds;
      }
      
   }
}
