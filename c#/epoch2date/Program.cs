Run();

void Run()
{
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.Clear();
    Console.WriteLine("[1] Epoch > Date\n[2] Date > Epoch");

    while (true)
        if (Console.KeyAvailable)
            if (Console.ReadKey(true).Key == ConsoleKey.D1)
            {
                Console.Clear();
                Console.WriteLine("Enter epoch > ");

                string dtk = Console.ReadLine();
                long dt = Convert.ToInt64(dtk);

                DateTimeOffset dtos = DateTimeOffset.FromUnixTimeMilliseconds(dt);
                DateTime dtr = dtos.DateTime;

                Console.Clear();
                Console.WriteLine(dtr);

                Console.ReadKey();
                Run();
            }
            else if (Console.ReadKey(true).Key == ConsoleKey.D2)
            {
                Console.Clear();
                Console.WriteLine("Enter date (Y-m-dTH:i:sZ) > ");

                string dtk = Console.ReadLine();

                DateTimeOffset dtos = DateTimeOffset.Parse(dtk);
                long dtr = dtos.ToUnixTimeMilliseconds();

                Console.Clear();
                Console.WriteLine(dtr);

                Console.ReadKey();
                Run();
            }
}