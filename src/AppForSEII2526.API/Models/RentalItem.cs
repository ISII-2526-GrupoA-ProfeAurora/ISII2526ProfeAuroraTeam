namespace AppForSEII2526.API.Models
{
    [PrimaryKey(nameof(MovieId), nameof(RentalId))]

    public class RentalItem
    {
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        public int RentalId { get; set; }
        public Rental Rent { get; set; }

        [StringLength(100, ErrorMessage = "Title name cannot be longer than 100 characters.")]
        public string? Description { get; set; }

        public double PriceForRenting { get; set; }

    }
}
