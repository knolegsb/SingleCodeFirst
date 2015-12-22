using SingleCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SingleCodeFirst.DAL
{
    public class StudentInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<StudentContext>
    {
        protected override void Seed(StudentContext context)
        {
            var students = new List<Student>
            {
                new Student { Name="Sean You", StudentId=1, Grade=Grade.A, Status= true}
            };
            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
        }
    }
}