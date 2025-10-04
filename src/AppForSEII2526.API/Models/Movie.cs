namespace AppForSEII2526.API.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [StringLength(100, ErrorMessage = "Title name cannot be longer than 100 characters.")]
        public string Title { get; set; }
        
        [DataType(System.ComponentModel.DataAnnotations.DataType.Currency)]
        [Range(0.5, float.MaxValue, ErrorMessage = "Minimum price is 0.5 ")]
        [Display(Name = "Price For Purchase")]
        [Precision(10, 2)]
        public decimal PriceForPurchase { get; set; }
        
        [Range(1, int.MaxValue, ErrorMessage = "Minimum quantity for Purchase is 1")]
        [Display(Name = "Quantity For Purchase")]
        public int QuantityForPurchase { get; set; }
        
        [DataType(System.ComponentModel.DataAnnotations.DataType.Currency)]
        [Range(0.5, 100, ErrorMessage = "Minimum is 0.5 and maximum 100")]
        [Display(Name = "Price For Renting")]
        public decimal PriceForRenting { get; set; }
        
        [Display(Name = "Quantity For Renting")]
        [Range(1, int.MaxValue, ErrorMessage = "Minimum quantity for Renting is 1")]
        public int QuantityForRenting { get; set; }
        
        [DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
        
        public Genre Genre { get; set; }

        public IList<RentalItem> RentalItems { get; set; }

    }
}
