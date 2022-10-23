﻿// Функция упорядочивания массива

int[] array = ReadArray("Введите массив из 5 чисел: ");


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

int[] GetArraySort(int[] array)
{
    int[] arrNew = new int[array.Length];
    arrNew[0] = array[0];
    int temp = 0;
    for(int i = 0; i < array.Length; i++)
    {
        for(int j = 1; j < array.Length-1; j++)
        {
            if (arrNew[i] < array[j])
                arrNew[j] = array[j];
            else
            {
                temp = arrNew[i];
                arrNew[i] = array[j];
                arrNew[j] = temp;
            }       
        }
    }

    return arrNew;
}