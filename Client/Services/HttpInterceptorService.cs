using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Toolbelt.Blazor;

namespace CarRentalManagement.Client.Services
{
    public class HttpInterceptorService
    {
        private readonly NavigationManager _navigationManager;
        public HttpClientInterceptor _interceptor; 
        public HttpInterceptorService(HttpClientInterceptor interceptor, NavigationManager navigationManager)
        {
            _interceptor = interceptor;
            _navigationManager = navigationManager;
        }        
        public void MonitorEvent() => _interceptor.AfterSend += InterceptResponse;

        private void InterceptResponse(object sender, HttpClientInterceptorEventArgs e)
        {
            string message = string.Empty;
            if (e.Response.IsSuccessStatusCode)
                return; 

            var responseCode = e.Response.StatusCode;
            switch (responseCode)
            {
                case System.Net.HttpStatusCode.NotFound:
                    {

                        _navigationManager.NavigateTo("/400");
                        message = "The requested resource was not found"; 
                        break; 
                    }
                case System.Net.HttpStatusCode.Unauthorized:
                case System.Net.HttpStatusCode.Forbidden:
                    {

                        _navigationManager.NavigateTo("/unauthorized");
                        message = "You are not authorized to access this resource. "; 
                        break;
                    }                
                    
                default:
                    _navigationManager.NavigateTo("/500");
                    message = "Something went wrong, please contact Administrator";
                    break; 
            }
        }
        public void DisposeEvent() => _interceptor.AfterSend -= InterceptResponse; 
    }
}
