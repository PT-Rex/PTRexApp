using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace PTRex.Models
{
    [MetadataType(typeof(ExercisBuddy))]
    public partial class Exercis
    {
    }

    sealed class ExercisBuddy
    {
        public int ID { get; set; }
        public string Name { get; set; }
        [Display(Name = "How To")]
        public string HowTo { get; set; }
        public string Equipment { get; set; }
        [Display(Name = "Video")]
        public string ResourceVideo { get; set; }
        [Display(Name = "Photo")]
        public string ResourcePhoto { get; set; }
        [Display(Name = "Additional information")]
        public string ResourceText { get; set; }
    }
}
