using System;


namespace UDPMoldProjectClassLibrary
{
    public class DataFromSensor
    {
        public int DeviceNo { get; set; }
        public double Temperature { get; set; }
        public double Humidity { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
