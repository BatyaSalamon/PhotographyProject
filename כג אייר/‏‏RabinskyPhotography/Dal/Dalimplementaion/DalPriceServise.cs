

namespace Dal.Dalimplementaion
{
    public class DalPriceServise : IDalPrice
    {
        PhotographyContext context;
        public DalPriceServise(PhotographyContext context)
        {
            this.context = context;
        }

        public List<Price> GetAll()
        {
            return context.Prices.ToList();

        }
        public Price Get(int id)
        {
            return context.Prices.FirstOrDefault(c => c.Code == id);
        }

        public Price Post(Price t)
        {
            context.Prices.Add(t);
            context.SaveChanges();
            return t;
        }

        public Price Put(int id, Price t)
        {
            context.Prices.FirstOrDefault(p => p.Code == id).PriceForAnAdditionalHourBeyond7Hours = t.PriceForAnAdditionalHourBeyond7Hours;
            context.Prices.FirstOrDefault(p => p.Code == id).PriceFor320Photos = t.PriceFor320Photos;
            context.Prices.FirstOrDefault(p => p.Code == id).PriceForAnAdditionalHourAfter1Am = t.PriceForAnAdditionalHourAfter1Am;
           
            context.SaveChanges();
            return t;
        }
        public Price Delete(int id)
        {
            Price TempPrice = context.Prices.FirstOrDefault(c => c.Code == id);
            context.Prices.Remove(TempPrice);
            context.SaveChanges();
            return TempPrice;
        }

    }
}
