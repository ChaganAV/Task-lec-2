// Функция упорядочивания массива

int[] arrayNoSort = ReadArray("Введите массив из 5 чисел: ");
Console.WriteLine($"Ваш массив: {PrintArray(arrayNoSort)} до сортировки");

GetArraySort(arrayNoSort);
Console.WriteLine($"Массив: {PrintArray(arrayNoSort)} после сортировки");

// Печать массива
string PrintArray(int[] array)
{
    string sArray = "{";
    for(int i = 0; i < array.Length; i++)
    {
        if(i < array.Length-1)
            sArray = sArray + $"{array[i]}, ";
        else
            sArray = sArray + $"{array[i]}";
    }
    return sArray+"}";
}

// Чтение массива от пользователя
int[] ReadArray(string message)
{
    Console.WriteLine(message);
    int[] array = new int[5];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

// Сортировка массива
void GetArraySort(int[] array)
{
    int minPos = 0;
    int temp = 0;
    for(int i = 0; i < array.Length-1; i++)
    {
        minPos = i;
        for(int j = i+1; j < array.Length; j++)
        {
            if (array[j] < array[minPos])
                minPos = j;
        }
        temp = array[i];
        array[i] = array[minPos];
        array[minPos] = temp;

    }
}