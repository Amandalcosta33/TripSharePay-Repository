using Microsoft.OpenApi.Models;

namespace TripSharePay_Repository.IoC
{
    public static class SwaggerConfig
    {
        public static void AddSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "TripSharePay_Repository",
                    Version = "MVP - v1",
                    Description = "Web Service para trabalho de dispositivos móveis",
                    Contact = new OpenApiContact
                    {
                        Name = "Amanda Lopes Costa",
                        Email = "amanda.lcosta33@gmail.com.br",
                        Url = new Uri("https://github.com/Amandalcosta33"),
                    }
                });
/*                 c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = @"JWT Authorization header using the Bearer scheme.
                      Enter 'Bearer' [space] and then your token in the text input below.
                    Example: 'Bearer 12345abcdef'",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer"
                }); */

                c.AddSecurityRequirement(new OpenApiSecurityRequirement()
                {
/*                     {
                        new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference
                                    {
                                        Type = ReferenceType.SecurityScheme,
                                        Id = "Bearer"
                                    },
                                Scheme = "oauth2",
                                Name = "Bearer",
                                In = ParameterLocation.Header
                            },
                        new List<string>()
                     } */
                });
            });
        }
        public static void UseSwaggerUI(this IApplicationBuilder app)
        {
            app.UseSwagger();
             app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "TripSharePay Repository");
            }); 
        }
    }
}
