﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NW.Utility
{
    public static class TimeHelper
    {
        public static string ToTimeTip(DateTime time)
        {
            var span = DateTime.Now - time;
            if (Math.Abs(span.TotalDays) > 365)
            {
                if (span.TotalDays > 0)
                    return "很久以前";
                else
                    return "很久以后";
            }
            var sec = (long)span.TotalSeconds;
            if (sec == 0)
            {
                return "刚刚";
            }
            else if (Math.Abs(sec) < 60)
            {
                if (sec > 0)
                    return sec + "秒前";
                else
                    return -sec + "秒后";
            }
            else if (Math.Abs(sec) < 60 * 60)
            {
                if (sec > 0)
                    return sec / 60 + "分钟前";
                else
                    return -sec / 60 + "分钟后";
            }
            else if (Math.Abs(sec) < 60 * 60 * 24)
            {
                if (sec > 0)
                    return sec / 60 / 60 + "小时前";
                else
                    return -sec / 60 / 60 + "小时后";
            }
            else if (Math.Abs(sec) < 60 * 60 * 24 * 30)
            {
                if (sec > 0)
                    return sec / 60 / 60 / 24 + "天前";
                else
                    return -sec / 60 / 60 / 24 + "天后";
            }
            return time.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public static string ToVagueTimeLength(DateTime time1, DateTime time2)
        {
            var sec = (int)Math.Abs((time2 - time1).TotalSeconds);
            if (sec < 60)
            {
                return sec + "秒";
            }
            else if (sec < 60 * 60)
            {
                return sec / 60 + "分";
            }
            else if (sec < 60 * 60 * 24)
            {
                return sec / 60 / 60 + "小时";
            }
            else
            {
                return sec / 60 / 60 / 24 + "天";
            }
        }

        public static string ToTimeLength(DateTime time1, DateTime time2)
        {
            var sec = (int)Math.Abs((time2 - time1).TotalSeconds);
            var ret = "";
            if (sec / 60 / 60 / 24 > 0)
            {
                ret += sec / 60 / 60 / 24 + "天";
            }
            if (sec / 60 / 60 % 24 > 0)
            {
                ret += sec / 60 / 60 % 24 + "小时";
            }
            if (sec / 60 % 60 > 0)
            {
                ret += sec / 60 % 60 + "分钟";
            }
            if (sec % 60 > 0)
            {
                ret += sec % 60 + "秒";
            }
            return ret;
        }

        public static DateTime ToDateTime(string TimeStamp)
        {
            DateTime dtStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            long lTime = long.Parse(TimeStamp + "0000000");
            TimeSpan toNow = new TimeSpan(lTime); return dtStart.Add(toNow);
        }

        public static DateTime ToDateTime(int TimeStamp)
        {
            return ToDateTime(TimeStamp.ToString());
        }

        public static int ToTimeStamp(System.DateTime Time)
        {
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
            return (int)(Time - startTime).TotalSeconds;
        }
    }
}
