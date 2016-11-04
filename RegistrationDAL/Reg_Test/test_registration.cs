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
      private EfDal data = new EfDal();

      #region test get functions 
      
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

      #region test update and delete functions

      [Fact]
      public void testupdateCourse()
      {
         var testcourse = new Course() { courseName = "testcourse", };
         var actual = data.updateCourse(testcourse);
         Assert.True(actual);
      }
      [Fact]
      public void testdeleteCourse()
      {
         var testcourse = new Course() { courseName = "testcourse", };
         var actual = data.updateCourse(testcourse);
         Assert.True(actual);
      }
      [Fact]
      public void testupdateStudent()
      {
         var teststudent = new Student() { firstName = "Test", lastName = "Student" };
         var actual = data.updateStudent(teststudent);
         Assert.True(actual);
      }
      [Fact]
      public void testdeleteStudent()
      {
         var teststudent = new Student() { firstName = "Test", lastName = "Student" };
         var actual = data.deleteStudent(teststudent);
         Assert.True(actual);
      }
      [Fact]
      public void testupdateStudentCourseList()
      {
         var testscl = new StudentCourseList() { courseID = 10, studentID = 20 };
         var actual = data.updateStudentCourseList(testscl);
         Assert.True(actual);
      }
      [Fact]
      public void testdeleteStudentCourseList()
      {
         var testscl = new StudentCourseList() { courseID = 10, studentID = 20 };
         var actual = data.deleteStudentCourseList(testscl);
         Assert.True(actual); 
      }
      #endregion

      #region test insert functions
      [Fact]
      public void testinsertCourse()
      {
         var course = new Course() { courseName="newtestcourse", courseDept="testdept", courseCapacity=30, courseProfessor="testprofessor", startTime=new TimeSpan(8,0,0), endTime=new TimeSpan(10,0,0), courseCredits=2,  };
         var actual = data.insertCourse(course);
         Assert.True(actual);
      }

      [Fact]
      public void testinsertStudent()
      {
         var student = new Student() { firstName="fname",lastName="lname", major="testmajor" };
         var actual = data.insertStudent(student);
         Assert.True(actual);
      }

      [Fact]
      public void testinsertStudentCourseList()
      {
         var scl = new StudentCourseList() { studentID=14, courseID=5 };
         var actual = data.insertStudentCourseList(scl);
         Assert.True(actual);
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

      [Fact]
      public void testregisterCourse()
      {
         var student = new Student() { studentID = 4 };
         var course = new Course() { courseID = 3 };
         var actual = data.registerCourse(student, course);
         Assert.True(actual);
      }

      [Fact]
      public void testdropCourse()
      {
         var scl = new StudentCourseList() { StudentCourseID = 5 };
         var actual = data.dropCourse(scl);
         Assert.True(actual);
      }

      [Fact]
      public void testscheduleCourse()
      {
         var course = new Course() { courseName = "testcourse 2" };
         var actual = data.scheduleCourse(course);
         Assert.True(actual);
      }

      [Fact]
      public void testcancelCourse()
      {
         var course = new Course() { courseID = 7 };
         var actual = data.cancelCourse(course);
         Assert.True(actual);
      }

      [Fact]
      public void testmodifyCourseTime()
      {
         var course = new Course() { courseID = 3 };
         var start = new TimeSpan(10, 0, 0);
         var end = new TimeSpan(11, 0, 0);
         var actual = data.modifyCourseTime(course, start, end);
         Assert.True(actual);
      }

      [Fact]
      public void testmodifyCourseCapacity()
      {
         var course = new Course() { courseID = 4 };
         var capacity = 20;
         var actual = data.modifyCourseCapacity(course, capacity);
         Assert.True(actual);
      }
   }
}
