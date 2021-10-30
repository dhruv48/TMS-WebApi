using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TMS.Filters;
using Newtonsoft.Json;
using TMS.Api.IOC;
using TMS.Api.Extensions;

namespace TMS
{
    public class Startup
    {
        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {


            IOCConfiguration.Configuration(services);
            services.AddSingleton(Configuration);
            services.AddCors(o => o.AddPolicy(MyAllowSpecificOrigins, builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));
            services.AddControllers();
            //services.AddJwtTokenAuthentication(Configuration);
            services.AddSwaggerConfiguration();

            services.AddMvc(options =>
            {
                options.Filters.Add(typeof(ValidateModelFilter));
            }).AddDataAnnotationsLocalization()
            .AddNewtonsoftJson(
                o =>
                {
                    o.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
                    o.SerializerSettings.MissingMemberHandling = MissingMemberHandling.Ignore;
                });


            //    }).AddJsonOptions(options =>
            //    {
            //        options.JsonSerializerOptions.Converters.Add(new validEnumConverter());
            //    });


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwaggerSetup();

            app.UseCors(MyAllowSpecificOrigins);

            app.UseRouting();
            app.UseAuthentication();
            app.UseHttpsRedirection();
            app.UseAuthorization();
            //app.UseMiddleware<ErrorHandlerMiddleware>();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

