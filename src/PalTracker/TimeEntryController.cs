using Microsoft.AspNetCore.Mvc;

namespace PalTracker
{
    [Route("/time-entries")]
    public class TimeEntryController : ControllerBase
    {
        private readonly ITimeEntryRepository _timeEntryRepository;
        private readonly IOperationCounter<TimeEntry> _operationCounter;
        public TimeEntryController(ITimeEntryRepository timeEntryRepository,IOperationCounter<TimeEntry> operationCounter)
        {
            _timeEntryRepository = timeEntryRepository;
            _operationCounter = operationCounter;
        }
        
        [HttpGet("{id}", Name = "GetTimeEntry")]
        public IActionResult Read(long id)
        {
            _operationCounter.Increment(TrackedOperation.Read);
            if(_timeEntryRepository.Contains(id))
                return (IActionResult) Ok(_timeEntryRepository.Find(id));
              
            return NotFound();
          
        }

        [HttpPost]
        public IActionResult Create([FromBody]TimeEntry timeEntry)
        {

            TimeEntry created = _timeEntryRepository.Create(timeEntry);
            _operationCounter.Increment(TrackedOperation.Create);
            return  new CreatedAtRouteResult("GetTimeEntry", new {id = created.Id}, created);
        }
        
        [HttpGet]
        public IActionResult List()
        {
            var timeEntries = _timeEntryRepository.List();
            _operationCounter.Increment(TrackedOperation.List);
            return Ok(timeEntries);
        }

        [HttpPut("{id}")]
        public IActionResult Update(long id, [FromBody] TimeEntry timeEntry)
        {
            _operationCounter.Increment(TrackedOperation.Update);
            if(_timeEntryRepository.Contains(id))
                return Ok(_timeEntryRepository.Update(id, timeEntry));

            return NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _operationCounter.Increment(TrackedOperation.Delete);
            if(_timeEntryRepository.Contains(id))
            {
                _timeEntryRepository.Delete(id);
                return new NoContentResult();
            }

            return NotFound();
        }
    }
}