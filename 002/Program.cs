// Найти сумму элементов от M до N, N и M заданы
void PrintIn(string message)
{
    Console.Write(message);
}

int ReadInt(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

int M=ReadInt("Введите левый предел");
int N=ReadInt("Введите правый предел");
int sum=0;
for (int i = M; i <= N; i++)
{
    sum=sum+i;
}
PrintIn($"{sum}\t");
