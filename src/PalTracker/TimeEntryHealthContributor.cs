using System.Linq;
using Steeltoe.Common.HealthChecks;

namespace PalTracker
{
    public class TimeEntryHealthContributor : IHealthContributor
    {
        public string Id {get;} = "timeEntry";
        public const int MaxTimeEntries = 5;
         private readonly ITimeEntryRepository _timeEntryRepository;

public TimeEntryHealthContributor(ITimeEntryRepository timeEntryRepository)
{
    _timeEntryRepository = timeEntryRepository;
}

        public HealthCheckResult Health()
        {
           var dbRecordCount =_timeEntryRepository.List().Count();
          HealthStatus status = dbRecordCount < MaxTimeEntries ? HealthStatus.UP :HealthStatus.DOWN;
           
            var health =  new HealthCheckResult();
            health.Status = status;
            health.Details.Add("count",dbRecordCount);
            health.Details.Add("threshold",MaxTimeEntries);
            health.Details.Add("status",status.ToString());

            return health;
                        
           
        }
    }
}