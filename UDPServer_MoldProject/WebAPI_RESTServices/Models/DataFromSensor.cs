using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_RESTServices.Models
{
    public class DataFromSensor
    {
        public DataFromSensor()
        {
        }

        public int DataId { get; set; }
        public int DeviceNo { get; set; }
        public double Temperature { get; set; }
        public double Humidity { get; set; }
        public DateTime TimeStamp { get; set; }

        public DataFromSensor(int dataId, int deviceNo, double temperature, double humidity, DateTime timeStamp)
        {
            DataId = dataId;
            DeviceNo = deviceNo;
            Temperature = temperature;
            Humidity = humidity;
            TimeStamp = timeStamp;
        }

        public override string ToString()
        {
            //Simple string containing the property names and thier respective values
            return $"Data Id: {DataId} - Device No: {DeviceNo} - Temperature: {Temperature} - Humidity: {Humidity} - Time Stamp: {TimeStamp}";
        }
    }
}
