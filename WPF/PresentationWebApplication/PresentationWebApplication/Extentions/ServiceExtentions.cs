using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace PresentationWebApplication.Extentions
{
    public static class ServiceExtensions
    {
        #region methods

        public static void ConfigureCors(this IServiceCollection services)
        {
            //Specify specific origin instead of any origin
            //WithOrigins("http://www.something.com")

            //Specify methods instead of any method
            //WithMethods("POST", "GET")

            //Specify header instead of any header
            //WithHeaders("accept", "content-type")

            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader());
            });
        }

        public static void ConfigureIisIntegration(this IServiceCollection services)
        {
            //Add properties
            //AutomaticAuthentication
            //AuthenticationDisplayName
            //ForwardClientCertificate

            services.Configure<IISOptions>(options => { });
        }

        #endregion methods
    }
}