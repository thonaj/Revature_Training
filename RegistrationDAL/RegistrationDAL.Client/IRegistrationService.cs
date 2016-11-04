using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using RegistrationDAL.Client;
using RegistrationClient.Models;

namespace RegistrationDAL.Client
{
   
   [ServiceContract]
   public interface IRegistrationService
   {

      [OperationContract]
      List<CourseDAO> getCourses();
      [OperationContract]
      List<StudentDAO> getStudents();
      [OperationContract]
      List<StudentCourseListDAO> getStudentCourseList();
      [OperationContract]
      bool insertCourse(CourseDAO course);
      [OperationContract]
      bool insertStudent(StudentDAO student);
      [OperationContract]
      bool insertStudentCourseList(StudentCourseListDAO scl);
      [OperationContract]
      bool updateCourse(CourseDAO course);
      [OperationContract]
      bool deleteCourse(CourseDAO course);
      [OperationContract]
      bool updateStudent(StudentDAO student);
      [OperationContract]
      bool deleteStudent(StudentDAO student);
      [OperationContract]
      bool updateStudentCourseList(StudentCourseListDAO scl);
      [OperationContract]
      bool deleteStudentCourseList(StudentCourseListDAO scl);
      [OperationContract]
      bool registerCourse(StudentDAO student, CourseDAO course);
      [OperationContract]
      bool dropCourse(StudentCourseListDAO scl);
      [OperationContract]
      bool scheduleCourse(CourseDAO course);
      [OperationContract]
      bool cancelCourse(CourseDAO course);
      [OperationContract]
      bool modifyCourseTime(CourseDAO course, TimeSpan start, TimeSpan end);
      [OperationContract]
      bool modifyCourseCapacity(CourseDAO course, int capacity);
      [OperationContract]
      List<StudentDAO> listEnrolledStudents(CourseDAO course);
      [OperationContract]
      List<CourseDAO> listStudentSchedule(StudentDAO student);
    


   }


   
   
}
