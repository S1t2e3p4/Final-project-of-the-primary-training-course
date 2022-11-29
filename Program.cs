// Задача :
// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

void Main()
{   
    Console.Clear();
    string[] PrimaryArray = new string[4] {"hello", "5", "world", ":-)"};
    string[] FinalArray = new string[PrimaryArray.Length];
    CreateResultArrayWithIf(PrimaryArray, FinalArray);
    PrintArray(FinalArray);
}

void CreateResultArrayWithIf(string[] PrimaryArray, string[] FinalArray)
{
    int count = 0;
    for (int i = 0; i < PrimaryArray.Length; i++)
    {
    if(PrimaryArray[i].Length <= 3)
        {
        FinalArray[count] = PrimaryArray[i];
        count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

Main();
