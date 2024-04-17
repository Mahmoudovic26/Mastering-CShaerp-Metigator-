using System;
namespace Lec08oop
{
    // <Class Modifier> -< public,internal (default)
    // <Class Modifier> class <Class name>
    //{
    // class block (body)
    //}
    public class Employee
    {
        // Constant -> <Access Modifiers> <data type> <field name>  = <value>;
        public const double TAX = 0.03;

        // Fields --> <Access Modifiers> <data type> <field name>  = <Initial value>;
        //<Access Modifiers> public, private, protected, internal ,unsafe 
        public string FName = "";
        public string LName = "";
        public double Wage = 0.0;
        public double LoggedHours = 0.0;

    }




}