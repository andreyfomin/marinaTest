using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using marinaTest.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace marinaTest
{
  public class Startup
  {
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddSingleton<ContactRepository>();
      services.AddMvc();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }
      else
      {
        app.UseExceptionHandler("/Home/Error");
      }

      app.UseDefaultFiles();
      app.UseStaticFiles();


      app.UseMvc(routes =>
      {
        routes.MapRoute(
               name: "default",
               template: "{controller=Home}/{action=Index}/{id?}");
        routes.MapRoute(
              name: "contactsById",
              template: "api/contacts/{id:int}",
              defaults: new { controller = "Contact", action = "ContactsById" });
        routes.MapRoute(
              name: "contactsByName",
              template: "api/contacts/{name}",
              defaults: new { controller = "Contact", action = "ContactsByName" });
        routes.MapRoute(
              name: "contacts",
              template: "api/contacts",
              defaults: new { controller = "Contact", action = "ContactsAll" });
      });
    }
  }
}
