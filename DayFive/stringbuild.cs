using System;
using System.Text;
namespace DayFive
{



    public static class StringBuildClass
    {
        public static void CreateSentence()
        {

            //Use StringBuilder to create a sentence by appending words
            StringBuilder sb = new StringBuilder();

            Console.WriteLine("Enter text (Press Ctrl+D to stop):");

            string input;
            while ((input = Console.ReadLine()) != null)  // Ctrl+C sends EOF (null)
            {
                sb.Append(input + " ");
            }

            Console.Write(sb.ToString());
        }



        //Write a method that takes a list of names and generates a comma-separated string using StringBuilder. [‘A’, ‘B’, ‘C’] => “A,B,C”
        public static string separateComma()
        {
            List<string> names = new List<string>();
            StringBuilder sb1 = new StringBuilder();
            string input;
            while (!string.IsNullOrEmpty(input = Console.ReadLine()))
            {
                names.Add(input);
            }

            for (int i = 0; i < names.Count; i++)
            {
                sb1.Append(names[i]);
            }

            return string.Join(",", names);


        }




        /*
        Build a simple Markdown-to-HTML converter using StringBuilder
            https://www.markdownguide.org/basic-syntax/
            Headings
            Paragraphs
            Line Breaks
            Emphasis
            Blockquotes
            Lists
            Code
            Horizontal Rules
            Links
            Images
        */
















    }
}
