// See https://aka.ms/new-console-template for more information

using System;
namespace Arrays
{
    class Program
    {

        static void Main(string[] args)
        {
            // Single Dim. Array
            // 1.declaration 
            string[] friends = new string[5];
            // 2.Accessing Element 
            friends[0] = "Habiba";
            Console.WriteLine(friends[0]); 
            // 3.Initialization 
            // Version
            string[] friends2 = new string[5]
            {
                "Habiba",
                "Mahmoud",
                "Muhammad",
                ";;;;",
                "jdjdj"
            };
            // Version 2
            string[] friends3 ={
                "Habiba",
                "Mahmoud",
                "Muhammad",
                ";;;;",
                "jdjdj"
            };
            //version 3 
            var friends4 = new string[]
            {
                "Hello",
                "Welcome",
                "Muhammad",
                "new",
                "World"
            };


            /*************************************************************/
            // Multi Dim Array (rectangular array)
            int[,] suduko = 
            {
                {1,2,3,4},
                {5,6,7,8},
                {9,10,11,12},
                {13,14,15,16}
            };
            /*****************************************************/
            // Jagged Array ( Array inside array)
            var jagged = new int [][]
            {
                new int[] {1,2},
                new int[] {2,5,6},
                new int[] {7}
            };
            // Indices and ranges
            /** f[..2] --> first two and skip the last, f[2..] --> skip first 2 and give the last
            f[^1] --> gives the last one, f[1..2] --> starting from 1 and and take till 2
            */
            var sliceall = ..; // gives all array 
            var slicerange = 1..^2; 
            var slice1 = friends4[2..];
            var slice2 = friends4[slicerange];

            Console.WriteLine(String.Join(" ",slice1));
            Console.WriteLine(String.Join(" ",slice2));
            

        }
    }
}
