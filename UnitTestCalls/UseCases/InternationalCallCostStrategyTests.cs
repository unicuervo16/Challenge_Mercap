public class InternationalCallCostStrategyTests
{
    [Fact]
    public void CalculateCost_ToChile_CostIsCorrect()
    {
        // Arrange
        var strategy = new InternationalCallCostStrategy();
        var call = new InternationalCall
        {
            Start = new DateTime(2024, 3, 20, 10, 0, 0), 
            End = new DateTime(2024, 3, 20, 10, 45, 0), 
            Country = "Chile"
        };

        // Act
        var cost = strategy.CalculateCost(call);

        // Assert
        Assert.Equal(36.0, cost);
    }
}
