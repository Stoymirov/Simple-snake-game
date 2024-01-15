int[] inout = Console.ReadLine().Split().Select(int.Parse).ToArray();
char[,] matrix = new char[inout[0],inout[1]];
string name = Console.ReadLine();
int nameLength = name.Length;

int counter = 0;
for (int i = 0; i < inout[0]; i+=2)
{
    for (int j = 0; j < inout[1]; j++)
    {
        matrix[i,j] = name[counter++];
        if (counter == nameLength)
            counter = 0;
    }

    if (i + 1 == inout[0])
        break;
    for (int k = inout[1] - 1; k >= 0; k--)
    {
        matrix[i+1, k] = name[counter++];
        if (counter == nameLength)
            counter = 0;

    }
}

for (int i = 0; i < matrix.GetLength(0); i++)
{

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i,j]);
    }

    Console.WriteLine();
}