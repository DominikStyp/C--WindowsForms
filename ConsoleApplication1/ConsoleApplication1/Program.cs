using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Read();
        }

        private static void d(Object o)
        {
            Console.WriteLine(o.ToString());
        }
        private static void setMyProp()
        {
            try
            {
                myProp = 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.Read();
            }
        }

        // Specify properties getters and setters
        private static int myProp
        {
            get { return myProp; }
            set
            {
                if(value == 0)
                {
                    throw new Exception("Zero is not allowed here");
                }
            }
        }

        /// <summary>
        /// Throwing exceptions example
        /// </summary>
        private static void exTest()
        {
            try
            {
                int x = 10;
                int y = 0;
                if((x / y) == 0 )
                {
                    Console.WriteLine("OK");
                }
            } catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.Read();
            }
        }

        private static void rectangleTest()
        {
            Rectangle r = new Rectangle(2, 2) + new Rectangle(5, 1);
            d("Rectangle area: " + r.area());
            Square s = new Square(3);
            d("Square area: " + s.area());
        }
    }





  












}
