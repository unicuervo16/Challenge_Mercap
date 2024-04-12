using Challenge_Mercap_Llamadas;

public class CallApp
{
    public static double UserMonthlyFee = 50; 
    public static double UserCostForMonth = 50;

    public static List<Call> InitializeCalls()
    {
        List<Call> calls = new List<Call>
        {
            new LocalCall { Start = DateTime.Now, End = DateTime.Now.AddMinutes(10) },
            new LocalCall { Start = DateTime.Now, End = DateTime.Now.AddMinutes(25) },
        };

        return calls;
    }
}
