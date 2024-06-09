

namespace Bl.BlApi
{
    public interface IBLPhotographer:IBLCroud<BLPhotographer>
    {
        public List<BLCustomer> GetCustomersByDate(DateTime? date, int id);
    }
}
