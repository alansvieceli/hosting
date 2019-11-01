using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace Hosting
{
  class StartUp
  {
    private readonly IConfiguration _configuration;

    public StartUp(IConfiguration configuration){
        _configuration = configuration;
    }

    public void Configure(IApplicationBuilder app){
      app.Use( async (context, next) => {
        await context.Response.WriteAsync("Trabalhando com class StartUp : " + _configuration["Application"]);
      });
    }

  }
}