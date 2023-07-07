
int m = InputNumbers ("Введите количество строк: ");
int n = InputNumbers ("Введите количество столбцов: ");
int range = InputNumbers ("Введите диапазон: от 1 до ");

int [,] array = new int [m,n];
CreateArray (array);
WriteArray (array);

int minSumLine = 0;
int SumLine = SumLineElements (array,0);
for (int i =1; i < array.GetLength (0); i++)
{
    int tempSumLine = SumLineElements (array, i);
    if (SumLine > tempSumLine)
    {
        SumLine = tempSumLine;
        minSumLine = i;
    }
}
Console.WriteLine ($" \n {minSumLine+1} - строка с наименьшей суммой ({SumLine}) элементов ");
int SumLineElements (int [,]array, int i)
{
    int SumLine = array [i,0];
    for (int k =1; k < array.GetLength (1); k++)
    {
        SumLine += array [i,k];
    }
    return SumLine;
}
int InputNumbers (string input)
{
    Console.Write (input);
    int output = Convert.ToInt32 (Console.ReadLine ());
    return output;
}
void CreateArray (int [,] array)
{
    for (int i = 0; i < array.GetLength (0); i++)
    {
        for (int k = 0; k < array.GetLength (1); k++);
        {
            array [i,k] = new Random(). Next (range);
        }
    }
}
void WriteArray (int [,] array)
{
    for (int i = 0; i < array.GetLength (0); i++)
    {
        for (int k = 0; < array.GetLength (1); k++)
        {
            Console.Write(array[i,k] + " ");
        }
        Console.WriteLine ();
    }
}