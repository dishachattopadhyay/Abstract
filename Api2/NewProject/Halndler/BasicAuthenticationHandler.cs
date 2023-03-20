using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Authentication;
using System.Text.Encodings.Web;
using  NewProject.Models;
using System.Security.Claims;
using System.Net.Http.Headers;
using System.Text;

namespace NewProject.Halndler
{
    public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions> 
    {
        private readonly  EmpContext _empContext; 
        public BasicAuthenticationHandler(IOptionsMonitor<AuthenticationSchemeOptions> option, ILoggerFactory logger, UrlEncoder encoder, ISystemClock clock, EmpContext empContext): base(option ,logger, encoder, clock )
        {
            _empContext = empContext;
        }
        //implementing the abstract method BasicAuthenticationHandler
        //using task as a multi threading , while using asyn and await
        protected async override Task<AuthenticateResult> HandleAuthenticateAsync(){
        try{
            if(!Request.Headers.ContainsKey("Authorization"))
                return AuthenticateResult.Fail("NO header Found");

            var _headervalue = AuthenticationHeaderValue.Parse(Request.Headers["Authorization"]);
            var bytes = Convert.FromBase64String(_headervalue.Parameter);
            string credentials = Encoding.UTF8.GetString(bytes);
            if(!string.IsNullOrEmpty(credentials))
            {
                string[] array = credentials.Split(":");
                string username = array[0];
                string password = array[1];
                var user = this._empContext.EmpDatas.FirstOrDefault(item=>item.Userid==username && item.Password==password);
                if (user==null) 
                    return AuthenticateResult.Fail("UnAuthorize"); 

                //Generate ticket
                var claim = new []{ new Claim(ClaimTypes.Name,username)};  //value username
                var identity = new ClaimsIdentity(claim,Scheme.Name);
                var principle = new ClaimsPrincipal(identity);
                var ticket = new AuthenticationTicket(principle,Scheme.Name) ;  // claim principle , property

                return AuthenticateResult.Success(ticket);   //expecting a auth ticket which we are gonna make with username password

            }
            else{
                return AuthenticateResult.Fail("UnAuthorize"); 

            }}
            catch(Exception e ){throw e;}
        }
    }
}