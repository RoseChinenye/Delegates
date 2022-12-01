using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class builtInDelegate
    {
        /* Func Delegate: can take 0-16 parameters but returns a value.
         * action Delegate: can take 0-16 parameters but doesn't return anything.
         * predicate: " " but returns a bool.
         */

        public delegate int MimicFunc(int number, string month, int count);

        public static void Run()
        {
            MimicFunc mimicFunc = MethodA;

            Func <int, string, int, int> func = MethodA;

            int result = func.Invoke(12, "54", 37);
            Console.WriteLine(result);
        }

        public static int MethodA(int number, string month, int count)
        {
            return number;
        }
    }

}
