using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;

namespace HelloWeb
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.Run(context =>
            {
                return context.Response.WriteAsync("Hello from the .NET app running on " +
                                                   "\033[36mCloud Foundry\033[0m the time here is : " 
                                                   + DateTime.Now.ToString() + "\n");
      	  });
        }
    }
}
