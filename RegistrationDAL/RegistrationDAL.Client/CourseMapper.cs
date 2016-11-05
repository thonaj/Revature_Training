using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistrationDAL;
using RegistrationClient.Models;

namespace RegistrationDAL.Client
{
   public class CourseMapper
   {
      public Course MapToCourse(CourseDAO course)
      {
         var c = new Course();
         c.courseCapacity = course.courseCapacity;
         c.courseCredits = course.courseCredits;
         c.courseDept = course.courseDept;
         c.courseID = course.courseID;
         c.courseName = course.courseName;
         c.courseProfessor = course.courseProfessor;
         c.currentEnrollment = course.currentEnrollment;
         c.endTime = course.endTime;
         c.startTime = course.startTime;
         c.active = course.active;
         

         return c;
      }
      public CourseDAO MapToCourseDAO(Course course)
      {
         var c = new CourseDAO();
         c.courseCapacity = course.courseCapacity;
         c.courseCredits = course.courseCredits;
         c.courseDept = course.courseDept;
         c.courseID = course.courseID;
         c.courseName = course.courseName;
         c.courseProfessor = course.courseProfessor;
         c.currentEnrollment = course.currentEnrollment;
         c.endTime = course.endTime;
         c.startTime = course.startTime;
         c.active = course.active;

         return c;
      }
   }
}
