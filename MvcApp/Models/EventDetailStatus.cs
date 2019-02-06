using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcApp.Models
{
    public class EventDetailStatus
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EventDetailStatusID { get; set; }
        [StringLength(50, ErrorMessage = "EventDetailStatusName cannot be longer than 50 characters.")]
        public string EventDetailStatusName { get; set; }
    }
}
