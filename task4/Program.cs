//  4. Найти максимальное из трех чисел

System.Console.WriteLine("Введите первое число");
int a = Int32.Parse(System.Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int b = Int32.Parse(System.Console.ReadLine());
System.Console.WriteLine("Введите третье число");
int c = Int32.Parse(System.Console.ReadLine());
int max = int.MinValue;
if (a>max) max = a;
if (b>max) max=b;
if (c>max) max = c;
System.Console.WriteLine(max);