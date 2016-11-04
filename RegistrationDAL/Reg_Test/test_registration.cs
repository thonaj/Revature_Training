using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registration.DAL;
using Xunit;
using RegistrationDAL;
namespace Registration.Test
{
   public class test_registration
   {
      #region get functions tests
      private EfDal data = new EfDal();
      [Fact]
      public void testgetstudents()
      {
         var actual=data.getStudents();
         Assert.NotNull(actual);
      }
      [Fact] void testgetcourses()
      {
         var actual = data.getCourses();
         Assert.NotNull(actual);
      }
      [Fact]
      public void testgetcourselist()
      {
         var actual = data.getStudentCourseList();
         Assert.NotNull(actual);
      }
      #endregion


      [Fact]
      public void test_listenrolledstudents()
      {
         var testcourse = new Course {courseID=1};
         var actual = data.listEnrolledStudents(testcourse);
         Assert.NotNull(actual);
      }
     
      [Fact]
      public void testgetstudentschedule()
      {
         var teststudent = new Student { studentID = 1 };
         var actual = data.listStudentSchedule(teststudent);
         Assert.NotNull(actual);
      }
   }
}
