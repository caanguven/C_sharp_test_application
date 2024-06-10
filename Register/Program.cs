// See https://aka.ms/new-console-template for more information
using System;

namespace RegisterApplication{
    class Student {
        public string Name  { get; set; } 

        public string Email { get; set; } 

        public int Age { get; set; } 
    }

    class Register {

        static List<Student> list_of_students = new List<Student>();

        // list_of_students.Add(new Student{Name = "Can", Email = "can@", Age = 22});

    
        static void Main(string[] args) {
            Console.WriteLine(list_of_students);
        }

        static void AddNewStudent(){

        }

        static void DeleteStudent(){

        }

        static void QueryStudent(){

        }

        
    // TO-DO 
    // Print options on command line 
    // Read the user input
    // Add New Student 
    // Query Existing Students 
    // 
    }
}
