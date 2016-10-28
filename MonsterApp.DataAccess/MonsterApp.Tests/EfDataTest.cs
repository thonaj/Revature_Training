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

      [Fact]
      public void Test_changeMonster()
      {
         var data = new Efdata();
         var expected = new Monster() {GenderId=data.GetGenders().Where(a => a.GenderId==1).First().GenderId,TitleId = data.getTitles().Where(m => m.TitleId==1).First().TitleId, TypeId=data.getMonsterTypes().Where(mt => mt.MonsterTypeId==1).First().MonsterTypeId   ,Name="new monster", Active=true };
         var actual = data.changeMonster(expected, System.Data.Entity.EntityState.Added);
         Assert.True(actual);

      }
   }
}



//User.CarType = mydb.CarType.Where(ct => ct.CarTypeID == 1).First();