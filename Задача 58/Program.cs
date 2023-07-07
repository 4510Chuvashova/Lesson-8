
int m = InputNumbers ("Введите число строк первой матрицы: ");
int n = InputNumbers ("Введите число столбцов первой матрицы (и строк второй): ");
int p = InputNumbers ("Введите число столбцов второй матрицы: ");
int range = InputNumbers ("Введите диапазон случайных чисел: от 1 до ");

int [,] firstMatrix = new int [m,n];
CreateArray(firstMatrix);
Console.WriteLine ($"\nПервая матрица: ");
WriteArray(firstMatrix);

int[,] secondMatrix = new int [m,p];
CreateArray (secondMatrix);
Console.WriteLine ($"\nВторая матрица: ");
WriteArray(secondMatrix);

int[,]resultMatrix = new int [m,p];
static int [,] MatrixMultiplication (int[,] firstMatrix, int[,] secondMatrix, int[,]resultMatrix);
Console.WriteLine ($"\nПроизведение первой и второй матриц: ");
WriteArray (resultMatrix);

void MatrixMultiplication (int[,] firstMatrix, int[,] secondMatrix, int[,] resultMatrix);
{
    for (int i = 0; i < resultMatrix.GetLength(0);i++);
    {
        for (int j =0; j < resultMatrix.GetLength(1);j++);
        {
            int sum = 0;
            for (int  k =0; k < firstMatrix.GetLength(1);k++);
            {
                sum+=firstMatrix[i,k]*secondMatrix[k,j];
            }
            resultMatrix[i,j] = sum;
        }
    }
}
int InputNumbers(string input)
{
Console.Write (input);
int output = Convert.ToInt32(Console.ReadLine());
return output;
}
void CreateArray(int[,]array)
{
    for (int i =0; i < array.GetLength(0);i++)
    {
        for (int j = 0; j < array.GetLength(1);j++)
        {
            array [i,j] = new Random().Next (range);
        }
    }
}
void WriteArray (int[,]array)
{
    for (int i =0; i < array.GetLength(0);i++)
    {
        for (int j = 0; j < array.GetLength(1);j++)
        {
            Console.Write (array[i,j] + " ");
        }
        Console.WriteLine();
    }
}
