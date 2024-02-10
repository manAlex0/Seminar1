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

//******************************************************

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

//******************************************************

// Задача №3. Напишите программу, которая будет выдавать название для недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

// Простое решение через else if

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

//.....................................................

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

//******************************************************

// Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутку от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> "-2, -1, 0, 1, 2"

// Через цикл while:

// System.Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int numN = num * -1;
// while (numN <= num)
// {
//     System.Console.Write(numN + " ");
//     numN++;
// }

//.....................................................

// Через цикл for:

// System.Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int numN = num * -1;
// for (int i = num; i >= numN; numN++)
// {
//     System.Console.Write(numN + " ");
// }

//******************************************************

// Задача №6. Написать программу которая посчитает остаток от числа 10.

// System.Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Остаток равен " + num%10);

//******************************************************

// Задача. Выводить 3е число если оно есть, если нет то прописать, что его нет.

// System.Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num >= 100)
// {
// while (num / 1000 > 0)
//     num /= 10; // num = num / 10
//     System.Console.WriteLine(num%10);
// }
// else System.Console.WriteLine("Третьей цифры нет");

//******************************************************ПРАКТИЧЕСКОЕ ЗАДАНИЕ*****************************

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// System.Console.WriteLine("Введите первое число: ");
// int numA = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите второе число: ");
// int numB = Convert.ToInt32(Console.ReadLine());
// if (numA > numB)
//     System.Console.Write("Максимальное число: " + numA);
// else
//     System.Console.Write("Максимальное число: " + numB);

//******************************************************

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// System.Console.WriteLine("Введите первое число: ");
// int numA = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите второе число: ");
// int numB = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите третье число: ");
// int numC = Convert.ToInt32(Console.ReadLine());
// int max = numA;
// if (max < numB)
// {
//     max = numB;
// }
// else if (max < numC)
// {
//     max = numC;
// }
// System.Console.WriteLine("Максимальное число: " + max);

//******************************************************

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// System.Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// num %= 2;
// if (num == 0)
//     System.Console.WriteLine("Вы ввели чётное числов");
// else    
//     System.Console.WriteLine("Вы ввели не чётное числов");

//******************************************************

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// System.Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int cheackNum = 2;
// if (cheackNum > num)
// System.Console.WriteLine("Нет чётных чисел");
// while (cheackNum <= num)
// {
//     System.Console.Write(cheackNum + " ");
//     cheackNum += 2;
// }

//******************************************************

// Задача 7 HARD по желанию - идет за 2 обязательных Напишите программу, которая принимает на вход целое число любой разрядности и на выходе показывает третью цифру слева этого числа или говорит, что такой цифры нет. Через строку решать нельзя.
// 456111 -> 6
// 78 -> нет
// 9146548 -> 4
// 3 -> нет

// System.Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num >= 100)
// {
// while (num / 1000 > 0)
//     num /= 10; // num = num / 10
//     System.Console.WriteLine(num%10);
// }
// else System.Console.WriteLine("Третьей цифры нет");