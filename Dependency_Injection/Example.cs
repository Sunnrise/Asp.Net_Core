using Dependency_Injection.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Dependency_Injection
{
    public class Example
    {
        public Example()
        {
            IServiceCollection services = new ServiceCollection();//build-in IoC container
            services.Add(new ServiceDescriptor(typeof(ConsoleLog),new ConsoleLog(5)));
            services.Add(new ServiceDescriptor(typeof(TextLog), new TextLog()));

            ServiceProvider provider =services.BuildServiceProvider();//
            provider.GetService<ConsoleLog>().Log();
            provider.GetService<TextLog>().Log();


        }
    }
}
