using System.Runtime.InteropServices;

namespace Praticeweek3
{
    internal class Program
    {
        /*int addNumber (int a , int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {

            //call the class program
            Program add1 = new Program();
            int sum =  add1.addNumber (1, 2);
            Console.WriteLine("Sum: " + sum);
            Console.ReadLine();

        }*/


        //float pratice

        /* static  float NumberCalc (float x, float y)
           {
               return x + y;
           }



           static void Main(string[] args)
           {

               //float float1 = new Program();

               Console.WriteLine("Please provide float 1:");
               float getfloat = float.Parse(Console.ReadLine());

               Console.WriteLine("Please provide float 2:");
               float getfloat1 = float.Parse(Console.ReadLine());

               //    float write =  float1.NumberCalc(getfloat, getfloat1);
               float write = NumberCalc(getfloat, getfloat1);

               Console.WriteLine("float is {0}", write);

           }*/


        //pratice odd or even

         static int RequestValue()
        {
            Console.Write("Enter a value ");
            int value = int.Parse(Console.ReadLine());
          
            return value;
        }


        static bool IsEven(int value )
        {
            return value % 2 == 0;
        }

        private static void PrintResult(bool isEven, int value)
        {
            //condition that check if the value is odd or even
            if(isEven == true )
            {
                Console.WriteLine($"{value} is even");
            }else
            {
                Console.WriteLine($"{value} is odd");
            }

            
        }


        static void Main(string[] args)
        {
            int value = RequestValue();
            bool isEven = IsEven(value);
            PrintResult(isEven, value);
             value = RequestValue();
             isEven = IsEven(value);
             PrintResult(isEven, value);
             value = RequestValue();
             isEven = IsEven(value);
             PrintResult(isEven, value);
            Console.ReadLine();
        }

      
    }
}