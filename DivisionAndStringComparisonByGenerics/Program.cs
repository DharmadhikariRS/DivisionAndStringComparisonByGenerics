namespace DivisionAndStringComparisonByGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q =Write interger number division , float number division  and compare the
            //string must be in upper case only then refactor code by using generic method

            Console.WriteLine("Press 1 for intiger Division without generics");
            Console.WriteLine("Press 2 for float Division without generics");
            Console.WriteLine("Press 3 for intiger Division with generics");
            Console.WriteLine("Press 4 for float Division with generics");
            Console.WriteLine("Press 5 for Strings compare without generics");
            Console.WriteLine("Press 6 for Strings compare with generics");

            DivisionProblems divisionProblems = new DivisionProblems();

            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    divisionProblems.IntDivision();
                    break;
                case 2:
                    divisionProblems.FloatDivision();
                    break;
                case 3:
                    Console.WriteLine("Enter 2 Integers");
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());

                    divisionProblems.DivByGenerics(a, b);
                    break;
                case 4:

                    Console.WriteLine("Enter 2 Float values");
                    float Num1 = float.Parse(Console.ReadLine());
                    float Num2 = float.Parse(Console.ReadLine());

                    divisionProblems.DivByGenerics(Num1, Num2);

                    break;
                case 5:

                    divisionProblems.CompareString();
                    break;
                case 6:
                    Console.WriteLine("Enter 2 Strings");
                    string Number1 = Console.ReadLine();
                    string Number2 = Console.ReadLine();

                    divisionProblems.DivByGenerics(Number1, Number2);
                    break;
            }
        }
    }
}