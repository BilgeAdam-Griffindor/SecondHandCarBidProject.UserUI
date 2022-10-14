using NLog.Filters;
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
    public class LoggerFactoryMethod<T> where T:class
    {
        public enum LoggerType
        {
            MongoDatabaseLogger = 1,
            FileLogger = 2,
        }
        public async Task FactoryMethod(LoggerType logType, T data)
        {
            ILoggerExtension<T> log = null;
            switch (logType)
            {
                case LoggerType.MongoDatabaseLogger:
                    log = new MongoDatabaseLog<T>();
                    break;
                case LoggerType.FileLogger:
                    log = new FileLogger<T>();
                    break;
                default:
                    break;
            }
            await log.DataLog(data);
        }
    }
}
