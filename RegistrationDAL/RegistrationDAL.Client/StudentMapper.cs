using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistrationDAL;
using RegistrationClient.Models;

namespace RegistrationDAL.Client
{
   public class StudentMapper
   {
      public Student MapToStudent(StudentDAO student)
      {
         var s = new Student();
         s.firstName = student.firstName;
         s.middleName = student.middleName;
         s.lastName = student.lastName;
         s.major = student.major;
         s.studentID = student.studentID;
         s.active = student.active;
         
         return s;
      }
      public StudentDAO MapToStudentDAO(Student student)
      {
         var s = new StudentDAO();
         s.firstName = student.firstName;
         s.middleName = student.middleName;
         s.lastName = student.lastName;
         s.major = student.major;
         s.studentID = student.studentID;
         s.active = student.active;

         return s;
      }
   }
}
