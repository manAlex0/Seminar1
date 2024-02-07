// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное на само себя).

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

// System.Console.WriteLine("Введите целое число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int result = num * num;
// System.Console.WriteLine("Квадрат введенного числа равен " + result);

// if (num > 0)
// {
//     System.Console.WriteLine("Вы ввели положительное число");
// }
// else if (num == 0)
//     System.Console.WriteLine("Вы ввели 0");
// else
//     System.Console.WriteLine("Вы ввели отрицательное число");




// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3, b = 9 -> нет

// System.Console.WriteLine("Введите первое наибольшее число");
// int numA = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите второе наименьшее число");
// int numB = Convert.ToInt32(Console.ReadLine());
// int result = numA / numB;
// if (result == numB)
// {
//     System.Console.WriteLine("Вы ввели правильные числа ");
// }
// else
// {
//     System.Console.WriteLine("Вы ввели не верные числа.");
// }



// Задача №3. Напишите программу, которая будет выдавать название для недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

System.Console.WriteLine("Введите число дня недели");
int num = Convert.ToInt32(Console.ReadLine());
int monday = 1;
int tuesday = 2;
int wednesday = 3;
int thursday = 4;
int friday = 5;
int saturday = 6;
int sunday = 7;

if (num == monday)
{
    System.Console.WriteLine("Понедельник");
}
else if (num == tuesday)
    System.Console.WriteLine("Вторник");
if (num == wednesday)
    System.Console.WriteLine("Среда");
else if (num == thursday)
    System.Console.WriteLine("Четверг");
if (num == friday)
    System.Console.WriteLine("Пятница");
else if (num == saturday)
    System.Console.WriteLine("Суббота");
if (num == sunday)
    System.Console.WriteLine("Воскресенье");
if (num > 7)
    System.Console.WriteLine("Вы ввели не правильно число");
if (num < 1)
    System.Console.WriteLine("Вы ввели не правильно число");