using CarRentalManagement.Client.Services;
using CarRentalManagement.Client.Statics;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Colors
{
    public partial class Index : IDisposable
    {    

        [Inject] HttpClient Client { get; set; }
        [Inject] IJSRuntime JsRunTime {get;set;}
        [Inject] HttpInterceptorService Interceptor { get; set; }
        public void Dispose()
        {
            Interceptor.DisposeEvent(); 
        }

        private async Task Delete(int colorId)
        {
            var color = Colors.First(m => m.Id == colorId);
            var confirm = await JsRunTime.InvokeAsync<bool>("confirm", $"Do you want to delete {color.Name}");
            if (confirm)
            {
                await Client.DeleteAsync(Endpoints.ColorsEndpoint + $"/{colorId}");
                await OnInitializedAsync();
            }
        }

        private List<Color> Colors;
        protected override async Task OnInitializedAsync()
        {
            Interceptor.MonitorEvent(); 
            Colors = await Client.GetFromJsonAsync<List<Color>>(Endpoints.ColorsEndpoint);
        }
    }
}
