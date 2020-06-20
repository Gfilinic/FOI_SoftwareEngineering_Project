using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class Measurement
    {
        public int Id_measurement { get; set; }
        public string measurement1 { get; set; }

        public Measurement(int id_measurment, string measurement)
        {
            this.Id_measurement = id_measurment;
            this.measurement1 = measurement;
        }
    }
}
