using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularAPI.Models
{
    public class Workout
    {
        public int Id {get; set;}
        public DateTime Date { get; set; }
        public int DistanceInMeters { get; set; }

        public long TimeInSeconds { get; set; }

    }
}
