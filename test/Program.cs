Console.WriteLine("Введите 5 слов, либо чисел. Что бы программа отобразила все слова и числа которые имеют до 3х символов");
int lengthArray = Convert.ToInt32(Console.ReadLine());

string[] arraySymbol(int length)
{
    string[] result = new string[length];
    for (int i = 0; i < length; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент");
        result[i] = Convert.ToString(Console.ReadLine());
    }
    return result;
}

void printArray(string[] arraySymbol)
{
    Console.Write("[");
    for (var i = 0; i < arraySymbol.Length; i++)
    {
        Console.Write(arraySymbol[i]);
        if (i < arraySymbol.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int lengthSortArray(string[] arraySymbol)
{
    int length = 0;
    for (int i = 0; i < arraySymbol.Length; i++)
    {
        if (arraySymbol[i].Length <= 3)
        {
            length++;
        }
    }
    return length;
}

string[] arraySort(string[] arraySymbol, int lengthSortArray)
{
    int length = 0;
    string[] resultArray = new string[lengthSortArray];
    for (int i = 0; i < arraySymbol.Length; i++)
    {
        if (arraySymbol[i].Length <= 3)
        {
            length++;
            resultArray[length-1] = arraySymbol[i];
        }
    }
    return resultArray;

}

string[] MyArraySymbol = arraySymbol(lengthArray);
printArray(MyArraySymbol);

int lenghtArraySort = lengthSortArray(MyArraySymbol);
string[] sortMyArray = arraySort(MyArraySymbol, lenghtArraySort);
printArray(sortMyArray);