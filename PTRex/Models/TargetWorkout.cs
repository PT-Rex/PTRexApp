//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PTRex.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TargetWorkout
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TargetWorkout()
        {
            this.ActualWorkouts = new HashSet<ActualWorkout>();
        }
    
        public int ID { get; set; }
        public int ExerciseID { get; set; }
        public int UserProfileID { get; set; }
        public int TargetNumSets { get; set; }
        public int TargetNumReps { get; set; }
        public int TargetSessionsPerDay { get; set; }
        public string TargetNotes { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActualWorkout> ActualWorkouts { get; set; }
        public virtual Exercis Exercis { get; set; }
        public virtual UserProfile UserProfile { get; set; }
    }
}
