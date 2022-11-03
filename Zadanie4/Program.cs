Console.WriteLine("Введите три числа");
string число1 = Console.ReadLine();
int a = int.Parse(число1);
string число2 = Console.ReadLine();
int b = int.Parse(число2);
string число3 = Console.ReadLine();
int C = int.Parse(число3);

if (a > b)
{
    if (a > C)
    {
    
        Console.WriteLine(a);
    }
    else
{
    Console.WriteLine(C);
}
}
else
{
    if(b > C)

    {Console.WriteLine(b); 
}

else
{
    Console.WriteLine(C);
}}