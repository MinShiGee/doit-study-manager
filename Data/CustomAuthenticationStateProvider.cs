using System.Security.Claims;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazored.SessionStorage;

namespace Doit_Study_Manager.Data
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        private ISessionStorageService _sessionStorageService;
        
        public CustomAuthenticationStateProvider(ISessionStorageService sessionStorageService)
        {
            _sessionStorageService = sessionStorageService;
        }
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {

            var studentCode = await _sessionStorageService.GetItemAsync<string>("studentCode");
            ClaimsIdentity identity;

            if(studentCode != null)
            {
                identity = new ClaimsIdentity(new []
                {
                    new Claim(ClaimTypes.Name, studentCode)
                }, "apiauth_type");
            }
            else{
                identity = new ClaimsIdentity();
            } 
            var user = new ClaimsPrincipal(identity);

            return await Task.FromResult(new AuthenticationState(user));
        }

        public void MarkUserAsAuthenticated(string studentCode)
        {
            var identity = new ClaimsIdentity(new []{
                new Claim(ClaimTypes.Name, studentCode)
            }, "apiauth_type");
            var user = new ClaimsPrincipal(identity);
            
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }
    }
    
}