namespace MultiplicationTable
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ThePrinter printer = new ThePrinter();
            Console.Write("Enter a number for the multiplication table: ");
            int number = Convert.ToInt32(Console.ReadLine());
            printer.print(number);
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
    class ThePrinter
    {
        internal static string? print(object num)
        {
            throw new NotImplementedException();
        }

        public string print(int number)
        {
            MultiplyingTableProducer firstTableProducer = new MultiplyingTableProducer();
            string printingStuff = firstTableProducer.getTable(number);
            Console.WriteLine(printingStuff);
            Console.WriteLine("Number used: " + firstTableProducer.LastUsedNumber);
            return printingStuff;
        }
    }
    class MultiplyingTableProducer
    {
        public int LastUsedNumber { get; private set; }

        public string getTable(int number)
        {
            this.LastUsedNumber = number; // Set the last used number
            string resultingTableText = "";
            for (int j = 1; j <= 10; j++)
            {
                int product = number * j; // Use the passed number
                resultingTableText += $"{number} x {j} = {product}\n"; // Correctly format the output
            }

            return resultingTableText;
        }
    }
}