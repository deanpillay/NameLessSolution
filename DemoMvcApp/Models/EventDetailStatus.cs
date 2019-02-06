using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoMvcApp.Models
{
    public class EventDetailStatus
    {
        public int EventDetailStatusID { get; set; }

        public string EventDetailStatusName { get; set; }
    }
}
