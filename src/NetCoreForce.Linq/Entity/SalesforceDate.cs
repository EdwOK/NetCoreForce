using System;

namespace NetCoreForce.Linq.Entity
{
    public struct SalesforceDate
    {
        public SalesforceDate(DateTime time)
        {
            this.Year = time.Year;
            this.Month = time.Month;
            this.Day = time.Day;
        }

        public SalesforceDate(int year, int month, int day)
        {
            this.Year = year;
            this.Month = month;
            this.Day = day;
        }

        public int Year { get; }

        public int Month { get; }

        public int Day { get; }

        public static SalesforceDate Now => new SalesforceDate(DateTime.Now);

        public static bool operator ==(DateTime? d1, SalesforceDate d2)
        {
            return false;
        }

        public static bool operator !=(DateTime? d1, SalesforceDate d2)
        {
            return false;
        }

        public static bool operator >=(DateTime? d1, SalesforceDate d2)
        {
            return false;
        }

        public static bool operator <=(DateTime? d1, SalesforceDate d2)
        {
            return false;
        }
        public static bool operator >(DateTime d1, SalesforceDate d2)
        {
            return false;
        }

        public static bool operator <(DateTime d1, SalesforceDate d2)
        {
            return false;
        }
        public static bool operator ==(DateTime d1, SalesforceDate d2)
        {
            return false;
        }
        public static bool operator !=(DateTime d1, SalesforceDate d2)
        {
            return false;
        }
        public static bool operator >=(DateTime d1, SalesforceDate d2)
        {
            return false;
        }

        public static bool operator <=(DateTime d1, SalesforceDate d2)
        {
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override string ToString()
        {
            return $"{Year}-{Month.ToString().PadLeft(2, '0')}-{Day.ToString().PadLeft(2, '0')}";
        }

        public DateTime ToDateTime()
        {
            return new DateTime(Year, Month, Day);
        }
    }
}
