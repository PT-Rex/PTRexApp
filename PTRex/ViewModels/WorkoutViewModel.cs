using PTRex.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PTRex.ViewModels
{
    public class WorkoutViewModel
    {
        public int SelectedTargetWorkoutId { get; set; }

        public ActualWorkout ActualWorkout { get; set; }

        public TargetWorkout TargetWorkout { get; set; }
    }
}