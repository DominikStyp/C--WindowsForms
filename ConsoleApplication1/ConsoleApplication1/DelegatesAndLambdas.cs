using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class DelegatesAndLambdas
    {
        DelegatesAndLambdas()
        {
            new DelegateExamples().test();
        }
    }

    //////////////////////////////////////////////////////////////

    class DelegateExamples
    {
        delegate int doSomething(int x, int y);
        public void test()
        {
            doSomething sum = delegate (int x, int y)
            {
                return x + y;
            };
            Console.WriteLine("Delegate sum: " + sum(1, 2));
        }
    }

    class LambdaExamples
    {
        public void test()
        {
            // last argument type is return type of lambda
            Func<string, string, string, string> concat = (x, y, z) => { StringBuilder b = new StringBuilder(); b.Append(x); b.Append(y); return b.ToString(); };
            Console.WriteLine("Concatenated: " + concat("O", "K", "!"));
        }
    }


}
