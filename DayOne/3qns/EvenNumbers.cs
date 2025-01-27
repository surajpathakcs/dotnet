using System;
namespace dayone
{
    public class EvenNumbers
    {
        //B: Create a list of integers, add numbers to it, and print only the even numbers.
        public EvenNumbers()
        {

            List<int> integers = new List<int> { 2, 3, 4, 5, 6, 7, 8, 8, 10, 11, 14, 16, 19, 21, 32, 35, 48, 69, 90, 265 };

            foreach (var num in integers)
            {
                if (num % 2 == 0) Console.WriteLine(num);
            }

            Console.WriteLine("Program Ended");
        }
    }

}
