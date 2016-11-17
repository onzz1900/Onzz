using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onzz.Extensions
{
    public static class DateTimeExtensions
    {
        /// <summary>
        /// 时间戳：当前距离Epoch（1970年1月1日) 以秒计算的时间
        /// </summary>
        /// <param name="datetime"></param>
        /// <param name="length">默认10位</param>
        /// <returns></returns>
        public static string ToUnixTimestamp(this DateTime datetime, int length = 10)
        {
            DateTime dtStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            TimeSpan toNow = datetime.Subtract(dtStart);
            string timeStamp = toNow.Ticks.ToString().Substring(0, length);
            return timeStamp;
        }
    }
}
