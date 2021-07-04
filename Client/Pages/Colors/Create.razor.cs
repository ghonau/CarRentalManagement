using CarRentalManagement.Client.Services;
using CarRentalManagement.Client.Statics;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;


namespace CarRentalManagement.Client.Pages.Colors
{
    public partial class Create : IDisposable
    {
        [Inject] HttpInterceptorService HttpInterceptorServic { get; set; }
        [Inject] HttpClient HttpClient { get; set; }
        [Inject] NavigationManager NavigationManager { get; set; }

        public void Dispose()
        {
            HttpInterceptorServic.DisposeEvent();
        }
        
        Color color = new Color();
        private async Task CreateColor()
        {
            HttpInterceptorServic.MonitorEvent(); 
            await HttpClient.PostAsJsonAsync(Endpoints.ColorsEndpoint, color);
            NavigationManager.NavigateTo("/colors");
        }
    }
}
