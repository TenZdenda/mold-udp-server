using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_RESTServices.Models;

namespace WebAPI_RESTServices.DataFromSensorManager
{
    public interface IDataManager
    {
        void Add(DataFromSensor newDataFromSensor);      
        IEnumerable<DataFromSensor> GetAll();

        //IEnumerable<DataFromSensor> GetAllBetweenDates(DateTime startDate, DateTime endDate);
    }
}
