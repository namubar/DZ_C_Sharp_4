//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
System.Console.WriteLine("Введите число: ");
string writeN = Console.ReadLine();
int N = Convert.ToInt32(writeN);

int[] GetTable(int N)
{
    int[] arrayTable = new int[N];
    int digit = 1;
    for (int i = 0; i < N; i++)
    {
        arrayTable[i] = digit * digit * digit;
        digit++;
    }
    return arrayTable;
}
void printTable(int[] Array)
{
    int digit = 1;
    for (int i = 0; i < Array.Length; i++)
    {
        System.Console.Write($"{digit} ^ 3 = ");
        //System.Console.Write($"{digit}");
        System.Console.WriteLine(Array[i]);
        digit++;
    }
}
int [] table = GetTable (N);
printTable (table);