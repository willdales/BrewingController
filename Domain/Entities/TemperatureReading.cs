using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class TemperatureReading
    {
        public string TemperatureSensorId { get; set; }

        public double Reading { get; set; }
    }
}
