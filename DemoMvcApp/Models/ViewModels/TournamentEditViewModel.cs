using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoMvcApp.Models.ViewModels
{
    public class TournamentEditViewModel
    {
        [Display(Name = "TournamentID")]
        public long TournamentID { get; set; }

        [Display(Name = "TournamentName")]
        [Required(ErrorMessage = "Tournament Name is required"), StringLength(200, ErrorMessage = "TournamentName cannot be longer than 200 characters.")]
        public string TournamentName { get; set; }
    }
}
