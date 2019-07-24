using System;

namespace MyFirstConsoleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int answer = Arithmetic.Add(3, 7);
            Console.WriteLine("3 + 7 = " + answer);
            answer = Arithmetic.Sub(10, 6);
            Console.WriteLine("10 - 6 = " + answer); 
            answer = Arithmetic.Mult(5, 7);
            Console.WriteLine("5 * 7 = " + answer);
            answer = Arithmetic.Div(7, 2);
            Console.WriteLine("7 / 2 = " + answer);
            answer = Arithmetic.Mod(2345, 317);
            //Console.WriteLine("7 Mod 2 = " + answer);
            bool TorF = Arithmetic.IsEvenlyDivisible(655, 5);
            Console.WriteLine($"655 is evenly divisible by 5: {TorF}");
        }
    }
    class Arithmetic
    {   
        public static int Add(int a, int b){return a + b;} 
        public static int Sub(int a, int b){return a - b;} 
        public static int Mult(int a, int b){return a * b;}
        public static int Div(int a, int b){return a / b;}
        public static int Mod(int a, int b){int answer = a % b; Console.WriteLine($"{a} mod {b} = {answer}"); return answer;} //$ denotes "Interpolation"
        public static bool IsEvenlyDivisible(int a, int b){return Mod(a, b) == 0;}
    }
}
