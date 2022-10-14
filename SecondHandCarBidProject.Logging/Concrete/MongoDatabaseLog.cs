using SecondHandCarBidProject.Logging.Abstract;
using SecondHandCarBidProject.Logging.LogModels;
using SecondHandCarBidProject.Logging.MongoContext.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHandCarBidProject.Logging.Concrete
{
    public class MongoDatabaseLog<T> : ILoggerExtension<T> where T:class
    {
        MongoLog<T> mongoLog = new MongoLog<T>();
        
        public Task DataLog(T data)
        {
            return mongoLog.AddLogToMongo(data);
        }
    }
}
