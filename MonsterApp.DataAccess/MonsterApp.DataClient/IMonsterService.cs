using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MonsterApp.DataClient.Models;
namespace MonsterApp.DataClient
{
   
   [ServiceContract]
   public interface IMonsterService
   {
      [OperationContract]
      List<GenderDAO> getGenders();

      [OperationContract]
      List<MonsterTypeDAO> getMonsterTypes();

      [OperationContract]      
      List<TitleDAO> getTitles();


   }
}
