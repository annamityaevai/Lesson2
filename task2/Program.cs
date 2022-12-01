Random random = new Random();
int number = random.Next(99, 1000);
Console.WriteLine("Random number = {0}", number);
int a = number / 100;
int c = number % 10;
Console.Write($"{a}");
Console.Write($"{c}");