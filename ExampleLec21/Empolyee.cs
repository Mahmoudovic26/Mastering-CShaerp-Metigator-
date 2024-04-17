namespace CAInheritance
{
    public class Employee
    {
        private const int MinLogHours = 176;
        private const decimal OverTimeRate = 1.25m;

        protected Employee(int id, string name, decimal loggedHours, decimal wage)
        {
            Id = id;
            Name = name;
            LoggedHours = loggedHours;
            Wage = wage;
        }

        protected int Id {get;set;}
        protected string Name {get;set;}
        protected decimal LoggedHours{get;set;}
        protected decimal Wage {get;set;}
        protected virtual decimal Calculate()
        {
            return (CalculateBaseSalary() + CalculateOverTime()); 
        }
        private decimal CalculateBaseSalary()
        {
            return MinLogHours*Wage;
        }
        private decimal CalculateOverTime()
        {
            var additionalHours = ((LoggedHours - MinLogHours)>0 ? LoggedHours-MinLogHours:0);
            return additionalHours * Wage * OverTimeRate;
        }
        
        public override string ToString()
        {
            var type = GetType().ToString().Replace("CAInheritance.","");
            return  $"\n{type}"+
                    $"\nId: {Id}"+
                    $"\nName: {Name}"+
                    $"\nHours: {LoggedHours} hrs"+
                    $"\nWage: {Wage} $/hr"+
                    $"\nBase Salary: {Math.Round(CalculateBaseSalary(),2):N0}"+
                    $"\nOvertime: {Math.Round(CalculateOverTime(),2):N0}";
        }
    }
}