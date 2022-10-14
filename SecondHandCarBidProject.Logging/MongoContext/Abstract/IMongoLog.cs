using SecondHandCarBidProject.Logging.LogModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHandCarBidProject.Logging.MongoContext.Abstract
{
    public interface IMongoLog<T>
    {
        Task<bool> AddLogToMongo(T log);
    }
}
