using Challenge_Mercap_Llamadas;

public class InternationalCall : Call
{
    public string Country { get; set; }

    public override ICostCalculationStrategy CostStrategy { get; } = new InternationalCallCostStrategy();
}
