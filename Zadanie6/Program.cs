Console.WriteLine("Введите число");
string число = Console.ReadLine();
double a = double.Parse(число);

if (a % 2 == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}