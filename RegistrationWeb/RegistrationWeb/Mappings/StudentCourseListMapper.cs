using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistrationWeb.RegistrationService;
using RegistrationWeb.Models;

namespace RegistrationWeb.Mappings
{
   public class StudentCourseListMapper
   {
      public StudentCourseListDAO mapToStudentCourseListDAO(StudentCourseListDTO scl)
      {
         var sc = new StudentCourseListDAO();
         sc.courseID = scl.courseID;
         sc.StudentCourseID = scl.AppId;         
         sc.studentID = scl.StudentID;
         
         return sc;
      }
      public StudentCourseListDTO mapToStudentCourseListDTO(StudentCourseListDAO scl)
      {
         var sc = new StudentCourseListDTO();
         sc.AppId = scl.StudentCourseID;
         sc.courseID = scl.courseID;
         sc.Name = scl.Course.courseName + "_" + scl.Student.firstName + "_" + scl.Student.lastName;
         sc.StudentID = scl.studentID;
         return sc;
      }
   }
}
