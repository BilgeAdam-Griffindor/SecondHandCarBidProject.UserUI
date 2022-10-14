using SecondHandCarBidProject.Logging.LogModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHandCarBidProject.Logging.Abstract
{
    public interface ILoggerExtension<T>
    {
        Task DataLog(T data);
    }
}
