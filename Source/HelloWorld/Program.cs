using System;

namespace HelloWorld
{                                  
    class Program
    {      
        static void Main(string[] args)
        {
            StuffOutputter.OutputStuff();
        }
        
        // x = y + 1
        // z = x + 2

        static int A(int y)
        {
            return y + 1;
        }

        static int B(int y)
        {
            return A(y) + 2;
        }
    }
}
