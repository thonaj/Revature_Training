using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RegistrationWeb.Logic;


namespace RegistrationWeb.Client
{
   public partial class _default : System.Web.UI.Page
   {

      protected void Page_Load(object sender, EventArgs e)
      {
         getStudents();

      }
      private void getStudents()
      {
         var data = new DataService();
         studentlist.Items.Clear();
         foreach (var item in data.getStudents())
         {
            studentlist.Items.Add(item.Name);
         }
         
         

      }
     
   }
}