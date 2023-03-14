// Написать программу возведения числа А в целую стень B
void PrintIn(string message)
{
    Console.Write(message);
}

double ReadInt(string message)
{
    Console.WriteLine(message);
    return double.Parse(Console.ReadLine()!);
}
// int Prod(int m, int n)
// {   int d=1;
//     { while(n>0)
//         d=d*m;
//         n=n-1;
//     }
//     return d;
// }

double a=ReadInt("Введите число");
double b=ReadInt("Введите степень");
double result=Math.Pow(a,b);

PrintIn($"Произведение числа {a} в степени {b} равно {result}");

