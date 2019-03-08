using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autofac
{
    interface ITest {
        void ok();
    }
    class Test : ITest
    {
        public void ok()
        {
            Console.WriteLine("OK");
        }
    }
}
