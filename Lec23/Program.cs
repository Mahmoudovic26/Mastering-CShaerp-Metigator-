using System;
using System.Collections;
namespace CAGenerics
{
    class Program
    {
        static void Main(string[] args)
        {   var pp = new List<Person>();

            var arr =new ArrayList();
            arr.Add(1);
            arr.Add("jfjdk");
            

            pp.Add(new Person{FName = "Mahmoud",LName = "Bayoumi "});
            Printf("Mahmoud");
            Printf(2001);
            Printf('B');
            var list = new Any<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.DisplayList();
            list.RemoveAt(0);
            list.DisplayList();
            var people = new Any<Person>();
            people.Add(new Person{FName = "Mahmoud",LName = "Bayoumi "});
            people.DisplayList();
            
        }
        static void Printf<T>(T value)
        {
            System.Console.WriteLine(value);
        }
    }
    public class Person
    {
        public string FName  {get;set;}
        public string LName  {get;set;}

        public override string ToString()
        {
            return $"{FName} {LName}";
        }

    }
    class Any<T> //where T :class,new() //Constrains to use only Classes //where T:Cons1,Cons2...
    {
        private T[] _items;
        

        public void Add(T item)
        {
            if(_items is null)
            {
                _items = new T[] {item};
            }   
            else
            {
                var length = _items.Length;
                var dest = new T[length+1];
                for (int i = 0; i < length; i++)
                {
                    dest[i] = _items[i];
                    dest[dest.Length-1] = item;
                }
                _items = dest;
            }
        }
        
        public void RemoveAt(int position)
        {
            if (position<0 || position > _items.Length-1)
            {
                return;
            }
            var index = 0;
            var dest = new T[_items.Length-1];
            for (int i = 0; i < _items.Length; i++)
            {
                if(position == i)
                {
                    continue;
                }else
                {
                    dest[index++] = _items[i];
                }
            }
            _items = dest;
        }
        public void DisplayList()
        {
            Console.Write('[');
            for (int i = 0; i < _items.Length; i++)
            {
                Console.Write(_items[i]);
                if(i <_items.Length-1)
                    Console.Write(", ");

            }
            System.Console.WriteLine("]");
        }
        public bool IsEmpty => _items is null || _items.Length ==0;
        public int Count => _items is null ? 0:_items.Length;

    }

}