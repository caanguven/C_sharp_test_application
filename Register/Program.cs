// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

    // TO-DO 
    // Print options on command line 
    // Read the user input
    // Add New Student 
    // Query Existing Students 
    // 

namespace RegisterApplication{
    class Student {
        public string Name  { get; set; } 

        public string Email { get; set; } 

        public int Age { get; set; } 

        public Student(string name, string email, int age)
        {
            Name = name;
            Email = email;
            Age = age;
        }
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
                        // list_of_students.Add(new Student{Name = "Can", Email = "can@", Age = 22});
                        Console.WriteLine("New Student Can added");

                        break;
                    case "2":
                        DeleteStudent();
                        break;
                    case "3":
                        QueryStudent(list_of_students);

                        break;  
                    default:
                        Console.WriteLine("choose one of the options");
                        break;
                }
            }
        }

        static void AddNewStudent(){
            Console.WriteLine("Student Name");

            var name = Console.ReadLine();
            
            Console.WriteLine("Student email: ");
            var email = Console.ReadLine();

            int age;
            while(true){
                Console.WriteLine("Student age:");
                try{                
                    age = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch {
                    Console.WriteLine("Not a valid age please try again");
                }
            }

            list_of_students.Add(new Student(name,email,age));

            Console.WriteLine($"Name: {name} added");
        }

        static void DeleteStudent(){
                if (list_of_students.Count == 0){
                    Console.WriteLine("No students available");
                }

                Console.WriteLine("Enter the student name you want to delete");
                var student_name = Console.ReadLine();

                var find_students = list_of_students.FindAll(student => student.Name.Equals(student_name, StringComparison.OrdinalIgnoreCase));
                
                if (find_students.Count == 0){
                    Console.WriteLine($"There are no students with {student_name} Name");
                }

                else if (find_students.Count == 1){
                    list_of_students.Remove(find_students[0]);
                    Console.WriteLine($"Student {student_name} deleted");
                }

                else{   
                    Console.WriteLine($"Two student with same name, let's look for the email");
                    QueryStudent(find_students);
                    while(true){
                        Console.WriteLine("Enter the student EMAIL you want to delete");
                        var student_email = Console.ReadLine();
                        var find_students_email = list_of_students.FindAll(student => student.Email.Equals(student_email, StringComparison.OrdinalIgnoreCase));
                        if (find_students_email.Count == 0){
                                Console.WriteLine($"There are no students with {student_email} email");
                        }

                        else if (find_students_email.Count == 1){
                            list_of_students.Remove(find_students_email[0]);
                            Console.WriteLine($"Student with {student_email} email deleted");
                            break;
                        }
                    }
                }
        }

        static void QueryStudent(List<Student> list){
                if (list.Count == 0){
                    Console.WriteLine("No students available");
                }

                foreach (var student in list) {
                     Console.WriteLine($"Name: {student.Name}, Email: {student.Email}, Age: {student.Age}");
                }
        }
    }
}



