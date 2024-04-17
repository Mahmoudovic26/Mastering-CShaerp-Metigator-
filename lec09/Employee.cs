using System;
namespace Lec09oop
{
    // <Class Modifier> -< public,internal (default)
    // <Class Modifier> class <Class name>
    //{
    // class block (body)
    //}
    public class Employee
    {
        // Constant -> <Access Modifiers> <data type> <field name>  = <value>;
        // Static can be changed after initialization stored in high frequency heap
        public static double TAX = 0.03;

        // Fields --> <Access Modifiers> <data type> <field name>  = <Initial value>;
        //<Access Modifiers> public, private, protected, internal ,unsafe 
        public string FName = "";
        public string LName = "";
        public double Wage = 0.0;
        public double LoggedHours = 0.0;

        private double Calculate()  =>  Wage*LoggedHours;

        private double CalculateTax() => Calculate() * TAX;
        
        private double CalculateNet() => Calculate() - CalculateTax();
        
        public string printSlip()
        {
           return  $"\n First Name: {FName}\n Last Name: {LName} \n Wage: {Wage} \n logged hours: {LoggedHours}\n Taxes: {CalculateTax()} \nSalary: {CalculateNet()} ";
        }

    }




}