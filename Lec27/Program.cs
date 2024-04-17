using System;
namespace CAXMLDocumentation
{
    partial class Program
    {
        static void Main(string[] args)
        {
            do
            {
                System.Console.Write("First Name:");
                var fname = Console.ReadLine();

                System.Console.Write("Last Name:");
                var lname = Console.ReadLine();

                System.Console.Write("Hire Date:");
                DateTime? hdate = null;
                if (DateTime.TryParse(Console.ReadLine(), out DateTime hDate))
                {
                    hdate = hDate;
                }
                var empid = Generator.GenerateId(fname, lname, hdate);
                var randomPassowrd = Generator.GenerateRandomPassword(8);
                System.Console.WriteLine($"{{\n Id: {empid}, \n FName: {fname}, \n LName: {lname}, \n Hire Date: {hdate}, \n Password: {randomPassowrd}\n}}");
            } while (true);

        }
    }
}