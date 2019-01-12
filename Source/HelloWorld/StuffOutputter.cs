using System;

namespace HelloWorld
{                                  
    class StuffOutputter
    {
        public static void OutputStuff()
        {
            for (var i = 0; i < 5; i++)
            {
                NewMethod2();
            }
        }

        static void NewMethod2()
        {
            for (var loopNumber = 0; loopNumber < 10; loopNumber++)
            {
                NewMethod3();
            }
        }

        static void NewMethod3()
        {
            for (var loopNumber = 0; loopNumber < 100; loopNumber++)
            {
                Console.WriteLine("Hello there, I am at loop number " + loopNumber);
            }
        }
    }
}