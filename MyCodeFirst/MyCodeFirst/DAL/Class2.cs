using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MyCodeFirst.Models;
using System.Diagnostics;

namespace MyCodeFirst.DAL
{
    public class Class2 : System.Data.Entity.DropCreateDatabaseIfModelChanges<Class1>
    {
        protected override void Seed(Class1 context)
        {
            var students = new List<Student>
            {
            new Student{FirstMidName="test",LastName="1"},
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            
            var enrollments = new List<Unit>
            {
            new Unit{Name="fit5032",Description="test unit"},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}