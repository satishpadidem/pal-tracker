namespace PalTracker
{
    public static class MappingExtensions
    {
        public static TimeEntry ToEntity(this TimeEntryRecord record) => new TimeEntry
        {
            Id = record.Id,
            ProjectId = record.projectId,
            UserId = record.userId,
            Date = record.date,
            Hours = record.hours
        };

        public static TimeEntryRecord ToRecord(this TimeEntry entity) => new TimeEntryRecord
        {
            Id = entity.Id,
            projectId = entity.ProjectId,
            userId = entity.UserId,
            date = entity.Date,
            hours = entity.Hours
        };
    }
}