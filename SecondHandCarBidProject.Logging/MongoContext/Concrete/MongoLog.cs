using Microsoft.Extensions.Options;
using MongoDB.Driver;
using SecondHandCarBidProject.Logging.LogModels;
using SecondHandCarBidProject.Logging.MongoContext.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHandCarBidProject.Logging.MongoContext.Concrete
{
    public class MongoLog : IMongoLog
    {
        IMongoCollection<LogModel> _mongoLog;
        public MongoLog()
        {
            var mongoSettings = MongoClientSettings.FromConnectionString("mongodb://localhost:27017");
            mongoSettings.ServerApi = new ServerApi(ServerApiVersion.V1);
            var client = new MongoClient(mongoSettings);
            var logForMongoDB = client.GetDatabase("local");
            _mongoLog = logForMongoDB.GetCollection<LogModel>("SecondHandUserUI_Log");
        }
        public async Task<bool> AddLogToMongo(LogModel log)
        {
            try
            {
                await _mongoLog.InsertOneAsync(log);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
