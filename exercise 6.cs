using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Test
{
    //Answer 6
    public abstract class Person
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public abstract string PrintDetails();
    }
    public class Student : Person
    {
        public string Grade { get; set; }
        public override string PrintDetails()
        {
            return "My name is: "+Name+"and my id is: " + Id+"and my grade is: " + Grade;
        }
    }
    internal class exercise_6
    {
        public void Run()
        {
            Student student = new Student();
            student.Name = "shani";
            student.Id = 123;
            student.Grade = "lehava";
            string details = student.PrintDetails();
        }
    }
}
