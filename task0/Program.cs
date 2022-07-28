//  0. Вывести квадрат числа

System.Console.WriteLine("Введите число");
int a = Int32.Parse(System.Console.ReadLine());

System.Console.WriteLine($"Квадрат числа равен: {a*a}");

System.Convert.ToDouble (a);
System.Console.WriteLine($"В какую еще степень возвести число {a}?");
double c = Double.Parse(System.Console.ReadLine());
double b = Math.Pow(a, c);
System.Console.WriteLine($"{a} в степени {c} равно {b}");