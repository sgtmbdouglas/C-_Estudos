public enum PaymentType
{
    Credit,
    Debit,
    InCash = Debit,
    InParts = Credit,
}

public static class Program
{
    public static void Main()
    {
        Console.WriteLine(PaymentType.Credit + " " + (int)PaymentType.Credit);
        // Credit 0
        Console.WriteLine(System.Enum.IsDefined(typeof(PaymentType), 0));
        // true
        Console.WriteLine(System.Enum.IsDefined(typeof(PaymentType), "Credit"));
        // true
    }
}