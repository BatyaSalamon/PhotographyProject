
namespace Dal.Dalimplementaion
{
    public class DalCustomerServise : IDalCustomer
    {
        PhotographyContext context;
        public DalCustomerServise(PhotographyContext context) 
        { 
           this.context = context;
        }

        public List<Customer> GetAll()
        {
          return context.Customers.ToList();

        }

        public Customer Get(int id)
        {
            return context.Customers.FirstOrDefault(c => c.Id == id);
        }
        //לבדוק אם זה טיפש לעשות כזאת פונקציה ב-Dal
        public Customer GetByPhon(string phon)
        {
            return context.Customers.FirstOrDefault(c => c.Phone == phon);
        }


        public Customer Post(Customer t)
        {
           context.Customers.Add(t);
            context.SaveChanges();
            return t;
            
        }

        public Customer Put(Customer t)
        {
            context.Customers.FirstOrDefault(p => p.Id == t.Id).PhotographerId = t.PhotographerId;
            context.Customers.FirstOrDefault(p => p.Id == t.Id).Hall=t.Hall;
            context.Customers.FirstOrDefault(p => p.Id == t.Id).ChatanName = t.ChatanName;
            context.Customers.FirstOrDefault(p => p.Id == t.Id).KalaName = t.KalaName;
            context.Customers.FirstOrDefault(p => p.Id == t.Id).Phone=t.Phone;
            context.SaveChanges();
            return t;

        }
        public Customer Delete(int id)
        {
            Customer TempCustomer = context.Customers.FirstOrDefault(c => c.Id == id);
            context.Customers.Remove(TempCustomer);
            context.SaveChanges();
            return TempCustomer;
        }
    }
}
