using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistrationWeb.RegistrationService;
using RegistrationWeb.Models;

namespace RegistrationWeb.Mappings
{
   public class CourseMapper
   {
      public CourseDAO mapToCourseDAO(CourseDTO course)
      {
         var c = new CourseDAO();
         c.courseCapacity = course.courseCapacity;
         c.courseCredits = course.courseCredits;
         c.courseDept = course.courseDepartment;
         c.courseID = course.AppId;
         c.courseName = course.Name;
         c.courseProfessor = course.courseProfessor;
         c.currentEnrollment = course.currentEnrollment;
         c.endTime = course.endTime;
         c.startTime = course.startTime;

         return c;
      }
      public CourseDTO mapToCourseDTO(CourseDAO course)
      {
         var c = new CourseDTO();
         c.AppId = course.courseID;
         c.courseCapacity = course.courseCapacity;
         c.courseCredits = course.courseCredits;
         c.courseDepartment = course.courseDept;
         c.courseProfessor = course.courseProfessor;
         c.currentEnrollment = course.currentEnrollment;
         c.endTime = course.endTime;
         c.Name = course.courseName;
         c.startTime = course.startTime;
         
         return c;
      }
   }
}
