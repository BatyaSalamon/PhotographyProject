

namespace Bl.BlApi
{
    public interface IBLAllCustomer : IBLCroud<BLAllCustomer>
    {
        public BLAllCustomer GetByPhon(string phon);
    }
}




