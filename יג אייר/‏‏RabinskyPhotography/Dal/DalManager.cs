

namespace Dal
{
    public class DalManager
    {
        public IDalCustomer Customer { get; set; }
        public IDalPhotographer Photographer { get; set; }
        public IDalPrice Price { get; set; }
        public DalManager(string connStr) 
        {
            ServiceCollection service = new ServiceCollection();

            //service.AddSingleton<PhotographyContext>();
            service.AddScoped<IDalPrice, DalPriceServise>();
            service.AddScoped<IDalPhotographer , DalPhotographerServise>();
            service.AddScoped <IDalCustomer,DalCustomerServise>();

            service.AddDbContext<PhotographyContext>(opt => opt.UseSqlServer(connStr));


            ServiceProvider serviceProvider = service.BuildServiceProvider();

            Customer=serviceProvider.GetRequiredService<IDalCustomer>();
            Photographer = serviceProvider.GetRequiredService<IDalPhotographer>();
            Price= serviceProvider.GetRequiredService<IDalPrice>();
        }


    }
}
