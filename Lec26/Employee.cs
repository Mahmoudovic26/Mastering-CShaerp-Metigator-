namespace CSEnumeratorEnumerable
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }
        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is Employee))
                return false;
            var emp = obj as Employee;

            return this.Id == emp.Id
                && this.Name == emp.Name
                && this.Salary == emp.Salary
                && this.Department == emp.Department;
        }
        public override int GetHashCode()
        {
            int hash = 13;
            hash = (hash * 7) + Id.GetHashCode();
            hash = (hash * 7) + Name.GetHashCode();
            hash = (hash * 7) + Salary.GetHashCode();
            hash = (hash * 7) + Department.GetHashCode();
            return base.GetHashCode();
        }
        public static bool operator ==(Employee lhs, Employee rhs) => lhs.Equals(rhs);
        public static bool operator !=(Employee lhs, Employee rhs) => !(lhs.Equals(rhs));

    }
}

