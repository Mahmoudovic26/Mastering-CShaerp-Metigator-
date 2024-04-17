// Free Palestine 
// See https://aka.ms/new-console-template for more information
using System;

namespace expressionss
{
    class Program 
    {
        static void Main(string[] args)
        {   
            // primary expression --> return  value 
            var angle = Math.Cos(30);
            // Void expression --> return void 
            Console.WriteLine(angle);
            // Assign expression 
            var x = 2;
            x = x + 10;
            //------------------
            var s1 = "";
            var s2 = "1";
            var s3 = s1 = s2 = "Mahmoud";
            Console.WriteLine(s1); // Mahmoud 
            var s4 = s1 == s2? "Mahmoud" : "Muhammad"; // if s1 == s2 print Mahmoud else print Muhammad
            string s5 = null;
            var s6 = s5?.ToUpper(); // s5? --> means to check if it is not null give it to ToUpper otherwise return null
            s5 = s5 ?? "Habiba"; // ?? check if it is null assign with the value "Habiba"
            Console.WriteLine(s5);
            Console.WriteLine(s4);
            //------------------------
            // expression statement 
            var name = "Mahmoud";
            //1. Change statement 
            name = name + "A.";
            // 2. Call something to change the statement 
            name = name.ToUpper();
            Console.WriteLine(name);
            // 4. Increment / Decrement 
            var totf = 150;
            ++totf;
            Console.WriteLine(totf);
            --totf;
            Console.WriteLine(totf);
            // 5. object instantiation 
            Object o = new object();
            // selection statement if,if else ,switch 
            var mark = 90;
            if(mark >= 85)
            {
                Console.WriteLine("Excellent:");
            }
            else if(mark >=59)
            {
                Console.WriteLine("Pass:");
            }
            else
                System.Console.WriteLine("Fail");
            // switch 
            var amountJOD = 100;
            var currType = "CAD";
            var output = 0d;


            var JODTOUSD = 1.41d;
            var JODTOEUR = 1.19d;
            var JODTOCAD = 1.78d;
            switch(currType)
            {
                case "USD":
                    output = amountJOD * JODTOUSD;
                    break;
                case "EUR":
                    output = amountJOD * JODTOEUR;
                    break;
                case "CAD":
                    output = amountJOD * JODTOCAD;
                    break; 
                default:
                    Console.WriteLine("Unknown Currency :)");
                    break;
            }
            Console.WriteLine($"{amountJOD} JOD = {output} {currType}");



            object ob = 3;
            switch(ob)
            {
                case int i:Console.WriteLine($"It is ibt, sqr of{i}={i*i}");
                break;
                case string i:Console.WriteLine($"it is string, Capitalization of {i} = {i.ToUpper()}");
                break;
            }
            bool isVip  =  true;
            switch(isVip)
            {
                case bool i when i == true: // Condition in switch 
                System.Console.WriteLine("Yes");
                break;
                case bool i:
                System.Console.WriteLine("No");
                break;
            }
            var cardnum  = 1 ;
            string cardname = cardnum switch
            {
                1 => "ACE", // => lambda operator 
                13 => "King",
                12 => "Queen",
                10 => "Jack",
                
                _ => cardnum.ToString() // _ => wild card 
            }; 
            // switch cases is ace,king, queen and Jack
            Console.WriteLine(cardname);
            int counter;
            counter = 10;
            while(counter>0){
                System.Console.Write(counter +" ");
                counter--;
            }
            counter = 0;
            do
            {

                System.Console.Write(counter + " ");
                counter++;
            }while(counter <= 10);
            //Fibonacci [0,1,1,2,3,5,8,13,21,34,.....]
            System.Console.WriteLine("--------------------");
            uint prev= 0 ,current = 1;
            for(uint i = 0;i<=10;++i)
            {
                System.Console.WriteLine(prev + " ");
                uint newfib = prev + current;
                prev = current; 
                current  = newfib;
            }
            foreach (char c in "Full stack Developer Course \n")
            {
                System.Console.Write(c + "");
            }

            // Jump statement [break , Continue , goto and return]

            for (int j = 0; j < 10; j++) 
            {
                if(j % 2 ==0)
                    continue; // Will continue the loop without printing even numbers 
                System.Console.Write(j + " ");
            }
            System.Console.WriteLine();
            for (int k = 0; k < 10; k++)
            {
                if(k % 2 !=0)
                    continue; // Will continue the loop without printing odd numbers
                System.Console.Write(k + " ");
            }
            int ll = 0;
            start:
            if(ll<=5)
            {
                System.Console.WriteLine(ll + " ");
                ++ll;
                goto start; // will go to start again 
                //  if there is a code here will never be executed 
            }

            var input = 0.44m;
            var result  = Aspercentage(input);
            System.Console.WriteLine(result + "%");

            Console.ReadKey();
            
        } 
        static decimal Aspercentage(decimal amount)
        {
            return amount * 100;
        }
    }        
}