// Функция упорядочивания массива
Console.WriteLine("Введите массив чисел за одни раз: ");

string? strArray = Console.ReadLine();

int[] GetArrayDigit(string arrayDigit)
{
    int[] arrNum = new int[arrayDigit.Length];
    for(int i = 0; i < arrayDigit.Length; i++)
    {

    }
    return arrNum;
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