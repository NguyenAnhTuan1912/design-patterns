using CSharp.Classes;
using CSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Creational_Design_Patterns.Abstract_Factory_Pattern
{
    public class Student : Human, IInformation
    {
        public int Grade { get; set; }

        private Student(string name, string hobby, int age, int grade) : base(name, hobby, age) { 
            Grade = grade;
        } 

        public static Student GetNewStudent(string name, string hobby, int age, int grade)
        {
            return new Student(name, hobby, age, grade);
        }

        public void PrintInformation()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Hobby: {0}", Hobby);
            Console.WriteLine("Grade: {0}", Grade);
        }

        public override void Say()
        {
            Console.WriteLine("Hello, my name is {0}, a grade {1} student. I'm {2} years old. My hobby is {3}.", 
                Name, Grade, Age, Hobby
            );
        }
    }

    public class Worker : Human, IInformation
    {
        public int Salary { get; set; }

        private Worker(string name, string hobby, int age, int salary) : base(name, hobby, age)
        {
            Salary = salary;
        }

        public static Worker GetNewWorker(string name, string hobby, int age, int salary)
        {
            return new Worker(name, hobby, age, salary);
        }

        public void PrintInformation()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Hobby: {0}", Hobby);
            Console.WriteLine("Salary: {0}", Salary);
        }

        public override void Say()
        {
            Console.WriteLine("Hello, my name is {0}, a worker. I'm {1} years old. My hobby is {2}. I earn {3}tr each month.",
                Name, Age, Hobby, Salary
            );
        }
    }

    public class Athlete : Human, IInformation
    {
        public int NumOfMedals { get; set; }

        private Athlete(string name, string hobby, int age, int mumOfMedals) : base(name, hobby, age)
        {
            NumOfMedals = mumOfMedals;
        }

        public static Athlete GetNewAthlete(string name, string hobby, int age, int mumOfMedals)
        {
            return new Athlete(name, hobby, age, mumOfMedals);
        }

        public void PrintInformation()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Hobby: {0}", Hobby);
            Console.WriteLine("Number of Medals: {0}", NumOfMedals);
        }

        public override void Say()
        {
            Console.WriteLine("Hello, my name is {0}, an athlete. I'm {1} years old. My hobby is {2}. I earn {3} medals in my entire career.",
                Name, Age, Hobby, NumOfMedals
            );
        }
    }

    public abstract class AbstractPeopleFactory
    {
        public abstract Student CreateStudent(string name = "", string hobby = "", int age = 0, int grade = 1);
        public abstract Worker CreateWorker(string name = "", string hobby = "", int age = 0, int salary = 0);
        public abstract Athlete CreateAthlete(string name = "", string hobby = "", int age = 0, int numOfMedals = 0);
    }

    public class PeopleFactory : AbstractPeopleFactory
    {
        public override Student CreateStudent(string name = "", string hobby = "", int age = 0, int grade = 1)
        {
            return Student.GetNewStudent(name, hobby, age, grade);
        }

        public override Worker CreateWorker(string name = "", string hobby = "", int age = 0, int salary = 0)
        {
            return Worker.GetNewWorker(name, hobby, age, salary);
        }

        public override Athlete CreateAthlete(string name = "", string hobby = "", int age = 0, int numOfMedals = 0)
        {
            return Athlete.GetNewAthlete(name, hobby, age, numOfMedals);
        }
    }
}
