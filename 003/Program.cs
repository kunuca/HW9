// Найти сумму цифр числа
void PrintIn(string message)
{
    Console.Write(message);
}

int ReadInt(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

int number=ReadInt("Введите число");
int sum=0;
int part=0;
while (number>0)
{ part=number%10;
  sum=sum+part;
  number=number/10;

}
PrintIn($"{sum}");
