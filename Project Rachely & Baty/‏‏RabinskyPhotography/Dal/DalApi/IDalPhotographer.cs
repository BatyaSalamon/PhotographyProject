

namespace Dal.DalApi
{
    public interface IDalPhotographer:ICroud<Photographer>
    {
        public List<Photographer> GetAllWithCustomer();

        public List<Photographer> GetAllWithPrice();
    }
}
