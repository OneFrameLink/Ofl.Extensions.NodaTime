using System;
using NodaTime;

namespace Ofl.Extensions.NodaTime
{
    public static class DateTimeOffsetExtensions
    {
        public static DateTimeOffset ReplaceOffsetFromDateTimeZoneLeniently(this DateTimeOffset dateTimeOffset, DateTimeZone dateTimeZone) =>
            dateTimeOffset.DateTime.ApplyDateTimeZoneLeniently(dateTimeZone);

        public static DateTimeOffset ReplaceOffsetFromDateTimeZoneStrictly(this DateTimeOffset dateTimeOffset, DateTimeZone dateTimeZone) =>
            dateTimeOffset.DateTime.ApplyDateTimeZoneStrictly(dateTimeZone);
    }
}
