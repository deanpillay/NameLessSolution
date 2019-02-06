using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoMvcApp.Models.ViewModels
{
    public class EventDisplayViewModel
    {  
        public long FK_TournamentID { get; set; }

        [Display(Name = "EventID")]
        public long EventID { get; set; }

        [Display(Name = "EventName")]
        public string EventName { get; set; }

        [Display(Name = "EventNumber")]
        public int EventNumber { get; set; }

        [Display(Name = "EventDateTime")]
        public DateTime EventDateTime { get; set; }

        [Display(Name = "EventEndDateTime")]
        public DateTime EventEndDateTime { get; set; }

        [Display(Name = "AutoClose")]
        public bool AutoClose { get; set; }
    }
}
