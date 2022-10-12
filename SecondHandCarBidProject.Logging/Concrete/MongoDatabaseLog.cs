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
    public class MongoDatabaseLog : ILoggerExtension
    {
        MongoLog mongoLog;
        public MongoDatabaseLog()
        {
             mongoLog = new MongoLog();
            
        }
        public Task DataLog(LogModel data)
        {
            return mongoLog.AddLogToMongo(data);
        }
    }
}
