using bookapi.Services;
using bookapi.Services.Interfaces;
using Infrastructure.Interfaces;
using Infrastructure.Repositories;

namespace bookapi.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddRepository(IServiceCollection service)
        {
            service.AddScoped<IAuthorRepository, AuthorRepository>();
            service.AddScoped<IBookRepository, BookRepository>();
            service.AddScoped<IReviewRepository, ReviewRepository>(); 
            return service;       
        }

        public static IServiceCollection AddService(IServiceCollection service)
        {
            service.AddScoped<IAuthorService, AuthorService>();
            service.AddScoped<IBookService, BookService>();
            service.AddScoped<IReviewService, ReviewService>();
            return service;
        }
    }
}
