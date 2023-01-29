void NewArray(string[] firstArray, string[] secondArray)
{
    int count = 0;
    for (int i = 0; i < firstArray.Length; i++)
    {
    if(firstArray[i].Length <= 3)
        {
        secondArray[count] = firstArray[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
Console.Write("Введите количество элементов: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] firstArray = new string[size];
string[] secondArray = new string[firstArray.Length];
for (int i = 0; i < size; i++)
{
    Console.Write($"Введите {i+1}-й элемент: ");
    string element = Console.ReadLine();
    firstArray[i] = element;
}

PrintArray(firstArray);
NewArray(firstArray, secondArray);
PrintArray(secondArray);

