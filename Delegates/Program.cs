namespace Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            practice practice = new practice();
            //practice.Run();
            
            builtInDelegate builtInDelegate= new builtInDelegate(); 
            builtInDelegate.Run();

            
        }
    }
}