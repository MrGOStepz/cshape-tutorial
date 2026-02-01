using System;
using System.Text;

namespace CShapeTutorial.Basic
{
    public class B4_CharacterAndString
    {
        public void CharType()
        {
            //ASCII Table
            // https://www.ascii-code.com/
            // UTF-16
            // https://www.fileformat.info/info/charset/UTF-16/list.htm
            char myChar = 'A';
            Console.WriteLine(myChar);
            char myUTF = '\u0042';
            Console.WriteLine(myUTF);
            char myASCII = (char)65;
            Console.WriteLine(myASCII);
        }

        public void StringConcat()
        {
            string longChar = "Long Characters";
            Console.WriteLine(longChar);
            
            string value = "BAR";
            // string concatination
            // Don't try to use this
            Console.WriteLine("The result of : " + value + "test");

            // string interpolcation
            Console.WriteLine($"The result of {value} + test");

            // string formatting
            Console.WriteLine("The number is {0}, {1}", value, "TesT2");
            
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello World!");
            sb.Append(" ");
            sb.Append(value);
            Console.WriteLine(sb);
        }
        
        public void SpecialCharacters()
        {
            // \ is an Escape Character
            // \n stands for new line
            // \r - carriage return
            // \t tab
        }
        
    }
}