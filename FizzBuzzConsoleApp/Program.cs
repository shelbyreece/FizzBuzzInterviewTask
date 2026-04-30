namespace FizzBuzzConsoleApp
{
    using FizzBuzzLib;
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzzer = new FizzBuzz();
            var results = fizzBuzzer.FizzBuzzValuesForRange(1, 100);
            foreach(var item in results){
                Console.WriteLine(item);
            }       
        }
    }
}
