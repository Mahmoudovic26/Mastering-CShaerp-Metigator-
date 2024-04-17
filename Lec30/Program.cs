using System;
using System.Reflection;
namespace CAReflectionAndMetadata
{
    class Program
    {


        private static void AccEvent(object? sender, EventArgs e)
        {
            var bankAccount = (BankAccount)sender;
            System.Console.WriteLine("Negative Balance");
        }
        static void Main(string[] args)
        {

            var account = new BankAccount("1234", "Bayoumi", 1000);
            Type t = typeof(BankAccount);
            Type[] parameters = { typeof(decimal) };
            MethodInfo method = t.GetMethod("Deposit", parameters);
            method.Invoke(account, new object[] { 500m });
            System.Console.WriteLine(account);
            System.Console.WriteLine("++++++++++++++++++");
            System.Console.WriteLine("Member Info\n");
            MemberInfo[] members = typeof(BankAccount).GetMembers();//Returns all public members
            MemberInfo[] memberss = typeof(BankAccount).GetMembers(BindingFlags.NonPublic | BindingFlags.Instance);//returns non public
            foreach (var item in memberss)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine("++++++++++++++++++");
            System.Console.WriteLine("Field Info\n");
            FieldInfo[] fields = typeof(BankAccount).GetFields();//Returns all public fields 
            FieldInfo[] fieldss = typeof(BankAccount).GetFields(BindingFlags.NonPublic | BindingFlags.Instance);//returns non public
            foreach (var item in fieldss)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine("++++++++++++++++++");
            System.Console.WriteLine("Property Info\n");
            PropertyInfo[] Property = typeof(BankAccount).GetProperties();//Returns all public fields 
            PropertyInfo[] Propertyy = typeof(BankAccount).GetProperties(BindingFlags.NonPublic | BindingFlags.Instance);//returns non public
            foreach (var item in Property)
            {
                System.Console.WriteLine(item.GetGetMethod());
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine("++++++++++++++++++");
            System.Console.WriteLine("EventInfo\n");
            EventInfo[] ev = typeof(BankAccount).GetEvents();//Returns all public fields 
            EventInfo[] evs = typeof(BankAccount).GetEvents(BindingFlags.NonPublic | BindingFlags.Instance);//returns non public
            foreach (var item in ev)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine("++++++++++++++++++");


            var b = new BankAccount("A123", "Bayoumi", 1000);
            b.OnNegativeBalance += AccEvent;
            b.Withdraw(500);
            b.Withdraw(600);

            System.Console.WriteLine("=-============================");
            Type type1 = DateTime.Now.GetType(); //At runtime 
            System.Console.WriteLine(type1);
            Type type2 = typeof(DateTime); //At compile time
            System.Console.WriteLine(type2);
            System.Console.WriteLine($"FullName: {type1.FullName}"); //Namespace.Typename
            System.Console.WriteLine($"NameSpace: {type1.Namespace}"); //Namespace
            System.Console.WriteLine($"Name: {type1.Name}"); //Name
            System.Console.WriteLine($"BaseType: {type1.BaseType}"); //Base Type
            System.Console.WriteLine($"IsPublic: {type1.IsPublic}");
            System.Console.WriteLine($"Assembly: {type1.Assembly}");
            var type3 = typeof(int[,]);
            System.Console.WriteLine($"Name type3: {type3.Name}");
            var type4 = typeof(int);
            var interfaces = type4.GetInterfaces();
            for (int i = 0; i < interfaces.Length; i++)
            {
                System.Console.WriteLine(interfaces[i]);
            }
            System.Console.WriteLine("---------------------");
            //var i = new Int32();
            //i = 3;
            int ii = (int)Activator.CreateInstance(typeof(int)); //Creates from Reflection
            DateTime dt = (DateTime)Activator.CreateInstance(typeof(DateTime), 2024, 01, 01);
            System.Console.WriteLine(dt);
            System.Console.WriteLine("---------------------");
            System.Console.WriteLine(new MBZ());
            System.Console.WriteLine("--------------");
            System.Console.WriteLine("Enemy: \n");
            do
            {
                var input = "CAReflectionAndMetadata." + Console.ReadLine();
                object? obj = null;
                try
                {
                    var aName = typeof(Program).Assembly.GetName().Name;
                    var enemy = Activator.CreateInstance(aName, input);
                    obj = enemy.Unwrap();
                }
                catch
                {
                }
                switch (obj)
                {
                    case Goon g:
                        System.Console.WriteLine(g);
                        break;
                    case Agtha a:
                        System.Console.WriteLine(a);
                        break;
                    case MBZ m:
                        System.Console.WriteLine(m);
                        break;
                    default:
                        System.Console.WriteLine("Unknown Enemy");
                        break;
                }
            } while (false);//true To Active it
        }

    }
    public class Goon
    {
        public override string ToString()
        {
            return $"{{Speed: {20}, HitPower: {13}, Strength: {7}}}";
        }
    }
    public class Agtha
    {
        public override string ToString()
        {
            return $"{{Speed: {10}, HitPower: {30}, Strength: {13}}}";
        }
    }
    public class MBZ
    {
        public override string ToString()
        {
            return $"{{Speed: {19}, HitPower: {37}, Strength: {16}}}";
        }
    }

}