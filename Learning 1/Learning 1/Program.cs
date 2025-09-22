class Program
{
    static void Main()
    {
        ConsoleKeyInfo keyInfo = Console.ReadKey();
        
        while (true)
        {
            keyInfo = Console.ReadKey();
            if (keyInfo.Key == ConsoleKey.A)
            {
                Console.WriteLine("A");
                break;
            }
            
            if (keyInfo.Key == ConsoleKey.D)
            {
                Console.WriteLine("D");
                break;
            }
            
            if (keyInfo.Key == ConsoleKey.W)
            {
                Console.WriteLine("W");
                break;
            }
            
            if (keyInfo.Key == ConsoleKey.S)
            {
                Console.WriteLine("S");
                break;
            }
        }
    }
}