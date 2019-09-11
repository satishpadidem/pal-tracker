using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PalTracker
{
    [Table("time_entries")]
    public class TimeEntryRecord
    {
        [Column("id")]
        public long? Id {get; set;}
        [Column("project_id")]
        public long projectId { get; set; }
        [Column("date")]
        public DateTime date { get; set; }
        [Column("user_id")]
        public long userId {get; set;}
        [Column("hours")]
        public int hours { get; set; }

        public TimeEntryRecord(){
            
        }
    }
}