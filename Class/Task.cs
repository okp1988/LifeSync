using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeSync_App
{
    public class TaskInfo
    {
        public int Index { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }
        public string Task { get; set; }
        public int Interval { get; set; }
        public string IntervalType { get; set; }
        public DateTime Date { get; set; }
        public string Time { get; set; }
        public string Remark { get; set; }
        public bool KeepHistory { get; set; }
        public bool IgnoreAlert { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int IntervalWeight()
        {
            int weight = 1;

            if (IntervalType == "Year")
            {
                weight = 365;
            }
            else if (IntervalType == "Month")
            {
                weight = 30;
            }

            return (Interval * weight);
        }
        public double DateDiff()
        {
            return (DueDate().Date - DateTime.Now.Date).TotalDays;
        }
        public DateTime DueDate()
        {
            if (IntervalType.ToUpper() == "DAY")
            {
                return Date.AddDays(Interval);
            }
            else if (IntervalType.ToUpper() == "MONTH")
            {
                return Date.AddMonths(Interval);
            }
            else if (IntervalType.ToUpper() == "YEAR")
            {
                return Date.AddYears(Interval);
            }
            else
            {
                return DateTime.MinValue;
            }
        }
        public string Status()
        {
            if (DateDiff() < 0)
            {
                return "EXPIRED";
            }
            else if (DateDiff() == 0)
            {
                return "TODAY";
            }
            else if (DateDiff() <= Form1.dayDiff)
            {
                return "SOON";
            }
            else
            {
                return "PENDING";
            }
        }
    }
}
