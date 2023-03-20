using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElonIsVeryRich.Data.Models
{
    public class LaunchModel
    {
        public int? FlightNumber { get; set; }
        public string MissionName { get; set; }
        public string LaunchYear { get; set; }

        public Rocket Rocket { get; set; }
    }
}
