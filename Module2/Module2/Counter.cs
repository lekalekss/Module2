﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
    public static class Counter
    {
        public static int CallCount;

        public static int Increment()
        {
            return CallCount++;
        }
        

    }
}
