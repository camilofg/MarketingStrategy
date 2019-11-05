using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;
using Services;

namespace CreateConfigs
{
    public static class Bootstrapper
    {
        public static void Init()
        {
            DependencyInjector.Register<IRequestTermsService, RequestTermsService>();
            DependencyInjector.Register<IRequestTerms, RequestsTerms>();
            DependencyInjector.Register<IServiceManager, ServiceManager>();
            DependencyInjector.Register<IFileManager, FileManager>();
            DependencyInjector.Register<IProfiler, Profiler>();
        }
    }
}
