using Challenge_Mercap_Llamadas;

class Program
{
    static void Main(string[] args)
    {
        List<Call> calls = new List<Call>
        {
            // Llamadas en marzo
            new LocalCall { Start = new DateTime(2024, 3, 10, 10, 30, 0), End = new DateTime(2024, 3, 10, 11, 0, 0) },
            new NationalCall { Start = new DateTime(2024, 3, 5, 12, 0, 0), End = new DateTime(2024, 3, 5, 12, 30, 0), Destination = "Cordoba" },
            new InternationalCall { Start = new DateTime(2024, 3, 20, 10, 0, 0), End = new DateTime(2024, 3, 20, 10, 45, 0), Country = "Chile" },
            new InternationalCall { Start = new DateTime(2024, 3, 25, 15, 0, 0), End = new DateTime(2024, 3, 25, 15, 30, 0), Country = "Peru" },
            new InternationalCall { Start = new DateTime(2024, 3, 10, 15, 0, 0), End = new DateTime(2024, 3, 10, 15, 21, 0), Country = "Santa Fe" },
            // Llamadas en abril
            new LocalCall { Start = new DateTime(2024, 4, 10, 9, 30, 0), End = new DateTime(2024, 4, 10, 10, 0, 0) },
            new NationalCall { Start = new DateTime(2024, 4, 12, 11, 0, 0), End = new DateTime(2024, 4, 12, 11, 30, 0), Destination = "Santa Fe" },
            new InternationalCall { Start = new DateTime(2024, 4, 15, 14, 0, 0), End = new DateTime(2024, 4, 15, 14, 30, 0), Country = "Brazil" },
            new InternationalCall { Start = new DateTime(2024, 4, 18, 16, 0, 0), End = new DateTime(2024, 4, 18, 16, 45, 0), Country = "Argentina" },
        };

        BillingProcessor billingProcessor = new BillingProcessor();
        billingProcessor.CalculateBill(calls);
    }
}