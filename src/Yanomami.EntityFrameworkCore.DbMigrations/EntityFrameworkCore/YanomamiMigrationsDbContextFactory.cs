﻿using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Yanomami.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class YanomamiMigrationsDbContextFactory : IDesignTimeDbContextFactory<YanomamiMigrationsDbContext>
    {
        public YanomamiMigrationsDbContext CreateDbContext(string[] args)
        {
            YanomamiEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<YanomamiMigrationsDbContext>()
                .UseSqlite(configuration.GetConnectionString("Default"));

            return new YanomamiMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
