using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TransportManagementProject.Models
{
    public class Vehicle
    {
        [Key]
        public int VehicleID { get; set; }
        public bool IsAvailable { get; set; }
        public int Capacity { get; set; }
        public bool IsOperable { get; set; }
        public ICollection<Route> Routes { get; set; }
    }
}
