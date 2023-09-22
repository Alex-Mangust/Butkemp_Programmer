// Быстрая Сортировка O(n * log2(n))
// Напишите программу, которая сложит 2 числа a и b, без прямого сложения

int sumNumbers(int x, int y)
{
    if(x == 0)
        return y;
    return sumNumbers(x - 1, y + 1);
}

Console.Clear();
System.Console.Write("Введите 2 числа: ");
int[] numbers = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
System.Console.WriteLine
($"Результат {numbers[0]} + {numbers[1]} = {sumNumbers(numbers[0], numbers[1])}");