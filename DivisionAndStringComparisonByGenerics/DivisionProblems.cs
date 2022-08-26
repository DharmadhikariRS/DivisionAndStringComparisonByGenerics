using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisionAndStringComparisonByGenerics
{
    internal class DivisionProblems
    {
        public void IntDivision()
        {
            Console.WriteLine("Enter 2 Integers");
            int Num1 = int.Parse(Console.ReadLine());
            int Num2 = int.Parse(Console.ReadLine());

            float Div = ((float)Num1 / (float)Num2);

            Console.WriteLine("Division is= " + Div);
        }
        public void FloatDivision()

        {
            Console.WriteLine("Enter 2 Float values");
            float Num1 = float.Parse(Console.ReadLine());
            float Num2 = float.Parse(Console.ReadLine());

            float Div = (Num1 / Num2);

            Console.WriteLine("Division is= " + Div);
        }
        public void CompareString()
        {
            Console.WriteLine("Enter 2 Strings");
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            s1 = s1.ToUpper();
            s2 = s2.ToUpper();
            if (s1 == s2)
            {
                Console.WriteLine("Strings are equal");
            }
            else
            {
                Console.WriteLine("Strings are not Equal");
            }
        }
        public void DivByGenerics<T>(T Val1, T Val2)
        {
            if (Val1.GetType() == typeof(int))
            {
                float Div;

                Div = (float)(dynamic)Val1 / (float)(dynamic)Val2;
                Console.WriteLine("Division is= " + Div);
            }
            else
            if (Val1.GetType() == typeof(float))
            {
                float Div;
                Div = (dynamic)Val1 / (dynamic)Val2;
                Console.WriteLine("Division is= " + Div);
            }
            else
            {
                string s1 = Val1.ToString().ToUpper();
                string s2 = Val2.ToString().ToUpper();
                if (s1.Equals(s2))
                {
                    Console.WriteLine("Strings are equal");
                }
                else
                {
                    Console.WriteLine("Strings are not Equal");
                }
            }
        }

    }
}
