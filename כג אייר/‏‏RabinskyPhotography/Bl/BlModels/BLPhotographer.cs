

namespace Bl.BlModels
{

    public class BLPhotographer
    {
        public BLPhotographer(string? firstName, string lastName, BLPrice priceCodeNavigation)
        {
            this.FirstName = firstName;
            this.LastName = lastName;            
            this.PriceCodeNavigation = priceCodeNavigation;
        }
        public string? FirstName { get; set; }

        public string LastName { get; set; } = null!;

        public virtual BLPrice PriceCodeNavigation { get; set; } = null!;

    }
}
