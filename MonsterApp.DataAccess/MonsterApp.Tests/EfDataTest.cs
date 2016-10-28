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
      #region insert tests
      [Fact]
      public void Test_InsertGender()
      {
         var data = new Efdata();
         var expected = new Gender() { GenderName = "new test", Active = true };
         var actual = data.InsertGender(expected);
         Assert.True(actual);
         data.deleteGender(expected);
      }
      [Fact]
      public void Test_InsertTitle()
      {
         var data = new Efdata();
         var expected = new Title() { TitleName = "new test", Active = true };
         var actual = data.InsertTitle(expected);
         Assert.True(actual);
         data.deleteTitle(expected);
      }
      [Fact]
      public void Test_InsertMonsterType()
      {
         var data = new Efdata();
         var expected = new MonsterType() { TypeName = "new test", Active = true };
         var actual = data.InsertMonsterType(expected);
         Assert.True(actual);
         data.deleteMonsterType(expected);
      }
      [Fact]
      public void test_insertMonster()
      {
         var data = new Efdata();
         var expected = new Monster() { GenderId = data.GetGenders().Where(a => a.GenderId == 1).First().GenderId, TitleId = data.getTitles().Where(m => m.TitleId == 1).First().TitleId, TypeId = data.getMonsterTypes().Where(mt => mt.MonsterTypeId == 1).First().MonsterTypeId, Name = "new monster", Active = true };
         var actual = data.insertMonster(expected);
         Assert.True(actual);
         data.deleteMonster(expected);
      }
      #endregion
      #region delete tests
      [Fact]
      public void test_deleteTitle()
      {
         var data = new Efdata();
         var expected = new Title() { TitleName = "new test", Active = true };
         data.InsertTitle(expected);
         var actual = data.deleteTitle(expected);
         Assert.True(actual);
      }
      [Fact]
      public void test_deleteGender()
      {
         var data = new Efdata();
         var expected = new Gender() { GenderName = "new test", Active = true };
         data.InsertGender(expected);
         var actual = data.deleteGender(expected);
         Assert.True(actual);
      }
      [Fact]
      public void test_deleteMonsterType()
      {
         var data = new Efdata();
         var expected = new MonsterType() { TypeName = "new test", Active = true };
         data.InsertMonsterType(expected);
         var actual = data.deleteMonsterType(expected);
         Assert.True(actual);         
      }
      [Fact]
      public void test_deleteMonster()
      {
         var data = new Efdata();
         var expected = new Monster() { GenderId = data.GetGenders().Where(a => a.GenderId == 1).First().GenderId, TitleId = data.getTitles().Where(m => m.TitleId == 1).First().TitleId, TypeId = data.getMonsterTypes().Where(mt => mt.MonsterTypeId == 1).First().MonsterTypeId, Name = "new monster", Active = true };
         data.insertMonster(expected);
         var actual = data.deleteMonster(expected);
         Assert.True(actual);         
      }
      #endregion
   }
}



