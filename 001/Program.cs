// Показать натуральные числа от M до N, N и M заданы
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
for (int i = M; i <= N; i++)
{
    PrintIn($"\t{i}");
}
PrintIn(" ");