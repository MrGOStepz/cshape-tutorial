using System;
using CShapeTutorial.Basic;

namespace CShapeTutorial
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // B4_CharacterAndString characterAndString = new B4_CharacterAndString();
            // characterAndString.CharType();
            B5_Operation operation = new B5_Operation();
            operation.OrderOfEvaluation();
        }
    }
}