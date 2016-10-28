using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using MonsterApp.DataAccess;



namespace MonsterApp.Tests
{
   public partial class AdoDataTests
   {
      [Fact]
      public void Test_GetGenders()
      {
         //arrange
         AdoData data = new AdoData();
         //act
         var actual = data.GetGenders();
         //assert
         Assert.NotNull(actual);
      }

      [Fact]
      public void Test_GetMonsterTypes()
      {
         //arrange
         AdoData data = new AdoData();
         //act
         var actual = data.GetMonsterType();
         //assert
         Assert.NotNull(actual);
      }
      [Fact]
      public void Test_GetTitles()
         {
            //arrange
            AdoData data = new AdoData();
            //act
            var actual = data.GetTitles();
            //assert
            Assert.NotNull(actual);
         }

         //[Fact]
      //   public void test_getlatestgender()
      //{
      //   AdoData data = new AdoData();
      //   var actual = data.Getlatestgender();
      //   Assert.NotNull(actual);
      //}
      }   
}
