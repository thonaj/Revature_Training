using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistrationWeb.RegistrationService;
using RegistrationWeb.Models;
using RegistrationWeb.Mappings;


namespace RegistrationWeb.Logic
{
   public class DataService
   {
      private RegistrationServiceClient rsc = new RegistrationServiceClient();
      private FactoryThing<StudentDTO> studentFactory = new FactoryThing<StudentDTO>();
      private FactoryThing<CourseDTO> courseFactory = new FactoryThing<CourseDTO>();
      private FactoryThing<StudentCourseListDTO> sclFactory = new FactoryThing<StudentCourseListDTO>();
      public List<StudentDTO> getStudents()
      {
         List<StudentDTO> students = new List<StudentDTO>();
         foreach (var item in rsc.getStudents())
         {
            var temp = studentFactory.Create();
            var s = new StudentMapper().mapToStudentDTO(item,temp);
            students.Add(s);
         }
         return students;
      }

      public List<CourseDTO> getCourses()
      {
         List<CourseDTO> courses = new List<CourseDTO>();
         foreach (var item in rsc.getCourses())
         {
            var temp = courseFactory.Create();
            var s = new CourseMapper().mapToCourseDTO(item, temp);
            courses.Add(s);
         }
         return courses;
      }

      public List<StudentCourseListDTO> getStudentCourseList()
      {
         List<StudentCourseListDTO> scl = new List<StudentCourseListDTO>();
         foreach (var item in rsc.getStudentCourseList())
         {
            var temp = sclFactory.Create();
            var s = new StudentCourseListMapper().mapToStudentCourseListDTO(item, temp);
            scl.Add(s);
         }
         return scl;
      }
   }
}
