Console.WriteLine("Insert number a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Insert number b");
int b = Convert.ToInt32(Console.ReadLine());

if (a % b == 0)
{
    Console.WriteLine("a is mulriple of b");
}
else
{
    int c = a % b;
    Console.WriteLine("a is not multiple of b, remainder = " + c);
}