using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    interface ILogger
    {
        void Log();
    }
    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Dataabse");
        }
    }
    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to File");
        }
    }
    class EmployeeManager
    {
        private ILogger _iLogger;
        public EmployeeManager(ILogger iLogger)
        {
            _iLogger = iLogger;
        }
        public void Add()
        {
            _iLogger.Log();
            Console.WriteLine("Added");
        }
    }
}
