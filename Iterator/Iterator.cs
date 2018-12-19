using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    public class IteratorExample 
    {
        Dictionary<string, string> _dictionary;

        public IteratorExample()
        {
            // Add 5 names to a key/value pair list.
            _dictionary = new Dictionary<string, string>();
            _dictionary.Add("Hans", "Pisces");
            _dictionary.Add("Fred", "Aquarius");
            _dictionary.Add("Andrew", "Gemini");
            _dictionary.Add("Zach", "Scorpio");
            _dictionary.Add("Berfa", "Cancer");
        }

    }
}
