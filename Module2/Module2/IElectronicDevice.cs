using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
    public interface IElectronicDevice
    {
        public void TurnOn();
        public void TurnOff();
    }

    public class TV : IElectronicDevice
    {
        public void TurnOff()
        {
            Console.WriteLine("\nThanks for using me today)\nSee you next time;)");
        }

        public void TurnOn()
        {
            Console.WriteLine("\nSamsung TV welcomes you!" +
                "Your guide to see the world brightly!");
        }
    }

    public class Laptop : IElectronicDevice
    {
        public void TurnOff()
        {
            Console.WriteLine("\nHP technologies...We will miss you!");
        }

        public void TurnOn()
        {
            Console.WriteLine("\nHellooooo. Your HP ready to help you today!");
        }
    }
}
