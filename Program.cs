using System;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            try
            {
                int y = 100 / x;
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("ArithmeticException Handler: {0}", e.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("Generic Exception Handler: {0}", e.ToString());
            }
        }
    }
}
