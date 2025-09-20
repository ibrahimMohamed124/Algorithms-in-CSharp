using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Comment or Uncomment test Classes Below if you want to Display the Methods results of a Specific Class.
            List<Test> tests = new List<Test>
            {
                new StringAlgorithmTests(),
                // new ArrayAlgorithmsTest(),
                new MathTests(),
                // new SequencesTests(),
                // new CryptoTest(),
                // new MatricesTest(),
                // new MathTests()
            };

            foreach (var test in tests)
            {
                test.RunTest();
                Console.WriteLine();
            }

            Console.ReadKey(true);
        }
    }
}
