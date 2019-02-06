using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Tournament
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long TournamentID { get; set; }
        [StringLength(200, ErrorMessage = "TournamentName cannot be longer than 200 characters.")]
        public string TournamentName { get; set; }

        public ICollection<Event> Events { get; set; }

    }
}
