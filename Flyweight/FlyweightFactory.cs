﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    class FlyweightFactory
    {
        private Hashtable flyweights = new Hashtable();
        
        public FlyweightFactory()
        {
            flyweights.Add("X", new ConcreteFlyweight());
            flyweights.Add("Y", new ConcreteFlyweight());
            flyweights.Add("Z", new ConcreteFlyweight());
        }

        public Flyweight GetFlyweight(string key)
        {
            return ((Flyweight)flyweights[key]);
        }
    }
}
