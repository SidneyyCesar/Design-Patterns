﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    public class Context
    {
        public string Name { get; set; }

        public Context(string name)
        {
            Name = name;
        }
    }
}
