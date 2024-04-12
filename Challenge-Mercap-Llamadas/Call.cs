using Challenge_Mercap_Llamadas;

public abstract class Call
{
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public double Cost { get; set; }
    public abstract ICostCalculationStrategy CostStrategy { get; }

    public double CalculateCost()
    {
        this.Cost = CostStrategy.CalculateCost(this);
        return this.Cost;
    }
}
