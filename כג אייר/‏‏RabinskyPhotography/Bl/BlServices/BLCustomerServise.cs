

namespace Bl.BlServices
{
    public class BLCustomerServise : IBLCustomer
    {
        IDalCustomer dalManager;
        IMapper mapper;
        public BLCustomerServise(DalManager dalManager, IMapper mapper)
       {
            this.dalManager = dalManager.Customer;
            this.mapper = mapper;
        }

        public List<BLCustomer> GetAll()
        {
            List<Customer> dalCustomers = dalManager.GetAll();
            List<BLCustomer> blAllCustomers = new List<BLCustomer>();
            for (int i = 0; i < dalCustomers.Count(); i++)
            {
                blAllCustomers.Add(mapper.Map<BLCustomer>(dalCustomers[i]));
            }
            return blAllCustomers;
        }

        public BLCustomer Get(int id)
        {
            return mapper.Map < BLCustomer > (dalManager.Get(id));
        }


        public BLCustomer Post(BLCustomer t)
        {
            Customer c = mapper.Map<Customer>(t);
            dalManager.Post(c);
            return mapper.Map<BLCustomer>(c);
            //לא בטוח שהוא מאתחל אוטומטית את מה שחסר לו

        }

        public BLCustomer Put(int id, BLCustomer t)
        {
            throw new NotImplementedException();
        }
        public BLCustomer Delete(int id)
        {
            throw new NotImplementedException();
        }

    }
}
