using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistrationWeb.Logic.Interfaces;

namespace RegistrationWeb.Models
{
   class CourseDTO : RegistrationThing
   {
      private string _Name = default(string);
      public override string Name
      {
         get
         {
            return _Name;
         }
         set
         {
            IsNull(ref _Name, value);
         }
      }
      
      public CourseDTO() : base()
      {
      }

      internal override CourseDTO Create<CourseDTO>()
      {
         return new CourseDTO();
      }

      private void IsNull(ref string data, string value)
      {
         if (string.IsNullOrWhiteSpace(value))
         {
            return;
         }
         data = value;

      }
   }
}
