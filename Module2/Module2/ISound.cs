using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
    public interface ISound
    {
        public void MakeSound();

    }

    public class Dog : ISound
    {
        
        public void MakeSound()
        {
            Console.WriteLine("Dog is barking");
        }
    }

    public class Cat : ISound
    {

        public void MakeSound()
        {
            Console.WriteLine("Cat is meowing");
        }
    }
}
