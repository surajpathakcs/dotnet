using System;

namespace dayone{
//I: Write a program to find the maximum and minimum values in a list of integers.
    public class MaxMin{

        public MaxMin(){
            List<int> integers = new List<int>{88, 38, 23, 54, 34, 21, 49, 43, 590, 3945, 223, 234, 589, 190 , 892};
            var low=10000000;
            var high=0;

            foreach(var num in integers){
                if(num>high) high = num;
                if(num<low) low = num;
            }
            Console.WriteLine("Lowest number in List : "+low);
            Console.WriteLine("Highest number in List : "+high);
        }

    }

}