using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDPServer_MoldProject
{
    public class DeviceHumidityTemperature
    {
        public DeviceHumidityTemperature()
        {
        }

        public int DeviceNo { get; set; }
        public double Temperature { get; set; }
        public double Humidity { get; set; }

        public DeviceHumidityTemperature(int deviceNo, double temperature, double humidity)
        {
            DeviceNo = deviceNo;
            Temperature = temperature;
            Humidity = humidity;
        }


    }
}
