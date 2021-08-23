using Core.CrossCuttin.Caching;
using Core.CrossCuttin.Caching.MicrosoftStorage;
using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Core.DependencyResolvers
{
    public class CoreModule : ICoreModule
    {
        public void Load(IServiceCollection serviceColletion)
        {
            serviceColletion.AddMemoryCache();
            serviceColletion.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            serviceColletion.AddSingleton<ICacheManager, MemoryCacheManager>();
            serviceColletion.AddSingleton<Stopwatch>();
        }
    }
}
