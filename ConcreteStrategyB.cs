﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paternss
{
    using System;

    public class ConcreteStrategyB : IStrategy
    {
        public void ExecuteAlgorithm()
        {
            Console.WriteLine("Executing algorithm for Strategy B.");
        }
    }
}
