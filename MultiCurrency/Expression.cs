namespace MultiCurrency
{
    public interface IExpression
    {
        Money Reduce(Bank bank, string to);
    }
}