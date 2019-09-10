using Microsoft.AspNetCore.Mvc;

namespace PalTracker
{
    [Route("/time-entries")]
    public class TimeEntryController : ControllerBase
    {
        private readonly ITimeEntryRepository _timeEntryRepository;
        public TimeEntryController(ITimeEntryRepository timeEntryRepository)
        {
            _timeEntryRepository = timeEntryRepository;
        }
        
        [HttpGet("{id}", Name = "GetTimeEntry")]
        public IActionResult Read(long id)
        {
            if(_timeEntryRepository.Contains(id))
                return (IActionResult) Ok(_timeEntryRepository.Find(id));
            
            return NotFound();
        }

        [HttpPost]
        public IActionResult Create([FromBody]TimeEntry timeEntry)
        {
            TimeEntry created = _timeEntryRepository.Create(timeEntry);
            return  new CreatedAtRouteResult("GetTimeEntry", new {id = created.Id}, created);
        }
        
        [HttpGet]
        public IActionResult List()
        {
            var timeEntries = _timeEntryRepository.List();
            return Ok(timeEntries);
        }

        [HttpPut("{id}")]
        public IActionResult Update(long id, [FromBody] TimeEntry timeEntry)
        {
            if(_timeEntryRepository.Contains(id))
                return Ok(_timeEntryRepository.Update(id, timeEntry));

            return NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            if(_timeEntryRepository.Contains(id))
            {
                _timeEntryRepository.Delete(id);
                return new NoContentResult();
            }

            return NotFound();
        }
    }
}