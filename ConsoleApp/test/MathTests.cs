class MathTests : Test
{
    public override void RunTest()
    {
        // Convert Degrees to Radians
        double radians = MyMath.ToRadians(90);

        // Add numbers
        Console.WriteLine("Add: " + MyMath.Add(1, 2, 3, 4, 5));

        // Subtract numbers (from left to right)
        Console.WriteLine("Subtract: " + MyMath.Subtract(5, 4, 3, 2, 1));

        // Multiply numbers
        Console.WriteLine("Multiply: " + MyMath.Multiply(1, 2, 3, 4, 5));

        // Divide numbers
        Console.WriteLine("Divide: " + MyMath.Divide(1, 2));

        // Modulus (Remainder)
        Console.WriteLine("Modulus: " + MyMath.Modulus(1, 2));

        // Power (x^y)
        Console.WriteLine("Power: " + MyMath.Power(5, 2));

        // Square Root
        Console.WriteLine("SQRT: " + MyMath.SQRT(4));

        // Factorial using Loop
        Console.WriteLine("Factorial: " + MyMath.Factorial(5));

        // Factorial using Recursion
        Console.WriteLine("Recursive Factorial: " + MyMath.RecursiveFactorial(5));

        // Permutation (nPr)
        Console.WriteLine("Permutation: " + MyMath.Permutaion(5, 2));

        // Combination (nCr)
        Console.WriteLine("Combination: " + MyMath.Combination(5, 2));

        // Floor of a number
        Console.WriteLine("Floor: " + MyMath.Floor(5.5));

        // Ceil of a number
        Console.WriteLine("Ceil: " + MyMath.Ceil(5.5));

        // Round a number
        Console.WriteLine("Round: " + MyMath.Round(5.5));

        // Maximum value
        Console.WriteLine("Max: " + MyMath.Max(1, 2, 3, 4));

        // Minimum value
        Console.WriteLine("Min: " + MyMath.Min(1, 2, 3, 4, 5));

        // Maximum value (again test)
        Console.WriteLine("Max (again): " + MyMath.Max(1, 2, 3, 4));

        // Minimum value (again test)
        Console.WriteLine("Min (again): " + MyMath.Min(1, 2, 3, 4, 5));

        // Floor Double Number
        Console.WriteLine("Floor (double): " + MyMath.Floor(6.7));

        // Ceil Double Number
        Console.WriteLine("Ceil (double): " + MyMath.Ceil(6.7));

        // Round Double Number
        Console.WriteLine("Round (double): " + MyMath.Round(0.5));

        // Sine value (angle in radians)
        Console.WriteLine("Sin: " + MyMath.Sin(radians));

        // Cosine value (angle in radians)
        Console.WriteLine("Cos: " + MyMath.Cos(radians));

        // Tangent value (angle in radians)
        Console.WriteLine("Tan: " + MyMath.Tan(radians));

        // Secant value (1/cos)
        Console.WriteLine("Sec: " + MyMath.Sec(radians));

        // Cosecant value (1/sin)
        Console.WriteLine("Cosec: " + MyMath.Cosec(radians));

        // Cotangent value (1/tan)
        Console.WriteLine("Cot: " + MyMath.Cot(radians));
    }
}
