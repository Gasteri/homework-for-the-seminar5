/* Задача 36: 
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных индексах.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */
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

int[] array = GenerateArray(-100, 100, elements);
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

int sumevenindex = GetSumEvenIndexInArray(array);
int GetSumEvenIndexInArray(int[] array)
{
    int sumEvenIndex = 0;
    for(var i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0)
        {
            sumEvenIndex+= array[i];
        }
    }
    return sumEvenIndex;
}

PrintArray(array);
void PrintArray(int[] array)
{
    
    Console.WriteLine($"[{string.Join(" , ", array)}]");
    
}

Console.WriteLine($"Сумма чисел стоящих на четных индексах:  {sumevenindex}.");