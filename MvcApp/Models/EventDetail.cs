using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcApp.Models
{
    public class EventDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long EventDetailID { get; set; }
        [StringLength(50, ErrorMessage = "EventDetailName cannot be longer than 50 characters.")]
        public string EventDetailName { get; set; }
        public int EventDetailNumber { get; set; }
        public decimal EventDetailOdd { get; set; }
        public int FinishingPosition { get; set; }
        public bool FirstTimer { get; set; }


        [ForeignKey("Event")]
        public long FK_EventID { get; set; }
        public Event Event { get; set; }

        [ForeignKey("EventDetailStatus")]
        public int FK_EventDetailStatusID { get; set; }
        public EventDetailStatus EventDetailStatus { get; set; }


    }
}
