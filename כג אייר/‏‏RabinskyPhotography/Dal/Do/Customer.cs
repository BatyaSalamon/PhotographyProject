

namespace Dal.Do;

public partial class Customer
{
    public int Id { get; set; }

    public string KalaName { get; set; } = null!;

    public string ChatanName { get; set; } = null!;

    public string Hall { get; set; } = null!;

    public int PhotographerId { get; set; }

    public string Phone { get; set; } = null!;

    public DateTime WeddingDate { get; set; }

    public virtual Photographer Photographer { get; set; } = null!;
}
