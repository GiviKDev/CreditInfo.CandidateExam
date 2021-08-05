using System;

using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace CreditInfo.CandidateExam.Core.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder MigrateDatabase<T>(this IApplicationBuilder applicationBuilder) where T : DbContext
        {
            using var scope = applicationBuilder.ApplicationServices.CreateScope();
            var services = scope.ServiceProvider;
            try
            {
                using var db = services.GetRequiredService<T>();
                db.Database.Migrate();
            }
            catch (Exception ex)
            {
                var logger = services.GetRequiredService<ILogger<T>>();
                logger.LogError(ex, "An error occurred while migrating the database.");
            }

            return applicationBuilder;
        }
    }
}
