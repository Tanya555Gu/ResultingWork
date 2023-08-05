// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] CreateArray()
{
    Console.Write("Введите количество элементов в массиве -> ");
    int len = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[len];
    for (int i = 0; i < len; i++)
    {
        Console.Write($"Введите значение {i + 1}-го элемента -> ");
        var setChar = Console.ReadLine();
        if (setChar != null && setChar.Trim()!= "")
        {
            array[i] = setChar.TrimStart().TrimEnd();
        }
        else
        {
            Console.WriteLine("Ничего не введено, повторите ввод");
            i--;
        }
    }
    return array;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.Write("]");
}

int FindNumberItems(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}