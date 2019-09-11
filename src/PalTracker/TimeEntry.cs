using System;

namespace PalTracker
{
    public struct TimeEntry
    {
        public long ProjectId {get; set;}
        public long UserId {get; set;}
        public DateTime Date {get; set;}
        public int Hours {get; set;}
        public long? Id {get; set;}

        public TimeEntry(long projectId , long userId, DateTime date, int hours)
        {
            this.Id = null;
            this.ProjectId = projectId;
            this.UserId = userId;
            this.Date = date;
            this.Hours = hours;
        }

        public TimeEntry(long id, long projectId , long userId, DateTime date, int hours)
        {
            this.Id = id;
            this.ProjectId = projectId;
            this.UserId = userId;
            this.Date = date;
            this.Hours = hours;
        }
    }
}