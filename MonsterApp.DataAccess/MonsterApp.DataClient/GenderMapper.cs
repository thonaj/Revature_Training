using da= MonsterApp.DataAccess.Models;
using MonsterApp.DataClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MonsterApp.DataAccess;

namespace MonsterApp.DataClient
{
   public class GenderMapper
   {
      public static GenderDAO maptoGenderDAO(Gender gender)
      {
        var g = new GenderDAO();
         g.Id = gender.GenderId;
         g.name = gender.GenderName;
         return g;
      }
      public static object MapTo(Object o)
      {
         var properties = o.GetType().GetProperties();
         var ob = new object();
         foreach (var item in properties.ToList())
         {
            ob.GetType().GetProperty(item.Name).SetValue(ob, item.GetValue(item));
         }
         return ob;
      }
      //public static Gender mapToGender(GenderDAO gender)
      //{
         
      //}
   }
}