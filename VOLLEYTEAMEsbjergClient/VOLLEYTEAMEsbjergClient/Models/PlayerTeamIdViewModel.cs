using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VOLLEYTEAMEsbjergClient.Models
{
    public class PlayerTeamIdViewModel
    {
        [Display(Name = "Team Id")]
        public int SelectedTeamId { get; set; }
       // public IEnumerable<SelectListItem> TeamName { get; set; }
    }
}