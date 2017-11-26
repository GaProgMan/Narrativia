using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Narrativia.Repository;
using Narrativia.Repository.Data;
using Narrativia.Services;

namespace Narrativia.Ui
{
    public static class ConfigureContainerExtensions
    {
        public static void AddDbContext(this IServiceCollection serviceCollection,
            string dataConnectionString = null, string authConnectionString = null)
        {
            serviceCollection.AddDbContext<DataContext>(options =>
                options.UseSqlite(dataConnectionString ?? GetDataConnectionStringFromConfig()));

            // TODO uncomment these when ready to add admin area
//            serviceCollection.AddDbContext<AppIdentityDbContext>(options =>
//                options.UseSqlite(authConnectionString ?? GetAuthConnectionFromConfig()));
//
//            serviceCollection.AddIdentity<ApplicationUser, IdentityRole>()
//                .AddEntityFrameworkStores<AppIdentityDbContext>();
        }
        
        public static void AddRepository(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(DataRepository<>));
        }
        
        public static void AddTransientServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IBlogPostService, BlogPostService>();
            serviceCollection.AddTransient<IPageService, PageService>();
        }
        
        private static string GetDataConnectionStringFromConfig()
        {
            return new DatabaseConfiguration().GetDataConnectionString();
        }

//        private static string GetAuthConnectionFromConfig()
//        {
//            return new DatabaseConfiguration().GetAuthConnectionString();
//        }
        
        /// <summary>
        /// Adds rules to the <see cref="RazorViewEngineOptions"/> for dealing with Feature Folders
        /// </summary>
        /// <param name="serviceCollection">
        /// The <see cref="IServiceCollection"/> created in <see cref="Startup.ConfigureServices"/>
        /// </param>
        public static void AddFeatureFolders(this IServiceCollection serviceCollection)
        {
            serviceCollection.Configure<RazorViewEngineOptions>(options =>
            {
                options.ViewLocationExpanders.Add(new FeatureLocationExpander());
            });
        }
    }
}