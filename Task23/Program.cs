Console.Write("Введите число : ");
int UserNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Таблица кубов: ");
for (int i = 1; i <= UserNumber; i++)
{
    int Cube = i * i * i;
    Console.Write($"{Cube}, ");
}