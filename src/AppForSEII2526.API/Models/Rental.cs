namespace AppForSEII2526.API.Models
{
    public class Rental
    {
        public Rental()
        {
        }

        public Rental(string customerUserName, string customerNameSurname, string deliveryAddress, DateTime rentalDate, DateTime rentalDateFrom, DateTime rentalDateTo, PaymentMethodTypes paymentMethod, ApplicationUser applicationUser)
        {
            //autogenerado
            CustomerUserName = customerUserName;
            CustomerNameSurname = customerNameSurname;
            DeliveryAddress = deliveryAddress;
            RentalDate = rentalDate;
            RentalDateFrom = rentalDateFrom;
            RentalDateTo = rentalDateTo;
            PaymentMethod = paymentMethod;
            ApplicationUser = applicationUser;
        }

        public int Id { get; set; }

        public string CustomerUserName { get; set; }

        public string CustomerNameSurname { get; set; }

        [DataType(System.ComponentModel.DataAnnotations.DataType.MultilineText)]
        [Display(Name = "Delivery Address")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please, set your address for delivery")]
        public string DeliveryAddress { get; set; }


        public DateTime RentalDate { get; set; }

        public DateTime RentalDateFrom { get; set; }
        public DateTime RentalDateTo { get; set; }

        public double TotalPrice { get; set; }

        [Display(Name = "Payment Method")]
        public PaymentMethodTypes PaymentMethod { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        public IList<RentalItem> RentalItems { get; set; }


    }

    public enum PaymentMethodTypes
    {
        CreditCard,
        PayPal,
        Cash
    }

}
