using System;
namespace CAQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(1 % 5);
            Queue<PrintingJob> printingJobs = new Queue<PrintingJob>();
            printingJobs.Enqueue(new PrintingJob("documentation.docx", 2));
            printingJobs.Enqueue(new PrintingJob("user-stories.pdf", 6));
            printingJobs.Enqueue(new PrintingJob("report.xlsx", 6));
            printingJobs.Enqueue(new PrintingJob("payroll.report", 5));
            printingJobs.Enqueue(new PrintingJob("budget.xlsx", 4));
            printingJobs.Enqueue(new PrintingJob("algorithm-ppt", 1));
            System.Console.WriteLine($"Current Queue count before dequeue: {printingJobs.Count}");

            Random rnd = new Random();
            while (printingJobs.Count > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                var job = printingJobs.Dequeue();
                System.Console.WriteLine($"printing....[{job}]");
                System.Threading.Thread.Sleep(rnd.Next(1, 5) * 1000);
                Console.ForegroundColor = ConsoleColor.White;

            }
            System.Console.WriteLine($"Current Queue count : {printingJobs.Count}");
        }
    }
    class PrintingJob
    {
        private readonly string _file;
        private readonly int _copies;

        public PrintingJob(string files, int copies)
        {
            this._file = files;
            this._copies = copies;

        }
        public override string ToString()
        {
            return $"{_file} x #{_copies} copies ";
        }
    }
}