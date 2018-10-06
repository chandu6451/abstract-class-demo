using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    public abstract class Shape
    {
        public abstract void Draw();

        public virtual void Show()
        {
            Console.WriteLine("Shape Class Show Method");
        }

        public static void Display()
        {
            Console.WriteLine("Shape Class Display Method");
        }
    }
}
