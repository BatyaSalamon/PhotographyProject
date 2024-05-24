
namespace Bl
{
    public class BLManager
    {
        public IBLCustomer Customer { get; set; }
        public IBLAllCustomer AllCustomer { get; set; }
        public IBLPhotographer Photographer { get; set; }
        public IBLPrice Price { get; set; }

        public BLManager(string connStr) {

            ServiceCollection service = new ServiceCollection();
            service.AddSingleton<DalManager>(x => new DalManager(connStr));
            service.AddAutoMapper(typeof(AutoMapper.AutoMapperProfile));

            service.AddScoped<IBLPrice, BLPriceServise>();
            service.AddScoped<IBLPhotographer, BLPhotographerServise>();
            service.AddScoped<IBLCustomer, BLCustomerServise>();
            service.AddScoped<IBLAllCustomer, BLAllCustomerService>();

            ServiceProvider serviceProvider = service.BuildServiceProvider();

            Customer = serviceProvider.GetRequiredService<IBLCustomer>();
            AllCustomer = serviceProvider.GetRequiredService<IBLAllCustomer>();
            Photographer = serviceProvider.GetRequiredService<IBLPhotographer>();
            Price = serviceProvider.GetRequiredService<IBLPrice>();
        }
    }
}
