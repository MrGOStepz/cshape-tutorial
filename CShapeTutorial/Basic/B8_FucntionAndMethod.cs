using System;

namespace CShapeTutorial.Basic
{
    public class B8_FucntionAndMethod
    {
        //<Access Specifier> <Return Type> <Method Name> (<Parameter List>)
        //<Return Type> can be omitted if the method does not return a value.
        //<Parameter List> can be omitted if the method does not take any parameters.
        //<Access Specifier> can be one of the following: public, private, protected, internal, or abstract.
        //<Access Specifier> is optional if the method is inside a class.
        //<Return Type> can be any valid data type.
        //<Parameter List> can contain any number of parameters, separated by commas. Each parameter must be of a valid data type.
        //<Parameter Name> can be any valid identifier.
        //<Method Body> contains the statements that are executed when the method is called.
        //<Method Name> can be any valid identifier.
        void MethodWithoutParameter()
        {
            return;
        }

        int MethodWithMultipleParameters(int x, int y)
        {
            return x + y;
        }
        
        void MethodWithParameter(int x)
        {
            return;
        }

        // return type is int
        int MethodWithReturnParameter(int x)
        {
            return x;
        }

        // out parameter is mutable
        void MethodWithOutParameter(out int x)
        {
            x = 10;
        }

        
        // ref parameter is mutable
        void MethodWithRefParameter(ref int x)
        {
            x = 10;
        }
        
        
        // in parameter is readonly
        void MethodWithInParameter(in int x)
        {
            Console.WriteLine(x);
        }
        
        //Override
        void MethodOverriding(int x)
        {
            Console.WriteLine(x);
        }

        void MethodOverriding(string x)
        {
            Console.WriteLine(x);
        }
    }
}