using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trener
{
    public class FinishedWorkout
    {
        public string workoutName { get; set; }
        public DateTime dateTime { get; set; }

        public bool IsOwn {get; set;}

        public FinishedWorkout(string workoutName, DateTime dateTime)
        {
            this.workoutName = workoutName;
            this.dateTime = dateTime;

        }
        public FinishedWorkout(string workoutName, DateTime dateTime, bool IsOwn)
        {
            this.workoutName = workoutName;
            this.dateTime = dateTime;
            this.IsOwn = IsOwn;

        }
        public FinishedWorkout()
        {

        }

    }
}
