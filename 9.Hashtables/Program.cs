using System;
using System.Collections;//necessário para usar hashtables

namespace _9.Hashtables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable studentsTable = new Hashtable();
            Student stud1 = new Student(1, "Maria", 98);
            Student stud2 = new Student(2, "Jason", 76);
            Student stud3 = new Student(3, "Clara", 43);
            Student stud4 = new Student(4, "Steve", 55);
            studentsTable.Add(stud1.Id, stud1);
            studentsTable.Add(stud2.Id, stud2);
            studentsTable.Add(stud3.Id, stud3);
            studentsTable.Add(stud4.Id, stud4);
            //(serve para acessar o id 1 da hash table, porém só funciona pq foi especificada em (Student) que o studentsTable[1] era do tipo objeto (Retrieve individual item with known ID)
            Student storedStudent1 = (Student)studentsTable[1];
            Console.WriteLine("Student ID: {0}, Name:{1}, GPA:{2}", storedStudent1.Id, storedStudent1.Name, storedStudent1.GPA);
            Console.WriteLine("///////////////////////////////////////////");
            //retrieve all values from a Hashtable
            foreach (DictionaryEntry entry in studentsTable)
            {
                Student tempValue = (Student)entry.Value;//converte no tipo objeto Student
                Console.WriteLine("Student ID: {0}", tempValue.Id);
                Console.WriteLine("Student Name: {0}", tempValue.Name);
                Console.WriteLine("Student GPA: {0}", tempValue.GPA);
            }
            foreach (Student value in studentsTable.Values)//.Values permite que você acesse o valor diretamente sem precisar converter os valores em objeto aluno(como na linha 26)
            {
                Console.WriteLine("Student ID: {0}", value.Id);
                Console.WriteLine("Student Name: {0}", value.Name);
                Console.WriteLine("Student GPA: {0}", value.GPA);
                //o mesmo resultado só que sem precisar converter
            }
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
