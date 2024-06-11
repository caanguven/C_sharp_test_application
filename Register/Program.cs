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

            while(true){
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Delete Student");
                Console.WriteLine("3. Query Student");

                var response = Console.ReadLine();
                switch(response){

                    case "1": 
                        AddNewStudent();
                        break;
                    case "2":
                        DeleteStudent();
                        break;
                    case "3":
                        QueryStudent();
                        break;  
                    default:
                        Console.WriteLine("choose one of the options");
                        break;
                }
            }
                // list_of_students.Add(new Student{Name = "Can", Email = "can@", Age = 22});
                // foreach (var student in list_of_students) {
                //     Console.WriteLine($"Name: {student.Name}, Email: {student.Email}, Age: {student.Age}");
                // }

        }

        static void AddNewStudent(){
            Console.WriteLine("Add New Student");
        }

        static void DeleteStudent(){
            Console.WriteLine("Delete Student");

        }

        static void QueryStudent(){
            Console.WriteLine("Query Student");

        }

    // TO-DO 
    // Print options on command line 
    // Read the user input
    // Add New Student 
    // Query Existing Students 
    // 
    }
}
