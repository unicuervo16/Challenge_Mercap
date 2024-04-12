
namespace Challenge_Mercap_Llamadas
{
    public class LocalCall : Call
    {
        public override ICostCalculationStrategy CostStrategy { get; } = new LocalCallCostStrategy();
    }

}
