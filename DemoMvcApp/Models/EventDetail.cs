using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoMvcApp.Models
{
    public class EventDetail
    {
        public virtual long EventDetailID { get; set; }

        public virtual long FK_EventID { get; set; }

        public virtual int FK_EventDetailStatusID { get; set; }

        [StringLength(50, ErrorMessage = "EventDetailName cannot be longer than 50 characters.")]
        public string EventDetailName { get; set; }

        public int EventDetailNumber { get; set; }

        public decimal EventDetailOdd { get; set; }

        public int FinishingPosition { get; set; }

        public bool FirstTimer { get; set; }

        
        public virtual Event Event { get; set; }
        
        public virtual EventDetailStatus EventDetailStatus { get; set; }


    }
}
