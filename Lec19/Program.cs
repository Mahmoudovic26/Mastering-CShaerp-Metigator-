using System;
namespace CAStructVsClass
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt =new DateTime(2024,10,26,08,30,10);
            dt = dt.AddDays(10);
            System.Console.WriteLine(dt);
            Students st = new Students();
            st.Show();
            DigitalSize dz = new DigitalSize(6000);
            dz = dz.AddBit(16); //means new object (immutable )
            System.Console.WriteLine(dz.Bit);
            System.Console.WriteLine(dz.Byte);
            System.Console.WriteLine(dz.KB);
            System.Console.WriteLine(dz.MB);
            System.Console.WriteLine(dz.GB);
            System.Console.WriteLine(dz.TB);
        }
        readonly struct Age
        {
            public Age(int years, int whatever)
            {
                this.years = years;
                this.whatever = whatever;
            }
            public readonly int years;
            public readonly int  whatever;
        }
    }

    struct DigitalSize
    {
        private long bit;
        public string Bit => $"{(bit/bitsInBit):N0} Bit";
        public string Byte => $"{(bit/bitsInBytes):N0} Byte";
        public string KB => $"{(bit/bitsInKB):N0} KB";
        public string MB => $"{(bit/bitsInMB):N0} MB";
        public string GB => $"{(bit/bitsInGB):N0} GB";
        public string TB => $"{(bit/bitsInTB):N0} TB";

        private const long bitsInBit = 1;
        private const long bitsInBytes = 8;
        private const long bitsInKB = bitsInBytes*1024;
        private const long bitsInMB = bitsInKB*1024;
        private const long bitsInGB = bitsInMB*1024;
        private const long bitsInTB = bitsInGB*1024;
        public DigitalSize(long initialvalue)
        {
            this.bit = initialvalue;
        }
        public DigitalSize AddBit(long bit)
        {
            return Add(bit,bitsInBit);
        }
        public DigitalSize AddByte(long bit)
        {
            return Add(bit,bitsInBytes);
        }
        public DigitalSize AddKB(long bit)
        {
            return Add(bit,bitsInKB);
        }
        public DigitalSize AddMB(long bit)
        {
            return Add(bit,bitsInMB);
        }

        public DigitalSize AddGB(long bit)
        {
            return Add(bit,bitsInGB);
        }
        public DigitalSize AddTB(long bit)
        {
            return Add(bit,bitsInTB);
        }
        
        private DigitalSize Add(long value,long scale)
        {
            return new DigitalSize(value*scale);
        }
    }
    class Student
    {
        public Student()
        {  
        }
    }
    struct Students
    {
        /*
        it is recommended to not use struct for more than 16 Bytes(4 int)
        and also not recommended for strings or reference types 
        */
        private int id = 1000;
        public int Id{get;set;}
        public Students()
        {
        }
        public void Show()
        {
            System.Console.WriteLine("This is students struct :)");
        }
        /*~Students()
        {
            Does not support Destructor (Finalizer)
        }*/
    
    }
}