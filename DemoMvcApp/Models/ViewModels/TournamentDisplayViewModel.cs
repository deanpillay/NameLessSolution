﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoMvcApp.Models.ViewModels
{
    public class TournamentDisplayViewModel
    {
        [Display(Name = "TournamentID")]
        public long TournamentID { get; set; }

        [Display(Name = "TournamentName")]
        public string TournamentName { get; set; }
    }
}
