void ArrayFix()
{
    int size = 6;
    string[] array = new string[size];
    FillRandomArray(array);
    Console.Write("Input array:");
    PrintArray(array);
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i].Length <= 3) count++;
    }

    string[] result = new string[count];
    int j = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i].Length <= 3)
        {
            result[j] = array[i];
            j++;
        }
    }
    Console.Write("New array with words <= 3: ");
    PrintArray(result);
}


void FillRandomArray(string[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        array[i] = FillWord();
    }
}

string FillWord()
{
    string symbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ123456789(:;)][><";
    Random rand = new Random();
    int size = rand.Next(1, 6);
    string word = "";
    for (int i = 0; i < size; i++)
    {
        int letter = rand.Next(0, symbols.Length - 1);
        word += symbols[letter];
    }
    return word;
}

void PrintArray(string[] col)

{
    int count = col.Length;
    int position = 0;
    Console.Write("[");
    while(position < count)
    {
        Console.Write($"{col[position]}, ");
        position++;
    }
    Console.Write("\b]");
    Console.WriteLine();
}

ArrayFix();