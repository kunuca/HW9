// Написать программу вычисления функции Аккермана
void PrintIn(string message)
{
    Console.Write(message);
}

int ReadInt(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}
int Ackerman(int a, int b)
{   int c=0;
    if (a==0)   return b+1;
    else
        {if((a>0)&&(b==0))     
            { c=Ackerman(a-1,1);
            return c;}
        else 
            {
                if((a>0)&&(b>0)) 
                { c=Ackerman(a-1, Ackerman(a,b-1));
                    return c;
                }
                else return -1;
            }
        }
}

int M=ReadInt("Введите первый аргумент");
int N=ReadInt("Введите второй аргумент");
int acker=Ackerman(M,N);
if (acker!=-1)
PrintIn($"A({M},{N})={acker} ");
else PrintIn("Задача не выполнима");