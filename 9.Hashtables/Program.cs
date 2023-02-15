using System;

namespace _9.Hashtables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");            
        }
        class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public float GPA { get; set; }
            public Student(int id, string name, float GPA)
            {
                this.Id = id;
                this.Name = name;
                this.GPA = GPA;
            }
        }
    }
}
