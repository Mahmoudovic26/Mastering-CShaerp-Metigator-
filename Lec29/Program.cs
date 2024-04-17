using System;
using System.Reflection;

namespace CAAssemblies
{
    class Program
    {

        static void Main(string[] args)
        {
            var type = typeof(Employee);
            System.Console.WriteLine(type);
            var assembly = type.Assembly;
            System.Console.WriteLine(assembly.FullName);
            System.Console.WriteLine("-----------");
            var ass = Assembly.GetExecutingAssembly();
            System.Console.WriteLine(ass);
            System.Console.WriteLine(typeof(DateTime).Assembly.FullName);
            var stream = assembly.GetManifestResourceStream("Lec29.data.countries.json");
            var data = new BinaryReader(stream).ReadBytes((int)stream.Length);
            for (int i = 0; i < data.Length; i++)
            {
                System.Console.Write((char)data[i]);
                System.Threading.Thread.Sleep(10);
            }
            stream.Close();
        }
    }
    class Employee
    {

    }
}
