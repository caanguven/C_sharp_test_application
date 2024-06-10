// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace RegisterApplication{
    class Student {
        public string Name  { get; set; } 

        public string Email { get; set; } 

        public int Age { get; set; } 
    }

    class Register {

        static List<Student> list_of_students = new List<Student>();


    
        static void Main(string[] args) {
            list_of_students.Add(new Student{Name = "Can", Email = "can@", Age = 22});

            foreach (var student in list_of_students) {
                Console.WriteLine($"Name: {student.Name}, Email: {student.Email}, Age: {student.Age}");
            }

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
