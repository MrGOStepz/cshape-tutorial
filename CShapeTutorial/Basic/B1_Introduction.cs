using System; // Reference of .Net Framework Namespaces

namespace CShapeTutorial.Basic // Namespace Name
{
    //Concepts
    //https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/
    public class B1_Introduction
    {
        // This is the main entry point of any c# console application. The main method must be static, and it typically returns void (though it can also return int), indecating it does not return a value
        // Parameters: string p[ args represents an array of command-line arguments that can be passed to the program when it is executed
        // Code Block: The code block {} following the Main method contains the statements that are executed when the program runs
        public void Main(string[] args)
        {
            // Method
            // This line of code outputs the string "Hello World!" to the console window. It calls the WriteLine method of the Console class, which automatically adds a new line at the end of the output.
            Console.WriteLine("Hello World!"); //Method to Display value on Console
            
            // Syntax
            // Syntax is the set of rules that govern the structure and organization of code in a programming language. It defines how code elements such as keywords, identifiers, and operators should be arranged to form valid statements and expressions.
            
            // Expression
            // Evaluates to a single value
            // 1 + 1
            
            //Statement
            // Performs an action (side effect)
            // int a = 1 + 1;
            
            //Data Types
            //Example type int, double, string, bool
            //int -> Type
            //iAmANumber -> Name
            //5 -> Data
            int iAmANumber = 5;
            
            // implicitly typed variable
            var myFavoriteGenre = "LitRPGs";
        }

        //Method
        public void CommentExample()
        {
            //Comment
            //Single Line Comment

            /*
            Multi-line comment
            */
        }


        // XML Comment
        ///<summary>
        // This method displays "Hello World!" on the console.
        ///</summary>
        public void HelloWorld()
        {
        }

        void NamingConventions()
        {
            // Camel Case -> int myVariable;
            // Pascal Case -> public class MyClass{}
            // Snake Case -> my_variable
            //
            // Classes -> Pascal case Noun 
            // Methods -> Pascal case Verb 
            // Variables -> camel
            //
            // Best Practices for Consistent and Readable
            // - Clarity
            // - Consistency
            // - Collaboration
            // - Maintainability
        }
        
        int myVariable = 100;

        void CodeBlock()
        {
            int myVarInFunction = 200;
            
            Console.WriteLine(myVariable);
            Console.WriteLine(myVarInFunction);

            { 
                int myVarInBlock = 300;
            }
            // Console.WriteLine(myVarInBlock);
        }
    }
}