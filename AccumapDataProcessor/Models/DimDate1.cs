using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class DimDate1
    {
        public int DateKey { get; set; }
        public DateTime? FullDate { get; set; }
        public byte? DayOfMonth { get; set; }
        public string? DayOfMonthDd { get; set; }
        public string? DayOfMonthWithSuffix { get; set; }
        public string? DayOfWeekName { get; set; }
        public string? DayOfWeekNameShort { get; set; }
        public int? DayOfWeekNumber { get; set; }
        public byte? DayOfWeekInMonth { get; set; }
        public int? DayOfYearNumber { get; set; }
        public byte? WeekOfYearNumber { get; set; }
        public string? WeekOfYearNumberDd { get; set; }
        public byte? WeekOfMonthNumber { get; set; }
        public DateTime? WeekStartDateFull { get; set; }
        public string? WeekStartDateDdMonYyyy { get; set; }
        public byte? CalendarMonthNumber { get; set; }
        public string? CalendarMonthName { get; set; }
        public string? CalendarMonthNameShort { get; set; }
        public string? WeekDayFlag { get; set; }
        public string? FirstDayOfCalendarMonthFlag { get; set; }
        public string? LastDayOfCalendarMonthFlag { get; set; }
        public byte? CalendarQuarterNumber { get; set; }
        public string? CalendarQuarterName { get; set; }
        public string? CalendarQuarterNameShort { get; set; }
        public int? CalendarYearNumber { get; set; }
        public string? CalendarYearName { get; set; }
        public int? DaysSince20000101 { get; set; }
        public int? WeeksSince20000101 { get; set; }
        public int? MonthsSince20000101 { get; set; }
        public int? QuartersSince20000101 { get; set; }
        public int? YearsSince20000101 { get; set; }
        public string? HolidayFlag { get; set; }
        public string? HolidayDescription { get; set; }
    }
}
