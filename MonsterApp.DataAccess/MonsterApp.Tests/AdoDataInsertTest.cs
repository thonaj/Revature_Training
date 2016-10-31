using MonsterApp.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using m=MonsterApp.DataAccess.Models;

namespace MonsterApp.Tests
{
   public partial class AdoDataTests
   {
      private m.Gender gender;
      private m.MonsterType type;
      private m.Title title;
      public AdoDataTests()
      {
         gender = new m.Gender() { GenderName = "Test Gender" };
         type = new m.MonsterType() { TypeName= "Test Type"};
         title = new m.Title() { titleName= "test title"};
      }
      [Fact]
      public void Test_InsertGender()
      {
         var data = new AdoData();
         var actual = data.insertGender(gender);
         Assert.True(actual);
      }
      [Fact]
      public void Test_InsertMonsterType()
      {
         var data = new AdoData();
         var actual = data.insertMonsterType(type);
         Assert.True(actual);
      }
      [Fact]
      public void test_InsertTitle()
      {
         var data = new AdoData();
         var actual = data.insertMonsterTitle(title);
         Assert.True(actual);
      }
   }
}
