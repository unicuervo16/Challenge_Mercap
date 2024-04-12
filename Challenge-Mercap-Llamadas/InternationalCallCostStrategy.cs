using Challenge_Mercap_Llamadas;

public class InternationalCallCostStrategy : ICostCalculationStrategy
{
    public double CalculateCost(Call call)
    {
        InternationalCall internationalCall = call as InternationalCall;
        if (internationalCall == null) return 0.0; 

        double ratePerMinute;
        switch (internationalCall.Country)
        {
            case "Argentina":
                ratePerMinute = 0.70;
                break;
            case "Chile":
                ratePerMinute = 0.80;
                break;
            case "Brazil":
                ratePerMinute = 0.75;
                break;
            default:
                ratePerMinute = 0.65;
                break;
        }
        return ratePerMinute * (internationalCall.End - internationalCall.Start).TotalMinutes;
    }
}
