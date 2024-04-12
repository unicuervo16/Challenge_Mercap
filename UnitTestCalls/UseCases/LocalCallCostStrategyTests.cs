using Challenge_Mercap_Llamadas;

public class LocalCallCostStrategyTests
{
    [Fact]
    public void CalculateCost_PeakHours_CostIsCorrect()
    {
        // Arrange
        var strategy = new LocalCallCostStrategy();
        var call = new LocalCall
        {
            Start = new DateTime(2024, 3, 11, 10, 30, 0),
            End = new DateTime(2024, 3, 11, 11, 0, 0)
        };


        // Act
        var cost = strategy.CalculateCost(call);

        // Assert
        Assert.Equal(6.0, cost);
    }
}
