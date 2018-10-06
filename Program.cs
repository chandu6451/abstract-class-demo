using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Shape s = new Shape();

            Shape sc = new Circle();
            sc.Draw();
            sc.Show();

            Circle c = new Circle();
            c.Draw();
            c.Show();

            Shape ss = new Square();
            ss.Draw();
            ss.Show();

            Square s = new Square();
            s.Draw();
            s.Show();

            Console.ReadKey();


        }
    }
}
