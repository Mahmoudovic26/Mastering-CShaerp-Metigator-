using System;
namespace CAEnums
{
    class Program
    {
        static void Main(string[] args)
        {

                foreach (var monthh in Enum.GetNames(typeof(Month)))
                {
                    System.Console.WriteLine($"{monthh} = {(int)Enum.Parse(typeof(Month),monthh)}");
                }
            var dayy = "FEB";
            var mm = 2;
            if(Enum.IsDefined(typeof(Month),mm))
            {
                System.Console.WriteLine((Month)mm);
            
            }
            if(Enum.IsDefined(typeof(Month),dayy))
            {
                System.Console.WriteLine(Enum.Parse(typeof(Month),dayy));
            }
            if(Enum.TryParse(dayy,out Month month))
            {
                System.Console.WriteLine(month);
            }

            System.Console.WriteLine(Enum.Parse(typeof(Month),dayy));
            System.Console.WriteLine((int)Month.FEB);
            var day  = (Day.SAT | Day.SUN);
            if(day.HasFlag(Day.WEEKEND))
            {
                System.Console.WriteLine("Enjoy your Weekend :)" );
            }
        }
    }
    enum Month : int//Default it is int but we can explicitly change its datatype
    {
        Jan=1,
        FEB,
        MAR,
        APR,
        MAY,
        JUN,
        JUL,
        AUG,
        SEP,
        OCT,
        NOV,
        DEC
    }
    [Flags]
    enum Day
    {
        NONE = 0b_0000_0000, //Zero in binary
        MON = 0b_0000_0001, //1
        TUE = 0b_0000_0010, //2
        WED = 0b_0000_0100, //4
        THR = 0b_0000_1000, //8
        FRI = 0b_0001_0000, //16
        SAT = 0b_0010_0000, //32
        SUN = 0b_0100_0000, //64
        BUSSDAY = MON | TUE | WED | THR |FRI,
        WEEKEND = SAT |SUN //0b_0010_0000 | 0b_0110_0000
    }
}