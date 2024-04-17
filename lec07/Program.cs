// See https://aka.ms/new-console-template for more information
using System;
using System.Data;
namespace lec07
{
    class Program
    {
         static void Main(string[] args)
        {   System.Console.WriteLine();
            // Everything in dotnet is an Object
            // object --> Class
            // Note that the alias written by blue while the main object green
            int x; // = Int32 because int is an alias 
            Int32 xx;
            short y; // Int16 
            Int16 yy;
            long z; // Int64
            Int64 zz;
            ushort k;
            UInt16 kk;// unsigned short 
            int numberint  = 100;
            long numberlong = numberint ;// implicit Casting
            long nl = 1000;
            int nI = (int)nl; // Explicit Casting 
            //--------------------
            //Boxing and Unboxing 
            // Boxing--> Converting from value datatype into reference datatype
            int val =10; // Value type
            Object obj; // Reference Type
            obj = val; // Conversion done implicitly 
            // Unboxing--> From value type to Reference Type 
            int vali = (int)obj; // Explicit  Casting

            //Convert from strings to nums
            // 1) type.parse() -- int.parse() -- double.parse() #high_performance  
            string stringval = "5555";
            int numberst = int.Parse(stringval);
            // To avoid Exceptions may occurs when using .parse we use TryParse
            string TP = "W152";
            if(int.TryParse(TP, out int num))
            {
                System.Console.WriteLine(num);
            }
            else 
            {
                System.Console.WriteLine("Invalid number :)");
            }
            // 2) convert class Convert.(any datatype)
            var i = Convert.ToInt32(stringval);
            System.Console.WriteLine(i);
            //-----------
            //Bit converter 
            var numberbit = 255;
            var bytess = BitConverter.GetBytes(numberbit);
            foreach (var b in bytess)
            {
                var binaryy = Convert.ToString(b,16).PadLeft(8,'0'); //convert --> PadLeft to make it 8 digits but if has nothing put 0
                System.Console.WriteLine(binaryy);
            }
            var name = "Mahmoud";
            char[] letters = name.ToCharArray();
            foreach(var l in letters)
            {
                int ascii = Convert.ToInt32(l);
                var result = $"'{l}'-> ASCII: {ascii}, Binary:{Convert.ToString(ascii,2).PadLeft(8,'0')}, Hex: {ascii:x}";
                System.Console.WriteLine(result);
            }
            string[] hexvals = {"4d", "61", "68", "6d", "6f", "75", "64"};
            foreach (var hexx in hexvals)
            {
                int valhex = Convert.ToInt32(hexx,16);
                var stringVal = char.ConvertFromUtf32(valhex); // to convert to string
                var ch = (char)valhex; // To convert to chars 
                System.Console.WriteLine(stringVal);
                System.Console.WriteLine(ch);
            }
            var hexa = "8E2";
            int nn = Int32.Parse(hexa,System.Globalization.NumberStyles.HexNumber); //To convert hex string to int
            System.Console.WriteLine(nn);
            Console.ReadKey();
        }   


    }
}