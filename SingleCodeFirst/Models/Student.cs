using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SingleCodeFirst.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public Grade? Grade { get; set; }        
    }

    public enum Grade
    {
        A, B, C, D, F
    }
}