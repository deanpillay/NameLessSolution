using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Event
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long EventID { get; set; }
        [StringLength(100, ErrorMessage = "EventName cannot be longer than 100 characters.")]
        public string EventName { get; set; }
        public int EventNumber { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd hh:mm:fffffff}", ApplyFormatInEditMode = true)]
        public DateTime EventDateTime { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd hh:mm:fffffff}", ApplyFormatInEditMode = true)]
        public DateTime EventEndDateTime { get; set; }
        public bool AutoClose { get; set; }
                
        [ForeignKey("Tournament")]
        public long FK_TournamentID { get; set; }
        public Tournament Tournament { get; set; }

        public ICollection<EventDetail> EventDetails { get; set; }
    }
}
