using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_RESTServices.Models;

namespace WebAPI_RESTServices.DataFromSensorManager
{
    public class DataManagerDB : IDataManager
    {
        private DataFromSensorContext _context;

        //The constructor takes a Context from whoever initialized it
        public DataManagerDB(DataFromSensorContext context)
        {
            _context = context;
        }
        public void Add(DataFromSensor newDataFromSensor)
        {            
            newDataFromSensor.DataId = 0;
            _context.DataFromSensor.Add(newDataFromSensor);
            //Remember to call the savechanges everytime you make changes
            _context.SaveChanges();
            
        }

        public IEnumerable<DataFromSensor> GetAll()
        {
            return _context.DataFromSensor;
        }
    }
}
