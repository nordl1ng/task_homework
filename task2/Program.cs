//  2. Даны два числа. Показать большее и меньшее число

System.Console.WriteLine("Введите число a");
int a = Int32.Parse(System.Console.ReadLine());
System.Console.WriteLine("Введите число b");
int b = Int32.Parse(System.Console.ReadLine());
if (a != b)
{
    if (a > b)
    {
        System.Console.WriteLine($"Число {a} больше чем {b}");
    }
    else System.Console.WriteLine($"Число {b} больше чем {a}");
}
else System.Console.WriteLine("Числа равны");