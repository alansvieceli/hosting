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
      
      string ordem = string.Empty;

      app.Use( async (context, next) => {

        ordem += "1";
        await next.Invoke(); //chama o proximo midleware

        ordem += "4";
        await context.Response.WriteAsync($"Ordem: {ordem}");
        //await context.Response.WriteAsync("Trabalhando com class StartUp : " + _configuration["Application"]);
      });

      app.Use( async (context, next) => {

        ordem += "2";
        await next.Invoke(); //chama o proximo midleware
        
        ordem += "3";        
        //await context.Response.WriteAsync("Welcome");        
      });
    }

  }
}