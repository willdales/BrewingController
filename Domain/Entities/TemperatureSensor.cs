using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class TemperatureSensor
    {
        public string SensorId { get; set; }
        public string? SensorName { get; set; }

        public IList<TemperatureReading> Readings { get; private set; } = new List<TemperatureReading>();


    }
}
