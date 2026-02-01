using System;

namespace CShapeTutorial.Basic
{
    public class B5_Operation
    {
        
        public void BasicOperation()
        {
           // Arithmetic Operations
           // Addition, Subtraction, Multiplication, Division, Modulus
           
           //Assignment Operations
           // =, +=, -=, *=, /=, %=, &=, |=, ^=, <<=, >>=
           
           //Comparison Operations
           // >, <, >=, <=, ==, !=
           
           //Logical Operations
           // &&, ||, !
           
           //Increment/Decrement Operations 
           // ++, --
        }

        public void OrderOfEvaluation()
        { 
            // Order of Evaluation
           //https://learn.microsoft.com/en-us/cpp/c-language/precedence-and-order-of-evaluation?view=msvc-170 
           
           int value = 10 + 2 * 3;
           Console.WriteLine(value);
        }
    }
}