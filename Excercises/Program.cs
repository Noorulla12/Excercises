using System;

namespace Excercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  1.
           Console.WriteLine("Enter a Value:");
           var height = Convert.ToInt16(Console.ReadLine());
           var width  =  Convert.ToInt16(Console.ReadLine());

            if (height > width )
            {
                Console.WriteLine("Portrait");
            }
            else
            {
                Console.WriteLine("Landscape");
            }   */


            /*  2.
              Console.WriteLine("Enter a Value:");
              var number = Convert.ToInt16(Console.ReadLine());


              if (number > 0 && number < 10)
              {
                  Console.WriteLine("Valid");
              }
              else
              {
                  Console.WriteLine("InValid");
              }   */


            Console.WriteLine("Enter a Values:");
            var number1 = Convert.ToInt16(Console.ReadLine());
            var number2 = Convert.ToInt16(Console.ReadLine());

            var maxValue = (number1 > number2) ? number1 : number2;
            Console.WriteLine(maxValue);




        }
    }
}