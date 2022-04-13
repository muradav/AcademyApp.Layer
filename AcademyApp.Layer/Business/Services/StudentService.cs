using Business.Interfaces;
using DataAccess.Repositories;
using Entities.Models;
using System.Collections.Generic;

namespace Business.Services
{
    public class StudentService : IStudent
    {
        public static int Count { get; set; }
        private StundentRepository _studentRepository;
        public StudentService()
        {
            _studentRepository = new StundentRepository();
        }

        public Student Create(Student Student)
        {
            Student.Id = Count;

            _studentRepository.Create(Student);
            Count++;
            return Student;

        }

        public Student Delete(int Id)
        {
            Student isExist = _studentRepository.GetOne(g => g.Id == Id);
            if (isExist == null)
            {
                return null;
            }
            _studentRepository.Delete(isExist);
            return isExist;
        }

        public Student GetStudent(string name)
        {
            return _studentRepository.GetOne(g => g.Name == name);
        }

        public Student Update(int Id, Student Student)
        {
            Student isExsit = _studentRepository.GetOne(g => g.Id == Id);
            if (isExsit == null)
            {
                return null;
            }
            _studentRepository.Update(isExsit);
            return isExsit;
        }

        public List<Student> GetAll()
        {
            return _studentRepository.GetAll();
        }

        public Student GetStudent(int id)
        {
            return _studentRepository.GetOne(g => g.Id == id);
        }



    }
}
