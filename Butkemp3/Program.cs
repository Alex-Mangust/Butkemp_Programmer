// Console.Clear();
// int n = 5;
// int [] array = new int[n];
// for(int i = 0; i < 5; i++)
//     array[i] = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("[" + string.Join(" ", array) + "]");
// // [4, 5, 3, 1, 2]
// // O(n)
// // [1, 2, 3, 4, 5] - O(n * log n)
// // ((5+1)/2) * 5 - O(1)
// // n < n * log(n) + 1
// int summa = 0;
// for(int i = 0; i < n; i++)
//     summa += array[i];
// System.Console.WriteLine(summa);
// // O(n)

// O(n^2 / 2)
Console.Clear();
int n  = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, n];
for(int i = 0; i < n; i++)
{
    for(int j = 0; j < n; j++)
    {
        matrix[i, j] = (i + 1) * (j + 1);
        matrix[i, j] = (i + 1) * (j + 1);
    }
    System.Console.WriteLine();
}
for(int i = 0; i < n; i++)
{
    for(int j = 0; j < n; j++)
    {
        System.Console.Write(matrix[i,j]);
        System.Console.Write(" ");
    }
    System.Console.WriteLine();
}