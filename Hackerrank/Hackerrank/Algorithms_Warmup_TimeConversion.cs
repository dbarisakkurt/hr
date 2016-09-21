using System;

namespace Hackerrank
{
    //Hackerrank
    //Algorithms / Warmup / Time Conversion Question
    static class Algorithms_Warmup_TimeConversion
    {
        public static string TimeConversion(string time)
        {
            string suffix = time.Substring(time.Length - 2);
            int hour = Convert.ToInt32(time.Substring(0, 2));
            string strHour = "";

            if (suffix == "PM")
            {
                hour += 12;

                if (hour > 24)
                {
                    hour = hour % 12;
                    if (hour < 10)
                        strHour = "0" + hour.ToString();
                    else
                        strHour = hour.ToString();
                }
                else if (hour == 24)
                {
                    strHour = "12";
                }
                else
                {
                    if (hour < 10)
                        strHour = "0" + hour.ToString();
                    else
                        strHour = hour.ToString();
                }
                string text = strHour + time.Substring(2, time.Length - 4);
                return text;
            }
            else
            {
                if (hour >= 12)
                {
                    hour = hour % 12;

                    if (hour < 10)
                        strHour = "0" + hour.ToString();
                    else
                        strHour = hour.ToString();
                }
                else
                {
                    if (hour < 10)
                        strHour = "0" + hour.ToString();
                    else
                        strHour = hour.ToString();
                }


                return strHour;
            }
        }
    }
}
