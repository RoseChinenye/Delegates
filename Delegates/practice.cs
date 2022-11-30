using System.Text;

namespace Delegates
{
    internal class practice
    {
        //declaration
        public delegate int Mydelegate(int n, int m);

        //using stringbuilder instead of console to print all the functions
        static StringBuilder StringB { get; set; } = new StringBuilder();
        public void Run()
        {
            Mydelegate mydelegate = new Mydelegate(Add);
            //Mydelegate mydelegate1= mydelegate; Another way of initializing

            
            //Add methods
            mydelegate += Add; //91
            mydelegate += Substract; //-1
            mydelegate += Multiply; //2070

            //invoke
            //int result = mydelegate.Invoke(45, 46);
            // Console.WriteLine(result);

            mydelegate.Invoke(45, 46);

            Console.WriteLine(StringB.ToString());
        }

        public static int Add(int numOne, int numTwo)
        {
            StringB.Append($"Add:{numOne + numTwo}\n");    
            return numOne + numTwo;
        }

        public static int Substract(int numOne, int numTwo)
        {
            StringB.Append($"Substract:{numOne - numTwo}\n");
            return numOne - numTwo;
        }

        public static int Multiply(int numOne, int numTwo)
        {
            StringB.Append($"Multiply:{numOne * numTwo}\n");
            return numOne * numTwo;
        }
        
    }
}
