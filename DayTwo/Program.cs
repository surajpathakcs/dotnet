using System;
namespace daytwo
{

    public class Program
    {
        public class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Gender { get; set; }
        }
        public static void Main(string[] args)
        {
            List<Person> personList = new List<Person>{
            new Person { Id = 1 , Name = "Ebstein" , Gender ="male"},
            new Person { Id = 2 , Name = "Abby" , Gender ="female"},
            new Person { Id = 3 , Name = "Vijay" , Gender ="male"},
            new Person { Id = 4 , Name = "Lua" , Gender ="female"},
            new Person { Id = 5 , Name = "Lily" , Gender ="female"},
         };

            foreach (var person in personList)
            {
                Console.WriteLine("ID : " + person.Id + " \tName : " + person.Name + " \tGender : "+person.Gender);
            }

            Distinguish(personList);


        }

        static void Distinguish(List<Person> personList){
            List<Person> malePerson = new List<Person>{};
            List<Person> femalePerson = new List<Person>{};

            foreach(var person in personList){
                if(person.Gender=="male") malePerson.Add(person);
                else femalePerson.Add(person);
            }

            Console.WriteLine("Male Person List");
            foreach(var person in malePerson){
                Console.WriteLine("ID : " + person.Id + " \tName : " + person.Name + " \tGender : "+person.Gender);
                
            }
            Console.WriteLine("Female Person List");
            foreach(var person in femalePerson){
                Console.WriteLine("ID : " + person.Id + " \tName : " + person.Name + " \tGender : "+person.Gender);
                
            }

        }
    }

}