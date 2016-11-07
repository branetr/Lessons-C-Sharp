using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MyDay
    {
        public TimeSpan MyNextBirthdey(DateTime mybirth)
        {
            DateTime now = DateTime.Now;
            DateTime addd = new DateTime(now.Year, mybirth.Month, mybirth.Day);
            TimeSpan dayToBirth;
            if (addd < now)
            {
                addd = new DateTime(now.Year + 1, mybirth.Month, mybirth.Day);
                dayToBirth = addd - now;
            }
            else
            {
                dayToBirth = addd - now;
            }

            return dayToBirth;
        }
    }
}
