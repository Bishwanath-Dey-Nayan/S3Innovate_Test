using System;

namespace Mobile_Billing
{
    class Program
    {
        public static DateTime PEAK_HOUR_START = Convert.ToDateTime("9.00.00 am");
        public static DateTime PEAK_HOUR_END = Convert.ToDateTime("10.59.59 pm");
        public static string OFF_PEAK_HOUR_START_1 = "12.00.00 am";
        public static string OFF_PEAK_HOUR_END_1 = " 8.59.59 am";
        public static string OFF_PEAK_HOUR_START_2 = " 11.00.00 pm";
        public static string OFF_PEAK_HOUR_END_2 = "11.59.59 pm";
        public static double CalculateBill(DateTime starttime, DateTime endtime)
        {
            double bill = 0;
            int j = 0;
            DateTime peakhourstrart = Convert.ToDateTime(PEAK_HOUR_START);
            for (int i=0; ;i++)
            {
                if(i != 0)
                {
                    starttime = starttime.AddSeconds(1);
                }
                starttime = starttime.AddSeconds(20);

                    if((PEAK_HOUR_START.TimeOfDay<starttime.TimeOfDay && starttime.TimeOfDay < PEAK_HOUR_END.TimeOfDay))
                    {
                        bill += 30;
                    if(starttime>endtime)
                    {
                        break;
                    }
                    }
                    else
                    {
                        bill += 20;
                    if (starttime > endtime)
                    {
                        break;
                    }
                }
                
            }
            return bill;
        }
        static void Main(string[] args)
        {
            double TotalBill = 0;
            Console.WriteLine("Enter the Start Time:");
            DateTime StartTime = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter the End Time:");
            DateTime EndTime = DateTime.Parse(Console.ReadLine());
            TotalBill = CalculateBill(StartTime, EndTime);

            double taka = TotalBill / 100;
            Console.WriteLine(taka + " taka");
            Console.ReadKey();
        }
    }
}
