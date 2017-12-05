namespace MultiCurrency
{
    public class Money : IExpression
    {
        public int Amount { get; set; }

        public string Currency { get; set; }

        public Money(int amount, string currency)
        {
            this.Amount = amount;
            this.Currency = currency;
        }

        public static Money Dollar(int amount)
        {
            return new Money(amount, "USD");
        }

        public static Money Franc(int amount)
        {
            return new Money(amount, "CHF");
        }

        public Money Times(int multiplier)
        {
            return new Money(Amount * multiplier, Currency);
        }

        public IExpression Plus(Money addend)
        {
            return new Sum(this, addend);
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1}", Amount, Currency);
        }

        public override bool Equals(object obj)
        {
            var money = (Money)obj;
            return Amount == money.Amount && Currency == money.Currency;
        }

        public Money Reduce(Bank bank, string to)
        {
            int rate = bank.Rate(Currency, to);
            return new Money(Amount / rate, to);
        }

        //protected bool Equals(Money money)
        //{
        //    return Amount == money.Amount;
        //}

        //public override int GetHashCode()
        //{
        //    // ReSharper disable once NonReadonlyMemberInGetHashCode
        //    return Amount.GetHashCode();
        //}
    }
}
