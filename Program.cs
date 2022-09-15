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


