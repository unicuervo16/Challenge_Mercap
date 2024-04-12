public class NationalCallCostStrategyTests
{
    [Fact]
    public void CalculateCost_ToCordoba_CostIsCorrect()
    {
        // Arrange
        var strategy = new NationalCallCostStrategy();
        var call = new NationalCall
        {
            Start = new DateTime(2024, 3, 5, 12, 0, 0),
            End = new DateTime(2024, 3, 5, 12, 30, 0),
            Destination = "Cordoba"
        };

        // Act
        var cost = strategy.CalculateCost(call);

        // Assert
        Assert.Equal(7.5, cost); 
    }
}