using SecondHandCarBidProject.Logging.Abstract;
using SecondHandCarBidProject.Logging.LogModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHandCarBidProject.Logging.Concrete
{
    public class LoggerFactoryMethod
    {
        public enum LoggerType
        {
            MongoDatabaseLogger = 1,
            FileLogger = 2,
        }
        public async Task FactoryMethod(LoggerType logType, LogModel data)
        {
            ILoggerExtension log = null;
            switch (logType)
            {
                case LoggerType.MongoDatabaseLogger:
                    log = new MongoDatabaseLog();
                    break;
                case LoggerType.FileLogger:
                    log = new FileLogger();
                    break;
                default:
                    break;
            }
            await log.DataLog(data);
        }
    }
}
