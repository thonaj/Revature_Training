using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using MonsterApp.DataAccess;



namespace MonsterApp.Tests
{
   class AdoDataTests
   {
      [Fact]
      public void Test_GetGenders()
      {
         //arrange
         AdoData data = new AdoData();
         var expected = 3;

         //act
         var actual = data.GetGenders();

         //assert
         Assert.Equal(expected, actual.Count);
      }
   }
}
