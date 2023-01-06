// Задача: Написать программу, которая из имеющегося массива строк формируст массив из строк, длина которых
// меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении но рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.


var gettext = GetAnyArray("Введите элементы массива через пробел или запятую");
Console.Write($"[{String.Join("," , gettext)}] -> ");
SortArray(gettext);

void SortArray(string[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            Console.Write("\"" + arr[i] + "\"" + ",");
        }
    }
    Console.Write("]");
}

string[] GetAnyArray(string outputText = "", bool inline = false)
{
    var arrays = Array.Empty<string>();
    if (inline)
        Console.Write("\"" + outputText + "\"");
    else
        Console.WriteLine("\"" + outputText + "\"");
    try
    {
        char[] separators = { ' ', ',' };
        var arrayOfEnteredText = Console.ReadLine()
            ?.Split(separators,
                StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
        if (arrayOfEnteredText != null)
            arrays = Array.ConvertAll(arrayOfEnteredText, s => s);
    }
    catch (Exception e)
    {
        Console.WriteLine(e);
        throw;
    }

    return arrays;
}
