string[] MakeStringsArray(int amount_of_strings)
{
    string abc = "abcdefghijklmnopqrstuvwxyz";
    string[] array = new string[amount_of_strings];
    for (int i = 0; i < amount_of_strings; i++)
    {
        string rand_str = "";
        for (int j = 0; j < new Random().Next(1, 20); j++)
        {
            rand_str += abc[new Random().Next(0, 26)];
        }
        array[i] = rand_str;
    }
    return array;
}

void PrintArray(string[] array)
{
    Console.WriteLine(String.Join(", ", array));
}

string[] MakeNewStringsArray(string[] array)
{
    string[] new_array = new string[] {};
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            Array.Resize(ref new_array, new_array.Length + 1);
            new_array[new_array.Length - 1] = array[i];
        }
    }
    return new_array;
}


Console.Write("Введите количество элементов в массиве строк: ");
int amount_of_strings = Convert.ToInt32(Console.ReadLine());
string[] array = MakeStringsArray(amount_of_strings);
Console.WriteLine($"Случайный массив из {amount_of_strings} строк:");
PrintArray(array);
Console.WriteLine("Новый массив из строк, длиной в 3 символа и меньше:");
PrintArray(MakeNewStringsArray(array));
