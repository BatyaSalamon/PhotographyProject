using AutoMapper;


namespace Bl.BlServices
{
    public class BLAllCustomerService : IBLAllCustomer
    {
        IDalCustomer dalManager;

        IMapper mapper;
        public BLAllCustomerService(DalManager dalManager, IMapper mapper)
        {
            this.dalManager = dalManager.Customer;
            this.mapper = mapper;
        }

        public List<BLAllCustomer> GetAll()
        {
            List<Customer> dalAllCustomers = dalManager.GetAll();
            List<BLAllCustomer> blAllCustomers = new List<BLAllCustomer>();
            for (int i = 0; i < dalAllCustomers.Count(); i++)
            {
                blAllCustomers.Add(mapper.Map<BLAllCustomer>(dalAllCustomers[i]));
            }
            return blAllCustomers;
        }

        public BLAllCustomer Get(int id)
        {
            return mapper.Map<BLAllCustomer>(dalManager.Get(id));
        }

        public BLAllCustomer GetByPhon(string phon)
        {
            return mapper.Map<BLAllCustomer>(dalManager.GetByPhon(phon));
        }


        public BLAllCustomer Post(BLAllCustomer t)
        {
            Customer c = mapper.Map<Customer>(t);
             dalManager.Post(c);
            return mapper.Map<BLAllCustomer>(c);


        }

        public BLAllCustomer Put(BLAllCustomer t)
        {
            Customer c = mapper.Map<Customer>(t);
            dalManager.Put(c);
            return mapper.Map<BLAllCustomer>(c);

        }
        public BLAllCustomer Delete(int id)
        {
            throw new NotImplementedException();
        }

    }
}
