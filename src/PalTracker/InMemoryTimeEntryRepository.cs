using System.Collections.Generic;
using System.Linq;

namespace PalTracker
{
    public class InMemoryTimeEntryRepository : ITimeEntryRepository
    {
        private Dictionary<long, TimeEntry> timeEntries = new Dictionary<long, TimeEntry>();

        public InMemoryTimeEntryRepository()
        {
            
        }

        public bool Contains(long index)
        {
            return timeEntries.ContainsKey(index);
        }

        public TimeEntry Create(TimeEntry timeEntry)
        {
            //timeEntries = timeEntries ?? new Dictionary<int, TimeEntry>();
            int insertionIndex = timeEntries.Count+1;
            timeEntry.Id = insertionIndex;
            
            timeEntries.Add(insertionIndex, timeEntry);

            return timeEntry;
        }

        public bool Delete(long index)
        {
            return timeEntries.Remove(index);
        }

        public TimeEntry Find(long index)
        {
            return timeEntries[index];
        }

        public List<TimeEntry> List()
        {
            return timeEntries.Values.ToList();
        }

        public TimeEntry Update(long index, TimeEntry timeEntry)
        {
            timeEntry.Id = index;
            timeEntries[index] = timeEntry;
            return timeEntry;
        }
    }
}