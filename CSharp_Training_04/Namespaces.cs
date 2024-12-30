using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace namespace_1
{
    public class ns1
    {
        public void someMethod()
        {
            Console.WriteLine("someMethod from namespace_1");
        }
    }

    namespace namespace_1a
    {
        public class ns1a
        {
            public void someMethod()
            {
                Console.WriteLine("someMethod from namespace_1a");
            }
        }

    }
}
namespace namespace_2
{
    public class ns2
    {
        public void someMethod()
        {
            Console.WriteLine("someMethod from namespace_2");
        }
    }
}
