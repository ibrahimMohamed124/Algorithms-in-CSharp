using System.Data;

public class Matrices
{
    public static double[,] Add(double[,] arr1, double[,] arr2)
    {
        int rows = arr1.GetLength(0);
        int cols = arr1.GetLength(1);

        if (arr1.GetLength(0) != arr2.GetLength(0) || arr1.GetLength(1) != arr2.GetLength(1))
        {
        throw new ArgumentException("The two matrices must be the same size");
        }

        double[,] result = new double[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
            result[i, j] = arr1[i, j] + arr2[i, j];
            }
        }

        return result;
    }


    // Subtract Two Matrices
    public static double[,] Subtract(double[,] arr1, double[,] arr2)
    {
        int rows = arr1.GetLength(0);
        int cols = arr1.GetLength(1);
        if (arr1.GetLength(0) != arr2.GetLength(0) || arr1.GetLength(1) != arr2.GetLength(1))
        {
            throw new ArgumentException("The Two Matrices Must be in The Same Size");
        }
        double[,] result = new double[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = arr1[i, j] - arr2[i, j];
            }
        }
        return result;
    }


    // Display Matrix in Console
    public static void PrintMatrix(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j].ToString().PadRight(5));
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }


    // Transpose Matrix 
    public static double[,] Transpose(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        
        double[,] result = new double[cols, rows];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[j, i] = matrix[i, j];
            }
        }
        return result;
    }
}