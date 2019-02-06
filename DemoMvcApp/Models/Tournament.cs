using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoMvcApp.Models
{
    public class Tournament
    {
        public Tournament()
        {
            Events = new HashSet<Event>();
        }
        public long TournamentID { get; set; }
        
        public string TournamentName { get; set; }

        public virtual ICollection<Event> Events { get; set; }
        
        
    }
}
