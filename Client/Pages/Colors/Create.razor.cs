using CarRentalManagement.Client.Contracts;
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
    public partial class Create 
    {
        
        [Inject] IHttpRepository<Color> _client { get; set; }
        [Inject] NavigationManager NavigationManager { get; set; }
       
        Color color = new Color();
        private async Task CreateColor()
        {
            await _client.Create(Endpoints.ColorsEndpoint, color);                         
            NavigationManager.NavigateTo("/colors");
        }
    }
}
