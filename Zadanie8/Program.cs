Console.WriteLine("Введите число");
string a = Console.ReadLine();
int n = int.Parse(a);
int j = 1;

while (j <= n)
{
    if(j % 2 == 0)
    {
        Console.WriteLine(j);
    }
    j++;}