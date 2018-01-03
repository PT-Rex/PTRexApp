    using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PTRex.Models
{
    public class ActualWorkoutMetadata
    {
        [Display(Name = "Sets")]
        public int ActualNumSets { get; set; }

        [Display(Name ="Reps")]
        public int ActualNumReps { get; set; }

        [Display(Name ="Workout Date")]
        public System.DateTime Date { get; set; }

        
        public int TimeOfDayID { get; set; }

        [Display(Name = "Weight Used")]
        public string WeightUsed { get; set; }

        
        public int PainLevelID { get; set; }

        [Display(Name = "Notes")]
        public string ActualNotes { get; set; }

        [Display(Name ="Pain Level")]
        public virtual PainLevel PainLevel { get; set; }

        [Display(Name ="Target Notes")]
        public virtual TargetWorkout TargetWorkout { get; set; }

        [Display(Name ="Time of Day")]
        public virtual TimeOfDay TimeOfDay { get; set; }

    }
}