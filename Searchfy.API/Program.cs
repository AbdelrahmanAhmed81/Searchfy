using Elastic.Clients.Elasticsearch;
using Elastic.Transport;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Searchfy.Services.Contracts.Repositories;
using Searchfy.Services.Repositories;
using System;

namespace Searchfy.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            ConfigureServices(services: builder.Services , configuration: builder.Configuration);

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }

        private static void ConfigureServices(IServiceCollection services , IConfiguration configuration)
        {
            const string environmentVariable = "ASPNETCORE_ENVIRONMENT";

            #region App Configurations
            Configuration appConfiguration = new ();
            configuration.Bind(appConfiguration);
            services.AddSingleton(typeof(Configuration) , (_) => appConfiguration);
            #endregion

            #region Elasticsearch Configurations
            var settings = new ElasticsearchClientSettings(new Uri(appConfiguration.Elasticsearch.BaseURL))
                .CertificateFingerprint(appConfiguration.Elasticsearch.FingerPrint)
                .Authentication(new BasicAuthentication(appConfiguration.Elasticsearch.UserName , appConfiguration.Elasticsearch.Password));

            if (Environment.GetEnvironmentVariable(environmentVariable) == Environments.Development)
            {
                settings = settings.PrettyJson(true);
            }

            services.AddScoped(typeof(ElasticsearchClient) , (_) => new ElasticsearchClient(settings));
            #endregion

            #region Repositories
            services.AddScoped<ITabRepository , TabRepository>();
            #endregion
        }

    }
}