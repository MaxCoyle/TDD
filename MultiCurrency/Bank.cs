using System;
using System.Collections;

namespace MultiCurrency
{
    public class Bank
    {
        private Hashtable rates = new Hashtable();

        public Money Reduce(IExpression source, string to)
        {
            return source.Reduce(this, to);
        }

        public int Rate(string from, string to)
        {
            if (from.Equals(to)) return 1;
            return (int)rates[new Pair(from, to)];
        }

        public void AddRate(string from, string to, int rate)
        {
            rates.Add(new Pair(from, to), rate);
        }
    }
}