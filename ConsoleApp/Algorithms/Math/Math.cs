public class MyMath
{
    // Add
    public static int Add(params int[] numbers)
    {
        int sum = 0;
        foreach (int n in numbers)
        {
            sum += n;
        }
        return sum;
    }

    // Subtract
    public static int Subtract(params int[] numbers)
    {
        int sub = 0;
        foreach (int n in numbers)
        {
            sub -= n;
        }
        return sub;
    }

    // Multiply
    public static double Multiply(params double[] numbers)
    {
        double mul = 1;
        foreach (double n in numbers)
        {
            mul *= n;
        }
        return mul;
    }

    // Division
    public static int Divide(params int[] numbers)
    {
        if (numbers.Length == 0) throw new ArgumentException("At least one number is required");
        int div = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] == 0) throw new DivideByZeroException("Cannot divide by zero");
            div /= numbers[i];
        }
        return div;
    }

    // Modulus
    public static int Modulus(int a, int b)
    {
        if (b == 0) throw new DivideByZeroException("Cannot perform modulus by zero");
        return a % b;
    }

    // Exponents
    public static double Power(double baseNum, double exponent)
    {
        for (int i = 1; i < exponent; i++)
        {
            baseNum *= baseNum;
        }
        return baseNum;
    }

    // SquareRoot
    public static double SQRT(double number)
    {
        if (number < 0) throw new ArgumentException("Cannot compute square root of a negative number");
        return Power(number, 0.5);
    }

    public static int abs(int a)
    {
        if (a < 0)
        {
            return -a;
        }
        else
        {
            return a;
        }
    }

    // Find Factorial of a Number
    public static int Factorial(int number)
    {
        if (number < 0) throw new ArgumentException("Cannot compute factorial of a negative number");
        if (number == 0 || number == 1) return 1;
        int fact = 1;
        for (int i = 2; i <= number; i++)
        {
            fact *= i;
        }
        return fact;
    }

    // Find Factorial using Recursion
    public static int RecursiveFactorial(int number)
    {
        if (number == 0 || number == 1) return 1;
        else return number * (number - 1);
    }

    // Find Permutation of Two Integer Numbers
    public static int Permutaion(int n, int r)
    {
        if (n < 0 || r < 0)
        {
            throw new ArgumentException("Cannot Find Permutation of Negative Numbers");
        }
        if (n.GetType() != typeof(int) || r.GetType() != typeof(int))
        {
            throw new ArgumentException("Permutations can be Apply only On Integer Numbers ");
        }
        int permutaion = Factorial(n) / Factorial(n - r);

        return permutaion;
    }

    // Find Combination of Two Integer Numbers
    public static int Combination(int n, int r)
    {
        if (n < 0 || r < 0)
        {
            throw new ArgumentException("Cannot Find Combination of Negative Numbers");
        }
        if (n.GetType() != typeof(int) || r.GetType() != typeof(int))
        {
            throw new ArgumentException("Combinations can be Applied only On Integer Numbers ");
        }
        int permutaion = Factorial(n) / Factorial(r) * Factorial(n - r);

        return permutaion;
    }

    // Find Floor of a Double Number
    public static int Floor(double a)
    {
        return (int)a;
    }

    // Find Ceil of a Double Number
    public static int Ceil(double a)
    {
        return (int)a + 1;
    }

    // Find Round of a Double Number
    public static double Round(double a)
    {
        int floorInput = MyMath.Floor(a);
        double DecimalVal = a - floorInput;
        if (DecimalVal >= 0.5)
        {
            return a + 0.1;
        }
        else
        {
            return a;
        }
    }

    // Find Max Number of array of Double Number
    public static double Max(params double[] numbers)
    {
        int largest = 0;

        foreach (int num in numbers)
        {
            if (num > largest)
            {
                largest = num;
            }
        }

        return largest;
    }

    // Find Min Number of array of Double Number
    public static double Min(params double[] numbers)
    {
        int smallest = 0;

        foreach (int num in numbers)
        {
            if (num < smallest)
            {
                smallest = num;
            }
        }

        return smallest;
    }

    public static double ToRadians(double degrees)
    {
        return Multiply(degrees, Math.PI / 180);
    }

    // Find Sin 
    public static double Sin(double x)
    {
        double result = 0;
        for (int i = 0; i < 20; i++)
        {
            result += Power(-1, i) * Power(x, 2 * i + 1) / Factorial(2 * i + 1);
        }
        return result;
    }

    // Find Cos 
    public static double Cos(double x)
    {
        double result = 0;
        for (int i = 0; i < 20; i++)
        {
            result += Power(-1, i) * Power(x, 2 * i + 1) / Factorial(2 * i + 1);
        }
        return result;
    }

    // Find Tan
    public static double Tan(double x)
    {
        return Sin(x) / Cos(x);
    }

    // Find Sec
    public static double Sec(double x)
    {
        return Power(Cos(x),-1);
    }

    // Find Cosec
    public static double Cosec(double x)
    {
        return Power(Sin(x),-1);
    }

    // Find Cot
    public static double Cot(double x)
    {
        return Power(Tan(x),-1);
    }


}
