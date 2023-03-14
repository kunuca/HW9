// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
//Первые два элемента последовательности задаются пользователем
// void PrintIn(string message)
// 5

int ReadInt(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

void FillArray(int[] arr)
{
    for (int i = 2; i < arr.GetLength(0); i++)
     {          
        arr[i]=arr[i-2]+arr[i-1];                
    }
}

void PrintArray(int[] arr)
{
    for (int i = 2; i < arr.GetLength(0); i++)
    {
        Console.WriteLine($"{i} число равно {arr[i-2]} + {arr[i-1]} = {arr[i]}");
    }
      
}

int len=ReadInt("Сколько чисел выводить на экран?");
int[] array=new int[len];
array[0]=ReadInt("Введите первое число");
array[1]=ReadInt("Введите второе число");
FillArray(array);
PrintArray(array);

