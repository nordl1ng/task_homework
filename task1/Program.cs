//  1. По двум заданным числам проверять является ли первое квадратом второго

System.Console.WriteLine("Введите число a");
int a = Int32.Parse(System.Console.ReadLine());
System.Console.WriteLine("Введите число b");
int b = Int32.Parse(System.Console.ReadLine());
System.Console.WriteLine(Math.Pow(System.Convert.ToDouble (b), 2));
if (Math.Pow(System.Convert.ToDouble (b), 2)== a)
{
    System.Console.WriteLine($"Число {a} является квадратом числа {b}");
}
else System.Console.WriteLine($"Число {a} не является квадратом числа {b}");