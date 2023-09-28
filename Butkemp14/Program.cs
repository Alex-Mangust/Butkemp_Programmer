// «Гонка» в параллельных вычислениях

using System.ComponentModel.DataAnnotations;
const int THREADS_NUMBER = 10; // Число потоков
const int N = 10000000; //Размер массива
object locker = new object();
void CountingSortExtended(int[] inputArray)
{
    int max = inputArray.Max(), min = inputArray.Min(),
    offset = -min;

    int[] counters = new int[max + offset + 1];
    for (int i = 0; i < inputArray.Length; i++)
        counters[inputArray[i] + offset]++;
    int index = 0;
    for (int i = 0; i < counters.Length; i++)
        for (int j = 0; j < counters[i]; j++)
        {
            inputArray[index] = i - offset;
            index++;
        }
}
void PreparallelCountingSort(int[] inputArray)
{
    int max = inputArray.Max(), min = inputArray.Min(),
    offset = -min;
    int[] counters = new int[max + offset + 1];
    int eachThreadCalc = N / THREADS_NUMBER;
    var threadsParall = new List<Thread>();
    for (int i = 0; i < THREADS_NUMBER; i++)
    {
        int startPos = i * eachThreadCalc;
        int endPos = (i + 1) * eachThreadCalc;
        if (i == THREADS_NUMBER - 1) endPos = N;
        threadsParall.Add(new Thread(() => CountingSortParallel(inputArray, counters, offset, startPos, endPos)));
        threadsParall[i].Start();
    }
    foreach (var thread in threadsParall)
    {
        thread.Join();
    }
    int index = 0;
    for (int i = 0; i < counters.Length; i++)
        for (int j = 0; j < counters[i]; j++)
        {
            inputArray[index] = i - offset;
            index++;
        }
}
void CountingSortParallel(int[] inputArray, int[] counters, int offset, int startPos, int endPos)
{
    for (int i = startPos; i < endPos; i++)
    {
        lock(locker)
        {
        counters[inputArray[i] + offset]++;
        }
    }
}
bool EqualityMatrix(int[] fmatix, int[] smatrix)
{
    bool res = true;
    for (int i = 0; i < N; i++)
        res = res && (fmatix[i] == smatrix[i]);
    return res;
}
Console.Clear();
//int[] array = new int[]{0, 1, -2, 5, 1, 1, 3, 6};
Random rand = new Random();
int[] resSerial = new int[N].Select(r => rand.Next(0, 5)).ToArray(); // Создание массива с рандомными числами от 0 до 5
int[] resParallel = new int[N];
Array.Copy(resSerial, resParallel, N);
//System.Console.WriteLine(string.Join(", ", resSerial));
CountingSortExtended(resSerial);
PreparallelCountingSort(resParallel);
System.Console.WriteLine(EqualityMatrix(resSerial, resParallel));
//System.Console.WriteLine(string.Join(", ", resSerial));
//System.Console.WriteLine(string.Join(", ", resParallel));
