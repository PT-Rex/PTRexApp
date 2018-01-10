using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PTRex.Models
{
    public class TargetWorkoutMetadata
    {
        //table columns
        [Display(Name = "# Sessions")]
        [Range(0, 1)]
        [Required(ErrorMessage = "Only 1 Session is allowed at this time.")]
        public int TargetSessionsPerDay { get; set; }

        [Display(Name = "# Sets")]
        [Range(1, 3)]
        [Required(ErrorMessage = "Whoa! Number of sets must be between 1 and 3.")]
        public int TargetNumSets { get; set; }

        [Display(Name = "# Reps")]
        [Range(1, 20)]
        [Required(ErrorMessage = "Number of reps must be between 1 and 20.")]
        public int TargetNumReps { get; set; }
               

        [Display(Name = "Notes")]       
        [Required(ErrorMessage = "{0} is required")]
        public string TargetNotes { get; set; }
    }

}