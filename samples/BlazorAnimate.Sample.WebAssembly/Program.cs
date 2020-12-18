using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Blazor.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorAnimate.Sample.WebAssembly
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.Configure<AnimateOptions>("my", options =>
            {
                options.Mirror = true;
                options.Animation = Animations.FadeDown;
                options.Duration = TimeSpan.FromSeconds(2);
            });

            builder.Services.Configure<AnimateOptions>(options =>
            {
                options.Mirror = true;
                options.Animation = Animations.FadeDown;
                options.Duration = TimeSpan.FromMilliseconds(100);
            });

            await builder.Build().RunAsync();
        }
    }
}
