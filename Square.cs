using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    public class Square : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Square Class Draw Method");
        }

        public override void Show()
        {
            Console.WriteLine("Square Class Show Method");
        }
    }
}
