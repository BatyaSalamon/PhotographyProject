

namespace Dal.Dalimplementaion
{
    public class DalPhotographerServise : IDalPhotographer
    {
                PhotographyContext context;
        public DalPhotographerServise(PhotographyContext context) 
        { 
           this.context = context;
        }

        public List<Photographer> GetAll()
        {
            IEnumerable<Photographer> photographers = context.Photographers;
            return photographers.ToList();

        }

        public List<Photographer> GetAllWithPrice()
        {
            IEnumerable<Photographer> photographers = context.Photographers.Include(p => p.PriceCodeNavigation);
            return photographers.ToList();

        }
        public List<Photographer> GetAllWithCustomer()
        {
            IEnumerable<Photographer> photographers = context.Photographers.Include(c =>c.Customers);
            return photographers.ToList();

        }



        public Photographer Get(int id)
        {
            return context.Photographers.FirstOrDefault(c => c.Id == id);
        }
        //public List<Customer> GetWithCustomers(int id)
        //{
        //    return context.Photographers.FirstOrDefault(c => c.Id == id).Customers.ToList();
        //}

        public Photographer Post(Photographer t)
        {
            context.Photographers.Add(t);
            context.SaveChanges();
            return t;
        }

        public Photographer Put(int id, Photographer t)
        {
            context.Photographers.FirstOrDefault(p => p.Id == id).FirstName = t.FirstName;
            context.Photographers.FirstOrDefault(p => p.Id == id).LastName = t.LastName;
            context.Photographers.FirstOrDefault(p => p.Id == id).PriceCode = t.PriceCode;
          
            context.SaveChanges();
            return t;
        }
        public Photographer Delete(int id)
        {
            Photographer TempPhotographer = context.Photographers.FirstOrDefault(c => c.Id == id);
            context.Photographers.Remove(TempPhotographer);
            context.SaveChanges();
            return TempPhotographer;
        }
    }
}
