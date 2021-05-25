using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TransportManagementProject.Models
{
    public class Route
    {[Key]
        public int RouteNumber { get; set; }
    
        public int VehicleID { get; set; }
        public string StopOne { get; set; }
        public string StopTwo { get; set; }
        public string StopThree { get; set; }
       // public Vehicle Vehicles { get; set; }
    }
}
