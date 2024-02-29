using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
    public class Add
    {
        public static int AddNumbers (int a, int b)
        { 
            return a + b; 
        }

        public static float AddNumbers (float a, float b) 
        { 
            return a + b; 
        }

        public static void Concatenate (string name, string lastName)
        {
            Console.WriteLine($"{name} {lastName}");

        }

        public static void Concatenate (string name, string lastName, string nickName)
        {
            Console.WriteLine($"{name} {lastName}. Or just more simple {nickName}");
        }

        public static void PrinInfo (string name, int age)
        { 
            Console.WriteLine($"{name} {age} old"); 
        }

        public static void PrinInfo (string name, int age, string adress)
        {
            Console.WriteLine($"{name} {age} old, lives at this adress: {adress}");
        }

        public static int Calculate (int a, int b)
        {
           return a + b;
        }

        public static int Calculate (int a, int b, string newParameter)
        {
            if (newParameter == "-")
            {
                return a - b;
            }

            if (newParameter == "*")
            {
                return a * b;
            }

            if (newParameter == "/")
            {
                return a / b;
            }
            else
            {
                return a + b;
            }


        }



    }



}
