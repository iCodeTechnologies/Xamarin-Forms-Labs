using System;

namespace XLabs.Forms.Controls.Calendar.MonoDroid.TimesSquare
{
    public class MonthDescriptor
    {
        public int Month { get; private set; }

        public int Year { get; private set; }

        public DateTime Date { get; private set; }

        public string Label { get; private set; }

        public StyleDescriptor Style { get; private set; }

        public MonthDescriptor(int month, int year, DateTime date, string label, StyleDescriptor style)
        {
            Month = month;
            Year = year;
            Date = date;
            Label = label;
            Style = style;
        }

        public override string ToString()
        {
            return "MonthDescriptor{"
            + "label=" + Label + ""
            + ", month=" + Month
            + ", year=" + Year
            + "}";
        }
    }
}