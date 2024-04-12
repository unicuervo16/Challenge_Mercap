namespace Challenge_Mercap_Llamadas
{
    public class LocalCallCostStrategy : ICostCalculationStrategy
    {
        public double CalculateCost(Call call)
        {
            DayOfWeek dayOfWeek = call.Start.DayOfWeek;
            bool isWeekend = dayOfWeek == DayOfWeek.Saturday || dayOfWeek == DayOfWeek.Sunday;
            double ratePerMinute = isWeekend ? 0.10 : 0.20; // Asumiendo que la tarifa en fin de semana es $0.10
            if (!isWeekend)
            {
                TimeSpan startOfDayPeak = new TimeSpan(8, 0, 0); // 8:00 AM
                TimeSpan endOfDayPeak = new TimeSpan(20, 0, 0); // 8:00 PM
                if (call.Start.TimeOfDay < startOfDayPeak || call.Start.TimeOfDay >= endOfDayPeak)
                {
                    ratePerMinute = 0.10; // Asumiendo que fuera de horas pico la tarifa es $0.10
                }
            }
            double totalMinutes = (call.End - call.Start).TotalMinutes;
            return ratePerMinute * totalMinutes;
        }

        private bool IsPeakHours(TimeSpan time)
        {
            return time >= TimeSpan.FromHours(8) && time < TimeSpan.FromHours(20);
        }
    }
}
