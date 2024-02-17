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
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"'{array[i]}'\t");
    }
}

Console.Write("Введите количество элементов в массиве строк: ");
int amount_of_strings = Convert.ToInt32(Console.ReadLine());
string[] array = MakeStringsArray(amount_of_strings);
PrintArray(array);
