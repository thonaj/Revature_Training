using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistrationDAL;
using System.Data.Entity;
using Registration.DAL;


namespace Registration.DAL
{
   public class EfDal
   {
      private RegistrationDBEntities db = new RegistrationDBEntities();

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

      public bool registerCourse(Student student, Course course)
      {
         var register = new StudentCourseList();
         register.studentID = student.studentID;
         register.courseID = course.courseID;
         register.active = true;
         return insertStudentCourseList(register);
      }
      public bool dropCourse(StudentCourseList scl)
      {
         scl.active = false;
         return changeStudentCourseList(scl, EntityState.Modified);
      }
      public bool scheduleCourse(Course course)
      {
         return changeCourse(course, EntityState.Added);
      }
      public bool cancelCourse(Course course)
      {
         course.active = false;
         return changeCourse(course, EntityState.Modified);
      }
      public bool modifyCourseTime(Course course, TimeSpan start, TimeSpan end)
      {
         course.startTime = start;
         course.endTime = end;
         return changeCourse(course, EntityState.Modified);
      }
      public bool modifyCourseCapacity(Course course, int capacity)
      {
         course.courseCapacity = capacity;
         return changeCourse(course, EntityState.Modified);
      }
      public List<Student> listEnrolledStudents(Course course)
      {
         var students = getStudents();
         var courses = getCourses();
         var studentCourse = getStudentCourseList();
         List<Student> sl= new List<Student>();
         var query =
            from st in students
            join s in studentCourse on st.studentID equals s.studentID
            where s.courseID == course.courseID
            select st;
            sl.AddRange(query);
            

         return sl;
      }
      public List<Course> listStudentSchedule(Student student)
      {
         var courses = getCourses();
         var studentCourseList = getStudentCourseList();
         List<Course> list = new List<Course>();
         var query =
            from c in courses
            join scl in studentCourseList on c.courseID equals scl.courseID
            where scl.studentID == student.studentID
            select c;
         list.AddRange(query);
         return list;
      }
   }
}
