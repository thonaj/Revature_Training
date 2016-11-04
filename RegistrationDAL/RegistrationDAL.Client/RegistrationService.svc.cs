using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using RegistrationClient.Models;
using RegistrationDAL;
using Registration.DAL;

namespace RegistrationDAL.Client
{
   // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
   // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
   public class RegistrationService : IRegistrationService
   {
      private EfDal data = new EfDal();
     
       bool IRegistrationService.cancelCourse(CourseDAO course)
      {
         return data.cancelCourse(new CourseMapper().MapToCourse(course));
      }

      bool IRegistrationService.deleteCourse(CourseDAO course)
      {
         return data.deleteCourse(new CourseMapper().MapToCourse(course));
      }

      bool IRegistrationService.deleteStudent(StudentDAO student)
      {
         return data.deleteStudent(new StudentMapper().MapToStudent(student));
      }

      bool IRegistrationService.deleteStudentCourseList(StudentCourseListDAO scl)
      {
         return data.deleteStudentCourseList(new StudentCourseListMapper().MapToStudentCourseList(scl));
      }

      bool IRegistrationService.dropCourse(StudentCourseListDAO scl)
      {
         return data.dropCourse(new StudentCourseListMapper().MapToStudentCourseList(scl));
      }

      List<CourseDAO> IRegistrationService.getCourses()
      {
         List<CourseDAO> courses = new List<CourseDAO>();
         foreach (var item in data.getCourses())
         {
            courses.Add(new CourseMapper().MapToCourseDAO(item));
         }
         return courses;
      }

      List<StudentCourseListDAO> IRegistrationService.getStudentCourseList()
      {
         List<StudentCourseListDAO> scl = new List<StudentCourseListDAO>();
         foreach (var item in data.getStudentCourseList())
         {
            scl.Add(new StudentCourseListMapper().MapToStudentCourseListDAO(item));
         }
         return scl;
      }

      List<StudentDAO> IRegistrationService.getStudents()
      {
         List<StudentDAO> students = new List<StudentDAO>();
         foreach (var item in data.getStudents())
         {
            students.Add(new StudentMapper().MapToStudentDAO(item));
         }
         return students;
      }

      bool IRegistrationService.insertCourse(CourseDAO course)
      {
          return data.insertCourse(new CourseMapper().MapToCourse(course));
      }

      bool IRegistrationService.insertStudent(StudentDAO student)
      {
         return data.insertStudent(new StudentMapper().MapToStudent(student));
      }

      bool IRegistrationService.insertStudentCourseList(StudentCourseListDAO scl)
      {
         return data.insertStudentCourseList(new StudentCourseListMapper().MapToStudentCourseList(scl));
      }

      List<StudentDAO> IRegistrationService.listEnrolledStudents(CourseDAO course)
      {
         List<StudentDAO> students = new List<StudentDAO>();
         foreach (var item in data.listEnrolledStudents(new CourseMapper().MapToCourse(course)))
         {
            students.Add(new StudentMapper().MapToStudentDAO(item));
         }
         return students;
      }

      List<CourseDAO> IRegistrationService.listStudentSchedule(StudentDAO student)
      {
         List<CourseDAO> courses = new List<CourseDAO>();
         foreach (var item in data.listStudentSchedule(new StudentMapper().MapToStudent(student)))
         {
            courses.Add(new CourseMapper().MapToCourseDAO(item));
         }
         return courses;
      }

      bool IRegistrationService.modifyCourseCapacity(CourseDAO course, int capacity)
      {
         return data.modifyCourseCapacity(new CourseMapper().MapToCourse(course), capacity);
      }

      bool IRegistrationService.modifyCourseTime(CourseDAO course, TimeSpan start, TimeSpan end)
      {
         return data.modifyCourseTime(new CourseMapper().MapToCourse(course), start, end);
      }

      bool IRegistrationService.registerCourse(StudentDAO student, CourseDAO course)
      {
         return data.registerCourse(new StudentMapper().MapToStudent(student), new CourseMapper().MapToCourse(course));
      }

      bool IRegistrationService.scheduleCourse(CourseDAO course)
      {
         return data.scheduleCourse(new CourseMapper().MapToCourse(course));
      }

      bool IRegistrationService.updateCourse(CourseDAO course)
      {
         return data.updateCourse(new CourseMapper().MapToCourse(course));
      }

      bool IRegistrationService.updateStudent(StudentDAO student)
      {
         return data.updateStudent(new StudentMapper().MapToStudent(student));
      }

      bool IRegistrationService.updateStudentCourseList(StudentCourseListDAO scl)
      {
         return data.updateStudentCourseList(new StudentCourseListMapper().MapToStudentCourseList(scl));
      }
   }
}
