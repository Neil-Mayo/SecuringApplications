using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ShoppingCart.Application.AutoMapper;
using ShoppingCart.Application.Interfaces;
using ShoppingCart.Application.Services;
using ShoppingCart.Data.Context;
using ShoppingCart.Data.Repositories;
using ShoppingCart.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.IOC
{
   public class DependencyContainer
    {

        //is called when the application (website) starts and does the associations that follow in the method RegisterServices.
        //why?
        //so whenever there's a call that demands an instance of a class (interface) which has been recognized in the method RegisterServices,
        //the RegisterServices method, creates an instance of that on-demand "class"
        //and we are also informing the RegisterServices about the associations that exist between interface - class+implemention

        //what AddScoped mean?

        /*  https://www.tutorialsteacher.com/core/dependency-injection-in-aspnet-core
         *  Singleton: IoC container will create and share a single instance of a service throughout the application's lifetime.
            Transient: The IoC container will create a new instance of the specified service type every time you ask for it.
            Scoped: IoC container will create an instance of the specified service type once per request and will be shared in a single request
         */
        public static void RegisterServices(IServiceCollection services, string connectionString)
        {

            services.AddDbContext<ShoppingCartDbContext>(options =>
          {
              options.UseSqlServer(
               connectionString);//.UseLazyLoadingProxies();
                }
                );

            services.AddScoped<IProductsRepository, ProductsRepository>();
            services.AddScoped<IProductsService, ProductsService>();

            services.AddScoped<ICategoryRepository, CategoriesRepository>();
            services.AddScoped<ICategoriesService, CategoriesService>();

            services.AddScoped<IMembersRepository, MembersRepository>();
            services.AddScoped<IMembersService, MemberService>();

            services.AddAutoMapper(typeof(AutoMapperConfiguration));
            AutoMapperConfiguration.RegisterMappings();

        }


   


    }
}
