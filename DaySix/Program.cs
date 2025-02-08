using System;
using System.Collections.Generic;
using System.Linq;

namespace DaySix
{
    class Program
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>(){
                new Employee{Name = "Krisha" , Age= 20},
                new Employee{Name ="Sudipa" , Age=28},
                new Employee{Name ="Krisha" , Age=31},
                new Employee{Name ="Arzan" , Age=43},
                new Employee{Name ="Ankit" , Age=50}
            };

            var olderThan30 = employees.Where(e => e.Age > 30).Select(e => e.Name).ToList();
            Console.WriteLine("Older Than 30 are");
            foreach (var od in olderThan30)
            {
                Console.WriteLine(od);
            }

            //Use LINQ to create a new list with only even numbers

            List<int> numbers = new List<int> {10,13,9,6,24 , 32 ,21 , 89 ,76, 55 , 63 , 9 , 23 , 54 , 32 };
            List<int> EvenNumbers = new List<int>();

            foreach (var number in numbers){
                if(number%2==0){
                    EvenNumbers.Add(number);
                }
            }
            foreach (var number in EvenNumbers){
                Console.Write(number + " ");
            }


            //Get a list of students and sort by name in descending order
            List<Student> students = new List<Student>(){
                new Student{Name ="Anish",Age = 19},
                new Student{Name ="Bibas",Age = 20},
                new Student{Name ="Roshan",Age = 21},
                new Student{Name ="Ashish",Age = 20},
                new Student{Name ="Rabi",Age = 21},
            };

            students.Sort((a,b) => b.Name.CompareTo(a.Name));
            Console.WriteLine("\n\nSorted Names List in Descending Order");
            foreach(var name in students)
                Console.WriteLine(name.Name);        
        
        
        }


    }

}