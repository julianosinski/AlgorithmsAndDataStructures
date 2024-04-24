using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructures.Recursion
{
    public class Recursion
    {
        public void CallStackOverFllow()
        {
            CallStackOverFllow();
        }

        public void MinusByOne(int n)
        {
            if (n > 0)
            {
                MinusByOne(n-1);
            }
            Console.WriteLine("Call: "+n);// Write To console when function is poped out of stack
        }
        //Factorial (Silnia)
        public int Factorial(int num)
        {
            if (num < 2) { return 1; } //base case
            return num * Factorial(num - 1);
        } 

        public int IterativeFactorial(int num)
        {
            int factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
