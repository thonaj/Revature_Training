using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RegistrationDAL.Client
{
   
   [ServiceContract]
   public interface IRegistrationService
   {

      [OperationContract]
      string GetData(int value);

      

      // TODO: Add your service operations here
   }


   
   
}
//public List<Course> getCourses()
//{
//   List<Course> temp = new List<Course>();
//   foreach (var item in db.Courses.ToList().Where(a => a.active == true))
//   {
//      temp.Add(item);
//   }

//   return temp;
//}
//public List<Student> getStudents()
//{
//   List<Student> temp = new List<Student>();
//   foreach (var item in db.Students.ToList().Where(a => a.active == true))
//   {
//      temp.Add(item);
//   }

//   return temp;
//}
//public List<StudentCourseList> getStudentCourseList()
//{
//   List<StudentCourseList> temp = new List<StudentCourseList>();
//   foreach (var item in db.StudentCourseLists.ToList().Where(a => a.active == true))
//   {
//      temp.Add(item);
//   }

//   return temp;
//}