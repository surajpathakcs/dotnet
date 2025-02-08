using System;

namespace DayFour
{
    class Program{
        static void Main()
        {
            string str = "hello";
            Console.WriteLine(str.ReverseString()); 

            string str2 = "hii there, this is c#";
            Console.WriteLine(str2.ToTitleCase());  // Output: "Hello World, This Is C#"

            string str3 = "A Quick Brown Fox Jump Over a Very Lazy Dog.";
            Console.WriteLine(str3.GetVowels());
        
            DateTime dateofbirth = new DateTime(2002,01,12);
            Console.WriteLine(dateofbirth.GetAge());
        }
    

  }
}