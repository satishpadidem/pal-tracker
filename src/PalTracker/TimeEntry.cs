using System;

namespace PalTracker
{
    public struct TimeEntry
    {
        public long ProjectId {get; set;}
        public long UserId {get; set;}
        public DateTime Date {get; set;}
        public long Hours {get; set;}
        public long? Id {get; set;}

        public TimeEntry(long a , long b, DateTime c, long d)
        {
            this.Id = null;
            this.ProjectId = a;
            this.UserId = b;
            this.Date = c;
            this.Hours = d;
        }

        public TimeEntry(long index, long a , long b, DateTime c, long d)
        {
            this.Id = index;
            this.ProjectId = a;
            this.UserId = b;
            this.Date = c;
            this.Hours = d;
        }
    }
}