using System;
using Dependency_Injection.Services.Interfaces;

namespace Dependency_Injection.Services
{
    public class TextLog : ILog
    {
        public void Log()
        {
            Console.WriteLine("Text logging");
        }
    }
}
