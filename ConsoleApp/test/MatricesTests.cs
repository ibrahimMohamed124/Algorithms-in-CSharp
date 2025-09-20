class MatricesTest : Test
{
    public override void RunTest()
    {
        double[,] Mat1 = { { 1, 2, 3 },
                           { 4, 5, 6 },
                           { 7, 8, 9 }
                         };
                        
        double[,] Mat2 = { { -9, -8, -7 },
                           { -6, -5, -4 },
                           { -3, -2, -1 }
                         };

        // Add Two Matrices
        double[,] resultAdd = Matrices.Add(Mat1, Mat2);
        Console.WriteLine("Added Matrix: ");
        Matrices.PrintMatrix(resultAdd);

        // Subtract Two Matrices
        double[,] resultSub = Matrices.Subtract(Mat1, Mat2);
        Console.WriteLine("Subtracted Matrix: ");
        Matrices.PrintMatrix(resultSub);

        // Transpose Matrix
        double[,] resultTranspose = Matrices.Transpose(Mat1);
        Console.WriteLine("Transposed Matrix: ");
        Matrices.PrintMatrix(resultTranspose);

    }
}