using System;

namespace PalTracker
{
    public struct TimeEntry
    {
        public long projectId {get; set;}
        public long userId {get; set;}
        public DateTime date {get; set;}
        public long hours {get; set;}
        public long? Id {get; set;}

        public TimeEntry(long a , long b, DateTime c, long d)
        {
            this.Id = null;
            this.projectId = a;
            this.userId = b;
            this.date = c;
            this.hours = d;
        }

        public TimeEntry(long index, long a , long b, DateTime c, long d)
        {
            this.Id = index;
            this.projectId = a;
            this.userId = b;
            this.date = c;
            this.hours = d;
        }
    }
}