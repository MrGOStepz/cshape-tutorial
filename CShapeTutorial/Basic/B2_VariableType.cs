
namespace CShapeTutorial.Basic
{
    public class B2_VariableType
    {
        void VariableDeclaration()
        {
            //Data Type
            //Value Types
            PrimitiveType();
            //Reference Types
            //Object, Dynami, Strings, Arrays, Classes etc.
            ReferenceType();
            //User Defined Types
            // Class, Struct, Interface, Enum etc by user
            //Pointer Types
            // int value = 42;
            // int* myPointer = &value;
            //Struct Types
            // Classes, Structs, Record, Interface, Delegate, Enums etc.
            //Nullable Types
            
        }

        void PrimitiveType()
        {
            // Primitive Data Types
            // - Store actual data directly
            // - Typically stored in the stack
            // - Include int, float, long, double, char, bool, decimal, struct, enum
            // - Nullable versions available (int?, double?, etc.)
            // - Can be stored in heap if part of a reference type
            //Byte or Unsigned Byte 0-255
            byte myByte = 10;
            // Signed Byte -128 to 127
            sbyte mySByte = -100;
            //Short or Signed Short -32768 to 32767
            short myShort = -1000;
            //Unsigned Short 0 to 65535
            ushort myUShort = 10000;
            //Int or Unsigned Int -2,147,483,648 to 2,147,483,647
            int myInt = 1000000;
            //Unsigned Int 0 to 4,294,967,295
            uint myUInt = 1000000000;
            //Long or Unsigned Long -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            long myLong = 1000000000000;
            //Unsigned Long 0 to 18,446,744,073,709,551,615
            ulong myULong = 1000000000000000000;
            //Float or Single 3.402823E+38 to 1.4E-45
            float myFloat = 1000000000000000000.0f;
            float test = 10_000f;
            //Double or Double-precision 1.79769313486232E+308 to 5E-324
            double myDouble = 1000000000000000000.0d;
            //Decimal or Fixed-point Number 79228162514264337593543950335 to -79228162514264337593543950335
            decimal myDecimal = 1000000000000000000;
            // Double vs Decimal
            // https://www.google.com/search?q=decimal+vs+double+c%23&sca_esv=878c51bca6055a8e&rlz=1C1ONGR_enTH1189TH1189&sxsrf=ANbL-n4-C99sKI8dhP0M9h2LnugMyQQq_Q%3A1769932591217&ei=Lwd_aYLsDK_k1e8P5OHT-Qc&ved=0ahUKEwjCv4Db6LeSAxUvcvUHHeTwNH8Q4dUDCBE&uact=5&oq=decimal+vs+double+c%23&gs_lp=Egxnd3Mtd2l6LXNlcnAiFGRlY2ltYWwgdnMgZG91YmxlIGMjMgUQABiABDIGEAAYFhgeMgYQABgWGB4yBhAAGBYYHjIGEAAYFhgeMgYQABgWGB4yBhAAGBYYHjIGEAAYFhgeMgYQABgWGB4yBhAAGBYYHkiPhAFQAFiXgAFwAHgBkAEAmAGZAaABsQiqAQM1LjW4AQPIAQD4AQGYAg2gAtCwAsICChAjGIAEGCcYigXCAgQQIxgnwgILEAAYgAQYkQIYigXCAgsQABiABBixAxiKBcICCxAuGIAEGNEDGMcBwgIKEAAYgAQYQxiKBcICCBAAGIAEGLEDwgIREC4YgAQYsQMYxwEYigUYrwHCAiAQLhiABBixAxjHARiKBRivARiXBRjcBBjeBBjgBNgBAcICGhAuGIAEGNEDGMcBGJcFGNwEGN4EGOAE2AEBwgIIEAAYgAQYywGYAwC6BgYIARABGBSSBwc1LjQuOS00oAeERbIHAzUuNLgHsQfCBwYwLjEyLjHIBxiACAA&sclient=gws-wiz-serp
        }
        
        void ReferenceType()
        {
            // Memory Allocation
            
            // - Reference type is a variable type that instead of storing the value in memory directly, stores the memory location of the actual data
            // - The variable here stores the memory reference of the data and not the data directly
            // - Reference type data types are string, class, Array etc.
            // - When we copy this reference type of a data type it will just copy the memory address of the data so we will then have two variables pointing to the same data.
            // - Stored on the managed heap.
            string myString = "Hello World!";
            int[] myArray = new int[10];
            
            // Heap vs Ram
            // Ram the stack is for automatic, short-lived memory management, while the heap is for dynamic, long-lived objects managed by the garbage collector
            // https://www.google.com/search?q=what+is+heap+vs+ram+memory+c%23&sca_esv=878c51bca6055a8e&rlz=1C1ONGR_enTH1189TH1189&sxsrf=ANbL-n7tsm1r6hPYre9D8xS7zKyAk_MGAg%3A1769933221440&ei=pQl_af_KGoDBvr0P6r-9-Qc&ved=0ahUKEwi_scKH67eSAxWAoK8BHepfL38Q4dUDCBE&uact=5&oq=what+is+heap+vs+ram+memory+c%23&gs_lp=Egxnd3Mtd2l6LXNlcnAiHXdoYXQgaXMgaGVhcCB2cyByYW0gbWVtb3J5IGMjMgUQABjvBTIIEAAYgAQYogQyCBAAGIAEGKIEMggQABiiBBiJBUi4DlC5BFiwC3ABeAGQAQGYAcsBoAHkBqoBBTEuNS4xuAEDyAEA-AEBmAIGoALHBMICChAAGLADGNYEGEfCAgoQIRigARjDBBgKwgIIECEYoAEYwwSYAwCIBgGQBgiSBwMxLjWgB6cfsgcDMC41uAfEBMIHAzMuM8gHBoAIAA&sclient=gws-wiz-serp
        }
    }
}