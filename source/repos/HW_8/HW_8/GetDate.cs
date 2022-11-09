using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_8
{
    internal class GetDate
    {
        DateTime date;
        DateTime userData;
        DateTime defaultDate;

        bool isLeapYear;
        int i = 0;
        private DateTime tmp;

        public int I
        {
            get { return i; }
            set { i = value; }
        }

        public GetDate(DateTime defaultDate,DateTime userDate)
        {
            this.defaultDate = defaultDate; 
            this.userData = userDate;
            isLeapYear = (userData.Year % 4 == 0) ? true : false;   
        }

        public GetDate(DateTime tmp)
        {
            this.tmp = tmp;
        }

        public DateTime DefaultDate
        {
            get { return defaultDate; } 
        }
        public DateTime UserDate
        {
            get { return userData; }
            set { userData = value; }
        }
        public DateTime this[int i]
        {
            get { return UserDate + TimeSpan.FromDays(i); }
        }
        public override string ToString()
        {
            return UserDate.ToString();
        }
        public string ToString ( bool dateOnly)
        {
            return Convert.ToString(DateOnly.FromDateTime(UserDate));
        }
        public DateTime ToDaysDay()
        {
            date = DateTime.Now;
            return date;
        } 
        public DateTime NextDay()
        {
            return UserDate.AddDays(+1);
        }
        public DateTime PreviousDay()
        {
            return UserDate.AddDays(-1);
        }
        public int DaysLeftInMoth()
        {
            date = UserDate;
            return DateTime.DaysInMonth(date.Year, date.Month) - date.Day;
        }
        public void ShowDate()
        {
            Console.WriteLine("\nDefault date is : " + defaultDate);
            Console.WriteLine("\nUser date is : " + UserDate);
            Console.WriteLine("\nNext day is : " + NextDay());
            Console.WriteLine("\nPrevious day is : " + PreviousDay());
            Console.WriteLine("\nIs it Leap Year? : " + isLeapYear);
            Console.WriteLine("\nDays left in moth: " + DaysLeftInMoth());
            Console.WriteLine("\nTodays is : " + ToDaysDay());
        }
    }
}
