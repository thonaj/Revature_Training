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
   public partial class AdoData
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
                  GenderId = int.Parse(row[0].ToString()),

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

      public List<MonsterType> GetMonsterType()
      {
         try
         {
            var ds = GetDataDisconnected("select * from Monster.MonsterType");
            var monsterTypes = new List<MonsterType>();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
               monsterTypes.Add(new MonsterType
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

      public List<Title> GetTitles()
      {
         try
         {
            var ds = GetDataDisconnected("select * from Monster.Title");
            var titles = new List<Title>();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
               titles.Add(new Title
               {
                  TitleId = int.Parse(row[0].ToString()),
                  TitleName = row[1].ToString(),
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

            da.Fill(ds = new DataSet());
         }

         return ds;
      }
      //public List<Gender> Getlatestgender()
      //{
      //   try
      //   {
      //      var ds = GetDataDisconnected("select * from Monster.Gender where max(GenderId)");
      //      var genders = new List<Gender>();

      //      foreach (DataRow row in ds.Tables[0].Rows)
      //      {
      //         genders.Add(new Gender
      //         {
      //            GenderId = int.Parse(row[0].ToString()),

      //            GenderName = row[1].ToString(),
      //            Active = bool.Parse(row[2].ToString())
      //         });
      //      }
      //      return genders;

      //   }
      //   catch (Exception ex)
      //   {

      //      return null;
      //   }
      //}
   }
}
