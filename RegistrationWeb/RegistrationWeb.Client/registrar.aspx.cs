using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RegistrationWeb.Logic;

namespace RegistrationWeb.Client
{
   public partial class registrar : System.Web.UI.Page
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
            studentlist.Items.Add(item.firstName.ToUpper() + " " + item.lastName.ToUpper() + " " + item.major.ToUpper());
         }

      }
      private void getCourses()
      {
         courselist.Items.Clear();
         foreach (var item in data.getCourses())
         {
            courselist.Items.Add(item.Name.ToUpper() +" " + item.courseDepartment.ToUpper()+" " +item.startTime + "-" + item.endTime + " " + item.currentEnrollment+"/"+item.courseCapacity);
         }
      }
      private void getStudentCourseList()
      {
         studentcourselist.Items.Clear();
         foreach (var item in data.getStudentCourseList())
         {
            studentcourselist.Items.Add(item.Name.ToUpper());
         }
      }

      protected void deleteStudentButton_Click(object sender, EventArgs e)
      {

      }

      protected void deleteCourseButton_Click(object sender, EventArgs e)
      {

      }

      protected void unregisterCourse_Click(object sender, EventArgs e)
      {

      }

      protected void viewStudentSchedule_Click(object sender, EventArgs e)
      {

      }

      protected void viewCourseEnrollment_Click(object sender, EventArgs e)
      {

      }
   }
}