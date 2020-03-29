namespace GS1Parser.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                WriteParsed(args[0]);
            }
            else
            {
                while (true)
                {
                    System.Console.Write("Press 'N' and Enter to close the app, or enter a code to parse and press Enter to continue:\n");
                    var inputString = System.Console.ReadLine();
                    if (inputString == "N")
                        break;
                    WriteParsed(inputString);
                }
            }
           
        }

        private static void WriteParsed(string code)
        {
            System.Console.WriteLine();
            var parsedCode = GS1Parser.Parse(code);
            foreach (var ai in parsedCode.Keys)
            {
                System.Console.WriteLine($"{ai}: {parsedCode[ai]}");
            }
            System.Console.WriteLine();
        }
    }
}
