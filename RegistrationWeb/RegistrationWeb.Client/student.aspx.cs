using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RegistrationWeb.Logic;

namespace RegistrationWeb.Client
{
   public partial class student : System.Web.UI.Page
   {
      private DataService data = new DataService();
      protected void Page_Load(object sender, EventArgs e)
      {
         if (!IsPostBack)

         {
            getStudents();
            getCourses();
            getStudentCourseList();
         }
         
      }
      private void getStudents()
      {
         studentlist.Items.Clear();
         foreach (var item in data.getStudents())
         {
            studentlist.Items.Add(item.firstName + " " + item.lastName + " " + item.major);
         }
         
      }
      private void getCourses()
      {
         courselist.Items.Clear();
         foreach (var item in data.getCourses())
         {
            courselist.Items.Add(item.Name);
         }
      }
      private void getStudentCourseList()
      {
         studentcourselist.Items.Clear();
         foreach (var item in data.getStudentCourseList())
         {
            studentcourselist.Items.Add(item.Name);
         }
      }
   }
}