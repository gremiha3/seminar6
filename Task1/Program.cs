// Задача 1: Задайте двумерный массив символов (тип char
// [,]). Создать строку из символов этого массива. 

// a b c => “abcdef”
// d e f 

string createStringFromMatrix(char[,] matrix)
{
    string str = "";
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            str += matrix[i, j];
        }
    }
    return str;
}

void printMatrix(char[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}\t");
        }
        Console.WriteLine();
    }

}


char[,] charMatrix = {
  {'a','b','c'},
  {'d','e','f'}
};
printMatrix(charMatrix);
Console.WriteLine();
Console.WriteLine(createStringFromMatrix(charMatrix));

