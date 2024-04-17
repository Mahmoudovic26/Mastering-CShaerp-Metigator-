namespace CAInheritance
{
    public class Developer: Employee
    {
        private const decimal Commission = 0.03m;
        public Developer(int id, string name, decimal loggedHours,
        bool taskCompleted, decimal wage) : base(id, name, loggedHours, wage)
        {
            this.TaskCompleted = taskCompleted;
        }
        protected bool TaskCompleted {get;set;}
        protected override decimal Calculate()
        {
            return base.Calculate()+CalculateBonus();
        }
        private decimal CalculateBonus()
        {

            if(TaskCompleted)
            {
            return base.Calculate()*Commission ;
            }
            else
            {
                return 0;    
            }
        }
        public override string ToString()
        {
            return base.ToString()+
                    $"\nTask Completed: {(TaskCompleted? "Yes":"No")}"+
                    $"\nBonus: ${Math.Round(CalculateBonus(),2):N0}"+
                    $"\nNet Salary ${Math.Round(this.Calculate(),2):N0}";
        }
    }


}