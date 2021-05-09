using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.JSInterop;
using TrekSharp.AdventureTools;

namespace TrekSharp.AdventureTools
{
    public class Program {

        private static AppData data;
        private static IJSRuntime runtime;

        public static async Task Main(string[] args) {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddSingleton<AppData>();
            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            var host = builder.Build();
            var provider = host.Services;
            data = provider.GetService<AppData>();
            runtime = provider.GetService<IJSRuntime>();

            await ReloadPersistedSession();

            await host.RunAsync();
        }

        [JSInvokable]
        public static async Task DownloadAppData(AppData data = null) {
            data = data ?? Program.data;
            if (data == null || runtime == null)
                return;

            var filename = "adventure";
            var json = System.Text.Json.JsonSerializer.Serialize(data);
            byte[] file = System.Text.Encoding.UTF8.GetBytes(json);
            await runtime.InvokeVoidAsync("BlazorDownloadFile", $"{filename}.json", "text/json", file);
        }
        [JSInvokable]
        public static async Task PersistSession() {
            if (data == null || runtime == null)
                return;
            try {
                var json = System.Text.Json.JsonSerializer.Serialize(data);
                await runtime.InvokeVoidAsync("BlazorWriteLocalStorage", "treksharp.session", json);
            } catch (Exception e) {
                Console.WriteLine(e);
            }
        }
        public static async Task ReloadPersistedSession() {
            if (data == null || runtime == null)
                return;

            try {
                var json = await runtime.InvokeAsync<string>("BlazorReadLocalStorage", "treksharp.session");
                if (string.IsNullOrEmpty(json))
                    return;
                var app_data = System.Text.Json.JsonSerializer.Deserialize<AppData>(json);
                data.Overwrite(app_data);
            } catch (Exception e) {
                Console.WriteLine(e);
            }
        }
    }
}
