﻿//  3. По заданному номеру дня недели вывести его название

System.Console.WriteLine("Введите номер дня недели");
int a = Int32.Parse(System.Console.ReadLine());
if (a <8)
{
switch (a)
{
    case 1:
        System.Console.WriteLine("Понедельник");
        break;
    case 2:
        System.Console.WriteLine("Вторник");
        break;
    case 3:
        System.Console.WriteLine("Среда");
        break;
    case 4:
        System.Console.WriteLine("Четверг");
        break;
    case 5:
        System.Console.WriteLine("Пятница");
        break;
    case 6:
        System.Console.WriteLine("Субботу");
        break;
    case 7:
        System.Console.WriteLine("Воскресенье");
        break;
}
}
else System.Console.WriteLine("Повторите ввод, дней недели всего 7"); 