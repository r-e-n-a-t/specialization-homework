string Prompt(string message)
{
    System.Console.Write(message);
    string result = Console.ReadLine();
    return result;
}
void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}  ");
    }
    System.Console.WriteLine();
}
string[] CreateArray()
{   
    int count = 0;
    string value = "";
    string[] tempArray = new string[1000];
    System.Console.WriteLine($"Для завершения ввода введите 'exit'");
    for (count = 0; value != "exit"; count++)
    {
        value = Prompt($"Введите значение элемента {count+1}> ");
        if (value != "exit") 
        {
            tempArray[count] = value;
        }
    }
    string[] array = new string[count-1];
    for (int i = 0; i < array.Length; i++)
    {
         array[i] = tempArray[i];
    }
    return array;
}
string[] ThreeSymbolCheck(string[] array)
{   
    int count = 0;
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    string[] newArray = new string[count];
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j].Length <= 3) 
        {
            newArray[index] = array[j];
            index++;
        }
    }
    return newArray;
}

string[] array = CreateArray();
System.Console.Write("Вы ввели => ");
ShowArray(array);
System.Console.Write("Новый массив => ");
ShowArray(ThreeSymbolCheck(array));



