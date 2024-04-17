namespace CADictionaries
{
    public class Dic
    {
        public void func()
        {
            var article =
            "According to Microsoft " +
            "Pot NET is a free cross-platform and open source developer platform " +
            "for building many different types of applications " +
            "With Dot NET you can use multiple languages and libraries " +
            "to build for web and IoT ";
            Dictionary<char, List<string>> Dictletters = new Dictionary<char, List<string>>();
            foreach (var word in article.Split())
            {
                foreach (var ch in word)
                {
                    var c = Char.ToLower(ch);
                    if (!Dictletters.ContainsKey(c))
                    {
                        Dictletters.Add(c, new List<string> { word.ToLower() });
                    }
                    else
                    {
                        Dictletters[c].Add(word.ToLower());
                    }

                }

            }
            /*foreach (var entry in Dictletters)
            {
                System.Console.Write($"{entry.Key}");
                foreach (var word in entry.Value)
                {
                    System.Console.WriteLine($"\t\t\"{word}\"");
                }

            }*/
            var emps = new List<Employee> {
                new Employee {Id = 100, Name = "Reem S.", ReportTo = null},
                new Employee {Id = 101, Name = "Raed M.", ReportTo = 100 },
                new Employee {Id = 102, Name = "Ali B.",ReportTo = 100 },
                new Employee {Id = 103, Name = "Abeer S.", ReportTo = 102 },
                new Employee {Id = 104, Name = "Radwan N.", ReportTo = 102},
                new Employee {Id = 105, Name = "Nancy R.", ReportTo = 101 },
                new Employee {Id = 106, Name = "Saleh A.", ReportTo = 104 }
        };
            var managers = emps.GroupBy(x => x.ReportTo).ToDictionary(x => x.Key ?? -1, x => x.ToList());
            foreach (var entry in managers)
            {
                if (entry.Key == -1)
                    continue;

                var manager = emps.FirstOrDefault(x => x.Id == entry.Key);
                System.Console.Write($"{manager}");

                foreach (var word in entry.Value)
                {
                    System.Console.WriteLine($"\t\t\"{word}\"");
                }

            }

        }
        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int? ReportTo { get; set; }
            public override string ToString()
            {
                return $"[{Id} {Name}]";
            }
        }
    }
}

