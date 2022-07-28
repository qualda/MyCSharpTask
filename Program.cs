// Написать программу, которая из имеющегося массива строк 
// формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма.

string[] array1 = new string[8] {"Paris", "Kira", "Homework", "C#", "441", "yes", "-55", "Mika"};

string[] array2 = new string[array1.Length];

ResultArray(array1, array2);

Console.WriteLine("Source array: ");
PrintArray(array1);

Console.WriteLine("Result array: ");
PrintArray(array2);

void ResultArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine("");
}
