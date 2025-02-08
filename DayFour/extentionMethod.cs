using System;

namespace DayFour
{
    public static class StringExtensions  
    {
        // Create an extension method ReverseString() for string that returns the reversed string.“hello”.ReverseString() => “olleh”

        public static string ReverseString(this string str)  
        {
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    //Implement an extension method ToTitleCase() for string that capitalizes the first letter of each word.
        public static string ToTitleCase(this string str){
            string[] words = str.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);               
            }
            return string.Join(" ",words);
        }


        //Level 3
        //Create an extension method GetVowels() for string that returns all vowels in a given string.

        public static string GetVowels(this string str){
            char[] chars = str.ToCharArray();
            char[] vowels = {'a','e','i','o','u','A','E','I','O','U'};
            List<char> resultVowels = new List<char>();

            for(int i =0 ; i < chars.Length; i++){
                for(int j =0 ; j < 10; j++){
                    if(chars[i]==vowels[j]){
                        resultVowels.Add(chars[i]);
                   }
                }
            }
            return string.Join(" ",resultVowels);
        }

        //Create an extension method for DateTime (DateOfBirth), that returns the current age.

        public static int GetAge(this DateTime dob){
            int age;
            DateTime today = DateTime.Now;  

            age = today.Year - dob.Year;  

            return age;
        }


        








    }


    
}
