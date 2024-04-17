using System;
namespace CATroubleshooting 
{
    class Pogram
    { 
        static void Main(string[] args)
        {
            var amount = 1000;
            var members = 4;
            var c = ConvertFehrenhiteToCelsius(32);
            var f = ConvertCelsiusToFehrenhite(0);
            members = Reduce(members,2);
            var share = Distribute(amount,members);
            //System.Console.WriteLine(share);
            System.Console.WriteLine(f);
            System.Console.WriteLine(c);
        }
        static int Reduce(int membrs, int value)
        {
            return membrs -= value;
        }

        static int Distribute(int amount, int members)
        {
            try 
            {
                return amount/members; //ex:1000/2 => 500/month

            }
            catch(Exception ex)
            {
                // in case exception occurred do the following 
                System.Console.WriteLine($"Unexpected Error:{ex.Message}");

            }
            finally
            {
                // Cleanups 
            }
            return 0;

        }
        static decimal ConvertCelsiusToFehrenhite(decimal celsius)
        {
            var fehrenhite = 0m;
            fehrenhite = (celsius*9/5)+32;
            return fehrenhite;
        }
        static decimal ConvertFehrenhiteToCelsius(decimal fehrenhite)
        {
            var celsius = 0m;
            celsius = (fehrenhite-32)*5/9;
            return celsius;
        }
    }
}