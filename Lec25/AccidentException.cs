namespace CAExceptions
{
    public class AccidentException : Exception
    {
        public string Location { get; set; }
        public AccidentException(string location, string message) : base(message)

        {
            this.Location = location;
        }
    }
}