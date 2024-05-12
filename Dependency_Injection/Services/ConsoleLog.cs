using System;
using Dependency_Injection.Services.Interfaces;

namespace Dependency_Injection.Services
{
    public class ConsoleLog:ILog
    {
        public ConsoleLog(int a) { }

        public void Log()
        {
            Console.WriteLine("Console logging");
        }
    }
}
