using System;
using System.Collections.Generic;

namespace CALists
{
    class Program
    {
        static void Main(string[] args)
        {
            var egypt = new Country
            {
                ISOCode = "EG",
                Name = "Egypt"
            };
            var jordan = new Country
            {
                ISOCode = "JO",
                Name = "Jordan"

            };
            var iraq = new Country
            {
                ISOCode = "IR",
                Name = "Iraq"
            };

            Country[] countriesArray = {
                                    egypt,
                                    jordan,
                                    iraq
                                    };

            //Constructor initialization
            List<Country> countriesList = new List<Country>();
            //List<Country> countriesList = new List<Country>(3); 3--> initial capacity
            //List<Country> countriesList = new List<Country>(countriesArray);



            print(countriesList);
            //Properties 

            //Methods 
            countriesList.Add(new Country { ISOCode = "BRA", Name = "Brasil" });// put at the end of the list 
            countriesList.Add(new Country { ISOCode = "FR", Name = "France" });// put at the end of the list 

            // O(1)
            countriesList.AddRange(countriesList);// add all the elements to the end of the list O(1)

            countriesList.Insert(1, new Country { ISOCode = "CHL", Name = "Chile" });// insert at index 1 O(n)
            print(countriesList);

            //countriesList.RemoveAt(2);// remove at index 3 O(n)
            //print(countriesList);
            countriesList.RemoveAll(x => x.Name.EndsWith("ce")); // remove all the elements that end with il O(n)
            print(countriesList);

        }
        static void print(List<Country> countries)
        {
            foreach (var country in countries)
            {
                Console.WriteLine(country);
            }
            //properties 
            Console.WriteLine($"Count : {countries.Count}");//Actual count of elements
            Console.WriteLine($"Capacity : {countries.Capacity}"); // Initial capacity of the list
        }
    }
    class Country
    {
        public string ISOCode { get; set; }
        public string Name { get; set; }
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 379 + Name.GetHashCode();
                hash = hash * 379 + ISOCode.GetHashCode();
                return hash;
            }
        }

        /*هنا عملنا اوفررايد على الهاش كود عشان ميحصلش تصادم وبعدها عملنا اوفررايد لل
        equals  
        عشان لما نقارن حاجة موجودة بحاجة جديدة هنبعتها يفهم ان هي هي      
        */
        public override bool Equals(object? obj)
        {
            var country = obj as Country;
            if (country == null)
            {
                return false;
            }


            return this.Name.Equals(country.Name, StringComparison.OrdinalIgnoreCase)
                && this.ISOCode.Equals(country.ISOCode, StringComparison.OrdinalIgnoreCase);
        }
        override public string ToString()
        {
            return $"{ISOCode}: {Name}";
        }
    }
}
