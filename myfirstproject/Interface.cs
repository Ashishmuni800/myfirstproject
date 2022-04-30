using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject
{
    class Interface
    {
        
        interface c1
        {
            void Show();
        }
        public class get : c1
        {
            public void Show()
            {
                Console.WriteLine("hello");
            }
        }
    }
}
