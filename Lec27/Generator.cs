namespace CAXMLDocumentation
{
    /// <include file="Generator.xml" path='docs/members[@name="generator"]/Generator/*'/>
    public class Generator
    {
        public static int LastIdSequance { get; private set; } = 1;
        /// <include file="Generator.xml" path='docs/members[@name="generator"]/GenerateId/*'/>

        public static string GenerateId(string fname, string lname, DateTime? hireDate)
        {
            // II YY MM DD 01.....n
            if (fname is null)
            {
                throw new InvalidOperationException($"{nameof(fname)} cannot be null");
            }
            if (lname is null)
            {
                throw new InvalidOperationException($"{nameof(lname)} cannot be null");
            }
            if (hireDate is null)
            {
                hireDate = DateTime.Now;

            }
            else
            {
                if (hireDate.Value.Date < DateTime.Now.Date)
                {
                    throw new InvalidOperationException($"{nameof(hireDate)} cannot be int the past");
                }
            }
            var yearOfHireDate = hireDate.Value.ToString("yy");
            var monthOfHireDate = hireDate.Value.ToString("MM");
            var dayOfHireDate = hireDate.Value.ToString("dd");
            var code = $"{lname.ToUpper()[0]}{fname.ToUpper()[0]} {yearOfHireDate} {monthOfHireDate} {dayOfHireDate} {(LastIdSequance++).ToString().PadLeft(2, '0')}";
            return code;
        }

        public static string GenerateRandomPassword(int length)
        {
            const string ValidScope = "abcdefghijklmnopqrstuvwxyzABCDEFGHIGKLMNOPQRSTUVWXYZ0123456789";
            var result = "";
            Random rnd = new Random();
            while (0 < length--)
            {
                result += (ValidScope[rnd.Next(ValidScope.Length)]);
            }
            return result;
        }

    }
}
