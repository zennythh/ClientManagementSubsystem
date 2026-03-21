using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagementSubsystem.classes
{
    public static class TimeHelper
    {
        public static string ToTimeAgo(this DateTime dateTime)
        {
            TimeSpan timeSpan = DateTime.Now - dateTime;

            if (timeSpan.TotalSeconds < 0) return "In the future";

            if (timeSpan.TotalMinutes < 1) return "Just now";
            if (timeSpan.TotalMinutes < 2) return "A minute ago";
            if (timeSpan.TotalMinutes < 60) return $"{(int)timeSpan.TotalMinutes} minutes ago";

            if (timeSpan.TotalHours < 2) return "An hour ago";
            if (timeSpan.TotalHours < 24) return $"{(int)timeSpan.TotalHours} hours ago";

            if (timeSpan.TotalDays < 2) return "Yesterday";
            if (timeSpan.TotalDays < 7) return $"{(int)timeSpan.TotalDays} days ago";

            return dateTime.ToString("MMM dd, yyyy");
        }
    }
}
