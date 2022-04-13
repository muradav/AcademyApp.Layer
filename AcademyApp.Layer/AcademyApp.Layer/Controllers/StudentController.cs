using Business.Services;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Utilities.Helper;

namespace AcademyApp.Layer.Controllers
{
    public class StudentController
    {
        private StudentService studentService;
        public StudentController()
        {
            studentService = new StudentService();
        }
        public void CreateStudent()
        {
            Console.Clear();
        EnterName:
            Extention.Print(ConsoleColor.Green, $"Student Name");
            string name = Console.ReadLine();

            Extention.Print(ConsoleColor.Green, $"Student Surname");
            string surname = Console.ReadLine();          
                       
            
                Student student = new Student
                {
                    Name = name,
                    Surname=surname
                };

                studentService.Create(student);
                Extention.Print(ConsoleColor.Green, $"{student.Name} {student.Surname} added");
           
        }
        public void GetAllStudent()
        {

            Console.Clear();

            foreach (var item in studentService.GetAll())
            {
                Extention.Print(ConsoleColor.Yellow, $"{item.Name}");
            }
        }
        public void RemoveStudent()
        {
            Console.Clear();
            Extention.Print(ConsoleColor.Green, "Please enter ID");
            int id = int.Parse(Console.ReadLine());
            Extention.Print(ConsoleColor.Green, $"{studentService.Delete(id).Name}");

        }
        public void GetStudent()
        {
            Console.Clear();
            Extention.Print(ConsoleColor.Green, "Please enter Student ID");
            int id = int.Parse(Console.ReadLine());
            Extention.Print(ConsoleColor.Green, $"{studentService.GetStudent(id).Name}");
        }
        public void Update()
        {
            Console.Clear();
        UpdateStudent:
            Extention.Print(ConsoleColor.Green, "Please enter Student ID");

            string StudentId = Console.ReadLine();
            int id;
            Extention.Print(ConsoleColor.Green, "Please enter new Student name");
            string name = Console.ReadLine();
            Extention.Print(ConsoleColor.Green, "Please enter new Student surname");
            string surname = Console.ReadLine();

            bool isId = int.TryParse(StudentId, out id);
            if (isId)
            {
                Student Student = new Student
                {
                    Name = name,
                    Surname=surname
                };
                studentService.Create(Student);
                Extention.Print(ConsoleColor.Green, $"Student Name changed to {studentService.Update(id, Student).Name}");
            }
            else
            {
                Extention.Print(ConsoleColor.Red, "Try Again!");
                goto UpdateStudent;
            }



        }
    }
}
