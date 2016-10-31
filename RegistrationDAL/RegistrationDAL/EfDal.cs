using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistrationDAL;
using System.Data.Entity;

namespace Registration.DAL
{
   public class EfDal
   {
      private RegistrationDBEntities1 db = new RegistrationDBEntities1();

      #region insert functions
      public bool insertCourse(Course course)
      {
         db.Courses.Add(course);
         return db.SaveChanges()>0;
      }
      public bool insertStudent(Student student)
      {
         db.Students.Add(student);
         return db.SaveChanges() > 0;
      }
      public bool insertStudentCourseList(StudentCourseList scl)
      {
         db.StudentCourseLists.Add(scl);
         return db.SaveChanges() > 0;
      }
      #endregion

      #region update and delete functions that use change course
      public bool updateCourse(Course course)
      {
         return changeCourse(course, EntityState.Modified);
      }
      public bool deleteCourse(Course course)
      {
         course.active = false;
         return changeCourse(course, EntityState.Modified);
      }
      public bool updateStuden(Student student)
      {
         return changeStudent(student, EntityState.Modified);
      }
      public bool deleteStudent(Student student)
      {
         student.active = false;
         return changeStudent(student, EntityState.Modified);
      }
      public bool updateStudentCourseList(StudentCourseList scl)
      {
         return changeStudentCourseList(scl, EntityState.Modified);
      }
      public bool deleteStudentCourseList(StudentCourseList scl)
      {
         scl.active = false;
         return changeStudentCourseList(scl, EntityState.Modified);
      }









      #endregion

      #region change functions, used in updated and deletes
      private bool changeCourse(Course course, EntityState state)

      {
         var entry = db.Entry<Course>(course);
         entry.State = state;
         return db.SaveChanges() > 0;
      }
      private bool changeStudent(Student student,EntityState state)
      {
         var entry = db.Entry<Student>(student);
         entry.State = state;
         return db.SaveChanges() < 0;
      }
      private bool changeStudentCourseList(StudentCourseList scl, EntityState state)
      {
         var entry = db.Entry<StudentCourseList>(scl);
         entry.State = state;
         return db.SaveChanges() < 0;
      }



      #endregion

      #region get functions

      public List<Course> getCourses()
      {
         return db.Courses.ToList();
      }
      public List<Student> getStudents()
      {
         return db.Students.ToList();
      }
      public List<StudentCourseList> getStudentCourseList()
      {
         return db.StudentCourseLists.ToList();
      }
      #endregion
   }
}
