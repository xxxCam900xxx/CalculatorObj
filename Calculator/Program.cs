using Calculator.Service;

var Service = new CalculatorService();

for (int i = 0; i < 2; i++)
{
    Console.WriteLine("----------------------");
    Console.WriteLine("Starting Calculator.");
    Console.WriteLine("----------------------");
    Thread.Sleep(500);
    Console.Clear();

    Console.WriteLine("----------------------");
    Console.WriteLine("Starting Calculator..");
    Console.WriteLine("----------------------");
    Thread.Sleep(500);
    Console.Clear();

    Console.WriteLine("----------------------");
    Console.WriteLine("Starting Calculator...");
    Console.WriteLine("----------------------");
    Thread.Sleep(500);
    Console.Clear();
}

Console.Clear();

Service.StartCalc();