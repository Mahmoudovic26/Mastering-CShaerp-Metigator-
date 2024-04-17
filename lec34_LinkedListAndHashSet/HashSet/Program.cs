namespace CAHashSets
{
    class Program
    {
        static void Main(string[] args)
        {
            var customers = new List<Customer>
            {
                new Customer { Name = "Mahmoud " , Telephone = "+1 1124876300" },
                new Customer { Name = "Habiba "  , Telephone = "+1 1124876301" },
                new Customer { Name = "Ola "     , Telephone = "+1 1124876302" },
                new Customer { Name = "Muhammad ", Telephone = "+1 1124876303" },
                new Customer { Name = "Omar "    , Telephone = "+1 1124876304" },
                new Customer { Name = "Zezo "    , Telephone = "+1 1124876304" }
            };

            var custhashSet1 = new HashSet<Customer>(customers);
            custhashSet1.Add(new Customer { Name = "Mahmoud F", Telephone = "+1 1124876310" });
            foreach (var item in custhashSet1)
            {
                System.Console.WriteLine(item);
            }
            //print(customers);
            // Customer cust1 = new Customer { Name = "Mahmoud ", Telephone = "+1 1124876300" };
            // Customer cust2 = new Customer { Name = "Mahmoud ", Telephone = "+1 1124876300" };
            // System.Console.WriteLine(cust1.Equals(cust2));
            //System.Console.WriteLine(cust1 == cust2);
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            System.Console.WriteLine("SortedList");
            System.Console.WriteLine("--------------");
            var cusromersortedset = new SortedSet<Customer>(customers);
            foreach (var item in cusromersortedset)
            {
                System.Console.WriteLine(item);
            }

        }
        static void print(List<Customer> customers)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            foreach (var item in customers)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine("SortedList");
            System.Console.WriteLine("--------------");
            var cusromersortedset = new SortedSet<Customer>(customers);
            foreach (var item in cusromersortedset)
            {
                System.Console.WriteLine(item);
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    class Customer : IComparable<Customer>
    {
        public string Name { get; set; }
        public string Telephone { get; set; }
        public override int GetHashCode()
        {
            var hash = 17;
            hash = hash * 379 + Telephone.GetHashCode();
            return hash;
        }
        public override bool Equals(object? obj)
        {
            var customer = obj as Customer;
            if (customer is null)
            {
                return false;
            }
            else
            {
                return this.Telephone.Equals(customer.Telephone);
            }
        }
        public override string ToString()
        {
            return $"Name: {Name}\t Telephone ({Telephone})";
        }
        public int CompareTo(Customer other)
        {
            if (ReferenceEquals(this, other))
            {
                return 0;
            }

            if (this is null || other is null)
            {
                return -1;
            }

            return this.Name.CompareTo(other.Name);

        }
        public static bool operator ==(Customer c1, Customer c2)
        {
            if (ReferenceEquals(c1, c2))
            {
                return true;
            }

            if (c1 is null || c2 is null)
            {
                return false;
            }

            return c1.Equals(c2);
        }

        public static bool operator !=(Customer c1, Customer c2)
        {
            return !(c1 == c2);
        }
    }
}