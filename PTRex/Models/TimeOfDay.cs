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
    
    public partial class TimeOfDay
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TimeOfDay()
        {
            this.ActualWorkouts = new HashSet<ActualWorkout>();
        }
    
        public int ID { get; set; }
        public string TimeOfDay1 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActualWorkout> ActualWorkouts { get; set; }
    }
}
