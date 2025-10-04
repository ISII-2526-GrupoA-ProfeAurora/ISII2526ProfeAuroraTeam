namespace AppForSEII2526.API.Models
{
    [PrimaryKey(nameof(MovieId), nameof(RentalId))]

    public class RentalItem
    {
        public RentalItem()
        {
        }

        public RentalItem(Movie movie, Rental rent)
        {
            Movie = movie;
            MovieId = movie.Id;
            Rent = rent;
            RentalId = rent.Id;
        }

        public RentalItem(Movie movie, Rental rent, string? description) : this(movie, rent)
        {
            Description = description;
            PriceForRenting = movie.PriceForRenting;
        }

        public RentalItem(int movieId, Rental rental, double priceForRenting)
        {
            MovieId = movieId;
            Rent = rental;
            PriceForRenting = priceForRenting;
        }

        public RentalItem(int movieId, Rental rental, double priceForRenting, string? description) : this(movieId, rental, priceForRenting) => Description = description;

        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        public int RentalId { get; set; }
        public Rental Rent { get; set; }

        [StringLength(100, ErrorMessage = "Title name cannot be longer than 100 characters.")]
        public string? Description { get; set; }

        public double PriceForRenting { get; set; }

    }
}
