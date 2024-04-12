namespace Challenge_Mercap_Llamadas
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BillingProcessor
    {
        public void CalculateBill(List<Call> calls)
        {
            var groupedCalls = calls.GroupBy(call => new { call.Start.Year, call.Start.Month });

            foreach (var group in groupedCalls)
            {
                double totalMonthlyCost = CallApp.UserMonthlyFee;
                double totalLocalCost = 0.0;
                double totalNationalOrInternationalCost = 0.0;

                foreach (Call call in group)
                {
                    double totalCallCost = call.CalculateCost();
                    totalMonthlyCost += totalCallCost;

                    if (call is LocalCall)
                    {
                        totalLocalCost += totalCallCost;
                    }
                    else
                    {
                        totalNationalOrInternationalCost += totalCallCost;
                    }
                }

                Console.WriteLine($"\nBilling for the Month: {group.Key.Year}-{group.Key.Month}");
                PrintCallDetails(group.ToList());
                PrintBillSummary(totalLocalCost, totalNationalOrInternationalCost, totalMonthlyCost);
            }
        }

        private void PrintCallDetails(List<Call> calls)
        {
            Console.WriteLine("Call Details:");
            Console.WriteLine("--------------------------------------------------");
            foreach (Call call in calls)
            {
                TimeSpan duration = call.End - call.Start;
                string callType = call is LocalCall ? "Local" : "National/International";
                string formattedDate = call.Start.ToString("d");
                Console.WriteLine($"Date: {formattedDate} | Duration: {duration.TotalMinutes:N0} min | Type: {callType} | Cost: {call.Cost:C2}");
            }
            Console.WriteLine("--------------------------------------------------");
        }

        private void PrintBillSummary(double totalLocalCost, double totalNationalOrInternationalCost, double totalMonthlyCost)
        {
            Console.WriteLine("Bill Summary:");
            Console.WriteLine(new string('=', 55));
            Console.WriteLine($"Basic Monthly Fee:                {CallApp.UserMonthlyFee,15:C2}");
            Console.WriteLine($"Total Local Calls:             {totalLocalCost,17:C2}");
            Console.WriteLine($"Total National/International Calls:    {totalNationalOrInternationalCost,5:C2}");
            Console.WriteLine(new string('-', 55));
            Console.WriteLine($"Total Amount Due:                     {totalMonthlyCost,18:C2}");
            Console.WriteLine(new string('=', 55));
        }
    }
}
