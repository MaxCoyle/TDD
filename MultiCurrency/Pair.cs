using System;
using System.Collections.Generic;
using System.Text;

namespace MultiCurrency
{
    public class Pair
    {
        public string From;
        public string To;

        public Pair(string from, string to)
        {
            this.From = from;
            this.To = to;
        }

        public override bool Equals(object obj)
        {
            var pair = (Pair)obj;
            return pair != null && From.Equals(pair.From) && To.Equals(pair.To);
        }

        public override int GetHashCode()
        {
            return 0;
        }
    }
}