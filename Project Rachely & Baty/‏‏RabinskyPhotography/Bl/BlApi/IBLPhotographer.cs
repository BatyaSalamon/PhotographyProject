

namespace Bl.BlApi
{
    public interface IBLPhotographer:IBLCroud<BLPhotographer>
    {
        public BLCustomer GetCustomersByDate(DateTime? date, int id);
        public List<BLCustomer> GetCustomersByMonth(int month, int id);

    }
}
