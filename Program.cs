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
// if (numA / numB == numB)
//     System.Console.WriteLine("Вы ввели правильные числа ");
// else
//     System.Console.WriteLine("Вы ввели не верные числа.");



// Задача №3. Напишите программу, которая будет выдавать название для недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница


// System.Console.WriteLine("Введите число дня недели");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num == 1)
// {
//     System.Console.WriteLine("Понедельник");
// }
// else if (num == 2)
//     System.Console.WriteLine("Вторник");
// else if (num == 3)
//     System.Console.WriteLine("Среда");
// else if (num == 4)
//     System.Console.WriteLine("Четверг");
// else if (num == 5)
//     System.Console.WriteLine("Пятница");
// else if (num == 6)
//     System.Console.WriteLine("Суббота");
// else if (num == 7)
//     System.Console.WriteLine("Воскресенье");
// else 
//     System.Console.WriteLine("Вы ввели не правильно число");



// Решение через switch case рекомендуется делать если больше 4-5 if


// System.Console.WriteLine("Введите число от 1 до 7: ");
// int num = Convert.ToInt32(Console.ReadLine());
// switch (num)
// {
//     case 1:
//         System.Console.WriteLine("Понедельник");
//         break;
//     case 2:
//         System.Console.WriteLine("Вторник");
//         break;
//     case 3:
//         System.Console.WriteLine("Среда");
//         break;
//     case 4:
//         System.Console.WriteLine("Четверг");
//         break;
//     case 5:
//         System.Console.WriteLine("Пятница");
//         break;
//     case 6:
//         System.Console.WriteLine("Суббота");
//         break;
//     case 7:
//         System.Console.WriteLine("Воскресенье");
//         break;
//     default:
//         System.Console.WriteLine("Введено не корректное число");
//         break;
// }



// Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутку от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> "-2, -1, 0, 1, 2"

System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int numN = num * -1;
num = num + 1;
while (numN < num)
{
    System.Console.Write(numN + " ");
    numN++;
}