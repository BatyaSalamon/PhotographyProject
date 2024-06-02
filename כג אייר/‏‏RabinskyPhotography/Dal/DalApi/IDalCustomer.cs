

namespace Dal.DalApi
{
    public interface IDalCustomer:ICroud<Customer>
    {
        public Customer GetByPhon(string phon);
    }
}
