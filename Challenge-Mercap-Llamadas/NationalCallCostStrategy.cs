using Challenge_Mercap_Llamadas;

public class NationalCallCostStrategy : ICostCalculationStrategy
{
    public double CalculateCost(Call call)
    {
        NationalCall nationalCall = call as NationalCall;
        if (nationalCall == null) return 0.0;

        switch (nationalCall.Destination)
        {
            case "Santa Fe":
                return 0.20 * (nationalCall.End - nationalCall.Start).TotalMinutes;
            case "Buenos Aires":
                return 0.15 * (nationalCall.End - nationalCall.Start).TotalMinutes;
            case "Cordoba":
                return 0.25 * (nationalCall.End - nationalCall.Start).TotalMinutes;
            default:
                return 0.10 * (nationalCall.End - nationalCall.Start).TotalMinutes;
        }
    }
}
