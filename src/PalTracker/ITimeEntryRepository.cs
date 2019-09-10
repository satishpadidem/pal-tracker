using System.Collections.Generic;

namespace PalTracker
{
    public interface ITimeEntryRepository
    {
        TimeEntry Create(TimeEntry timeEntry);
        TimeEntry Find(long index);
        bool Contains(long index);
        List<TimeEntry> List();
        TimeEntry Update(long index, TimeEntry timeEntry);
        bool Delete(long index);
    }
}