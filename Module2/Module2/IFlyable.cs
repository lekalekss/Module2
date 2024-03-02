using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
    public interface IFlyable
    {
        public void Fly();
    }

    public class Bird : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("\nThe bird soars in the sky");
        }
    }

    public class Airplane : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Intercontinental Boeing 747 flies over Atlantic Ocean");
        }
    }
}

