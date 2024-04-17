using System;
namespace CAInheritance
{
    class Program 
    {
        static void Main(string[] args)
        {
            var sc = new SubClass(123);
            System.Console.WriteLine(sc.value); 

            System.Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-");
            var aa = new Aanimal();
            System.Console.WriteLine(aa); //Will return the namespace.ClassName
            System.Console.WriteLine("=================");
            System.Console.WriteLine(typeof(Eagle));
            System.Console.WriteLine(aa.GetType());
            aa.Name = "Lion";
            aa.Move();
            var m = new Mammals();
            var eg = new Eagle();
            Animal a = eg; //UpCasting 
            Eagle eg2 = (Eagle) a; //DownCasting 
            Falcon f = a as Falcon ;//if it cannot convert will return null 
            var F = new Falcon();
            F.Move();
            if(a is Falcon)
            {
                System.Console.WriteLine("Falcon");
            }
            else
            {
                System.Console.WriteLine("Not a Falcon");
            }
         //eg.Swim(); //protected Can not be seen outside the parent and child 
            eg.SomeMethod();
            eg.Move();
            eg.Fly();
        }
    } 
    class BaseClass
    {
        public int x ;
        public int value =10;
        
        public BaseClass()
        {

        }
        public BaseClass(int value)
        {
            x = value;
        }
    }
    class SubClass :BaseClass
    {
        public new int value = 20; //Hiding inherited value to make compiler make sure from hiding we put new
        public SubClass(int scValue) : base(scValue)
        {
            
        }
    }
    class Aanimal // :Object --> the default base class for all .NET classes 
    {
        public override string ToString() // return the default textual presentation of the class
        {
            return base.ToString();
        }
        public string Name {get;set;}
        public virtual void Move()
        {
            System.Console.WriteLine($"{Name} is Moving");
        }
    }
    abstract class Animal // :Object --> the default base class for all .NET classes 
    {
        public string Name {get;set;}
        public abstract void Eat(); //Abstracted Method has no body
        public virtual void Move()
        {
            System.Console.WriteLine($"{Name} is Moving");
        }
        protected void Swim()
        {
            System.Console.WriteLine("Swim");
        }
    }
    sealed class Mammals //No one can inherit it 
    { 

    }
    class Falcon :Animal
    {
        
        public override void Move()
        {
            base.Move();
            System.Console.WriteLine("The Falcon");
        }
        public void Fly()
        {
            System.Console.WriteLine("Falcon Flying");
        }

        public override void Eat()
        {
            System.Console.WriteLine("Falcon Eating");//because it inherited abstracted method must implement it internally or get error 

        }
    }
    class Eagle :Animal 
    {
        //If the inherited method was protected so it can only be seen inside the class and its child 
        public void SomeMethod()
        {
            this.Swim();
        }
        public void Fly()
        {
            System.Console.WriteLine("Flying");
        }

        public override sealed void Eat()
        {
            System.Console.WriteLine("Eating");
        }
    }
    class AmericanEagle:Eagle
    {
        /*  
        public override void Eat()//Cannot override it because it is Sealed method
        {
            System.Console.WriteLine("American Eagle Flying");
        }   
        */
    }
}