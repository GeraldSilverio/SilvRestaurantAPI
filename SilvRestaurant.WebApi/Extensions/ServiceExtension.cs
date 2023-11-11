using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;

namespace SilvRestaurant.WebApi.Extensions
{
    public static class ServiceExtension
    {
        public static void AddSwaggerExtension(this IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                List<string> xmFiles = Directory.GetFiles(AppContext.BaseDirectory, "*.xml", SearchOption.TopDirectoryOnly).ToList();
                xmFiles.ForEach(xmFile => options.IncludeXmlComments(xmFile));

                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "SilvRestaurant API",
                    Description = "This API will be responsible for overall data distribution",
                    Contact = new OpenApiContact
                    {
                        Name = "Gerald Silverio",
                        Email = "es.geraldsilverio@gmail.com",
                        Url = new Uri("https://www.instagram.com/iamgeraldsilv/")
                    }
                });

                options.DescribeAllParametersInCamelCase();
            });
        }

        public static void AddApiVersioningExtension(this IServiceCollection services)
        {
            services.AddApiVersioning(config =>
            {
                config.DefaultApiVersion = new ApiVersion(1, 0);
                config.AssumeDefaultVersionWhenUnspecified = true;
                config.ReportApiVersions = true;
            });
        }
    }
}
