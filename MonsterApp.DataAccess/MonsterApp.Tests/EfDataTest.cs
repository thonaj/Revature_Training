using MonsterApp.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
namespace MonsterApp.Tests
{
   public class EfDataTest
   {
      [Fact]
      public void test_InsertGender()
      {
         var data = new Efdata();
         var actual = data.GetGenders();
         Assert.NotNull(actual);
      }

      [Fact]
      public void Test_insertGender()
      {
         var data = new Efdata();
         var expected = new Gender() { GenderName = "martian", Active = true };
         var actual = data.changeGender(expected, System.Data.Entity.EntityState.Added);

         Assert.True(actual);
      }
   }
}
