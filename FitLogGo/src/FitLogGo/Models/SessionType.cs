using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FitLogGo.Models
{
    public class SessionType
    {
        [Key]
        public int SessionTypeId { get; set; }
        public int SessionId { get; set; }
        public int TreadmillId { get; set; }
        public int BikeId { get; set; }
        public int EllipticalId { get; set; }

        public Session Session { get; set; }
    }
}
