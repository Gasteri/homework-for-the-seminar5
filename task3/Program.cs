/*Задача 38: 
Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива. 
Не использовать готовые методы Min и Max
[3 7 22 2 78] -> 76*/

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

double[] array = GenerateArray(/*-100, 100,*/ elements); /* можно интервал задать, чтоб числа по меньше генерировались*/
double[] GenerateArray(/*int min, int max,*/ int length)
{
    Random random = new Random();
    double[] array = new double[length];

    for(var i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(/*min, max*/);
    }

    return array;
}

double maxelement = GetMaxElementInArray(array);
double GetMaxElementInArray(double[] array)
{
    double maxElement = array[0];
    for(var i = 1; i < array.Length; i++)
    {        
        if(array[i] > array[0])
        {
            maxElement = array[i];
        }
    }
    return maxElement;
}

double minelement = GetMinElementInArray(array);
double GetMinElementInArray(double[] array)
{
    double minElement = array[0];
    for(var i = 1; i < array.Length; i++)
    {
        
        if(array[i] < array[0])
        {
            minElement = array[i];
        }
    }
    return minElement;
}

PrintArray(array);
void PrintArray(double[] array)
{
    Console.WriteLine($"[{string.Join(" , ", array)}]");
}

Console.WriteLine($"Разница между максимальным и минимальным элементов массива:  {maxelement - minelement}.");