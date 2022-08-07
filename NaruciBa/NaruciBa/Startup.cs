using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using NaruciBa.Database;
using NaruciBa.Hubs;
using NaruciBa.Services;
using NaruciBa.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaruciBa
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
            IdentityModelEventSource.ShowPII = true;
            services.AddAutoMapper(typeof(Startup));
            services.AddControllers();
            services.AddSignalR();
            services.AddSwaggerGen(options =>
            {
                options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Description = "JWT Authorization header using the Bearer scheme. \r\n\r\n Enter 'Bearer' [space] and then your token in the text input below.\r\n\r\nExample: \"Bearer 1safsfsdfdfd\"",
                });
                options.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            }
                        },
                     new string[] {}
                    }
                });
            });
            services.AddDbContext<NaruciBaContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddAuthentication("Bearer")
            .AddJwtBearer("Bearer", options =>
            {

                options.Authority = Configuration.GetValue<string>("IndentityServerUrl");

                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateAudience = false,
                    ValidateIssuer = false // Mora se onemoguciti zbog flutter aplikacije na android emulatoru
                };
            });

            services.AddAuthorization(options =>
            {
                options.AddPolicy("WinApp", policy =>
                {
                    policy.RequireAuthenticatedUser();
                    policy.RequireClaim("scope", "WinAppScope");
                });
                options.AddPolicy("MobileApp", policy =>
                {
                    policy.RequireAuthenticatedUser();
                    policy.RequireClaim("scope", "MobileAppScope");
                });
            });

            //================== Specific service implementations ======================//

            services.AddScoped<IKorisnikService, KorisnikService>();
            services.AddScoped<IPodkategorijaService, PodkategorijaService>();
            services.AddScoped<IKategorijaService, KategorijaService>();
            services.AddScoped<IGradService, GradService>();
            services.AddScoped<ITrgovackiLanacService, TrgovackiLanacService>();
            services.AddScoped<IPoslovnicaService, PoslovnicaService>();
            services.AddScoped<IProizvodService, ProizvodService>();
            services.AddScoped<IPoslovnicaKategorijaService, PoslovnicaKategorijaService>();
            services.AddScoped<INarudzbaService, NarudzbaService>();
            services.AddScoped<INarudzbaStatusService, NarudzbaStatusService>();
            services.AddScoped<INaruceniProizvod, NaruceniProizvodService>();
            services.AddScoped<IKlijentService, KlijentService>();
            services.AddScoped<IDostavljacService, DostavljacService>();
            services.AddScoped<IDostavljacStatus, DostavljacStatusService>();
            services.AddScoped<IKoordinatorService, KoordinatorService>();

            //========================================================================//

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseSwagger();

            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHub<NaruciBaHub>("NaruciBaHub");
                endpoints.MapControllers();
            }); 

        }
    }
}
