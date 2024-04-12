using Challenge_Mercap_Llamadas;

public class NationalCall : Call
{
    public string Destination { get; set; }

    public override ICostCalculationStrategy CostStrategy { get; } = new NationalCallCostStrategy();
}
