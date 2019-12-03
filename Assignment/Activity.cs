using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Activity: IComparable
    {
        //Properties

        public string Name { get; set; }

        public DateTime Date { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }

        public string TypeOfActivity { get; set; }

        public int CompareTo(object obj)
        {
            Activity that = (Activity)obj;
            return Date.CompareTo(that.Date);
        }

        //public ActivityType TypeofActivity { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Date.ToShortDateString()}";
        }



        enum ActivityType
        {
            Air,
            Water,
            Land
        }

    }
}
