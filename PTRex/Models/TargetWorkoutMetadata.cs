using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PTRex.Models
{
    public class TargetWorkoutMetadata
    {
        //keys
        public int ID { get; set; }       
        public int ExerciseID { get; set; }
        public int UserProfileID { get; set; }
       
        //table columns
        [Display(Name ="# Sets")]
        [Range(1,3)]
        [Required(ErrorMessage = "Number of sets must be between {0} and {1}.")]
        public int TargetNumSets { get; set; }

        [Display(Name = "# Reps")]
        [Range(1, 20)]
        [Required(ErrorMessage = "Number of reps must be between {0} and {1}.")]
        public int TargetNumReps { get; set; }

        [Display(Name = "# Sessions")]
        [Range(1, 1)]
        [Required(ErrorMessage = "Only 1 Session is allowed at this time.")]
        public int TargetSessionsPerDay { get; set; }

        [Display(Name = "Notes")]       
        [Required(ErrorMessage = "{0} is required")]
        public string TargetNotes { get; set; }
        public string ExerciseNickName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActualWorkout> ActualWorkouts { get; set; }
        public virtual Exercis Exercis { get; set; }
        public virtual UserProfile UserProfile { get; set; }
    }

}