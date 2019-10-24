using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace Hosting
{
  internal class StartUp
  {

    public void Configure(IApplicationBuilder app){
      app.Use( async (context, next) => {
        await context.Response.WriteAsync("Trabalhando com class StartUp");
      });
    }

  }
}