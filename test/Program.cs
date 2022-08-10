Console.WriteLine("Введите 5 слов, либо чисел. Что бы программа отобразила все слова и числа которые имеют до 3х символов");
int lengthArray = Convert.ToInt32(Console.ReadLine());

string[] arraySymbol(int length)
{
    string[] result = new string[length];
    for (int i = 0; i < length; i++)
    {   
        Console.WriteLine($"Введите {i+1} элемент");
        result[i] = Convert.ToString(Console.ReadLine());
    }
    return result;
}
