

namespace Bl.BlModels
{
    public class BLCustomer
    {
        public BLCustomer(string kalaName, string chatanName, DateTime weddingDate, string phone)
        {
            KalaName = kalaName;
            ChatanName = chatanName;
            WeddingDate = weddingDate;
            Phone = phone;
            
        }
        public string KalaName { get; set; } = null!;

        public string ChatanName { get; set; } = null!;

        public DateTime WeddingDate { get; set; }

        public string Phone { get; set; } = null!;

    }
}
