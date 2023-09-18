/*
1. Константные O(1) - O(2)
2. Логарифмические - Бинарный поиск
3. Линейные O(n) - O(2 * n) ...
4. Линейно-логарифмические - Быстрая сортировка
5. Квадратные - Пузырьковая сортировка, сортировка выбором, сортировка вставками и другие
6. Кубические - Трехмерные массивы
*/

// Напишите программу, которая считает сумму чисел от 1 до n. (1 и 3 тип алгоритма)

// Мое решение:
// int sumNumbers(int N, int oneNumbers, int resultSum)
// {
//     if(N == oneNumbers) return resultSum += N;
//     else
//     {
//         resultSum += oneNumbers;
//         return sumNumbers(N,oneNumbers+1, resultSum);
//     }
// }
// Console.Clear();
// int one = 1, result = 0;
// System.Console.Write("Введите число: ");
// int n = Convert.ToInt32(System.Console.ReadLine());
// System.Console.WriteLine($"Сумма чисел от {one} до {n} равна {sumNumbers(n, one, result)}");

// Решение преподователя: (Линейное)
// Console.Clear();
// System.Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!), result = 0; //["345"]<-345
// //int n = Convert.ToInt32(Console.ReadLine()); //["123"]->123->[123]
// for(int i = 1; i <= n; i++) // O(n)
// result += i;
// System.Console.WriteLine($"Сумма чисел от 1 до {n} равна {result}");

// Мое решение: (Константное)
// Console.Clear();
// System.Console.Write("Введите число: ");
// double n = int.Parse(Console.ReadLine()!);
// System.Console.WriteLine((1 + n)/2 * n);

// Решение преподователя: (Константное)
// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// System.Console.WriteLine($"Сумма чисел от 1 до {n} равна {(1 + n)/ 2.0 * n}");