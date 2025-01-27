using System;
namespace dayone
{
    //A: Implement a function that accepts a list of strings and returns a new list with duplicates removed.

    public class StringToList
    {
        public void stringToListConverter()
        {
            string str;
            List<string> list = new List<string>();
            List<string> final = new List<string>();

            Console.WriteLine("Enter the strings ");

            while(true){
                str = Console.ReadLine();
                if(str.ToLower()=="done") break;
                list.Add(str);
            }




            foreach (string input in list)
            {
                if (!final.Contains(input))  
                {
                    final.Add(input);  
                }
            }

            Console.WriteLine("\nUnique strings:");
            foreach (string s in final)
            {
                Console.WriteLine(s);
            }




        }

    }

}