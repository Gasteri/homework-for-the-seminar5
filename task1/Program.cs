/* Задача 34: 
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве. 
[345, 897, 568, 234] -> 2      */
Console.WriteLine("Введите длину массива: ");
int elements = InputInt();
int InputInt()
{
    bool isParsed = int.TryParse(Console.ReadLine(), out int number);

    if(!isParsed)
        {
            Console.WriteLine("Incorrect number");
            return -1;
        }
    else
        {
            return number;
        }
}

int[] array = GenerateArray(100, 999, elements);
int[] GenerateArray(int min, int max, int length)
{
    Random random = new Random();
    int[] array = new int[length];

    for(var i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(min, max +1);
    }

    return array;
}

int evennumbers = GetEvenNumbersInArray(array);
int GetEvenNumbersInArray(int[] array)
{
    int sumEvenNumbers = 0;
    for(var i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            sumEvenNumbers+= 1;
        }
    }
    return sumEvenNumbers;
}

PrintArray(array);
void PrintArray(int[] array)
{
    
    Console.WriteLine($"[{string.Join(" , ", array)}]");
    
}

Console.WriteLine($"Количество четных чисел в массиве - {evennumbers}.");



