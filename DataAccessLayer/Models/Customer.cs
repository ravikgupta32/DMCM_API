namespace DataAccessLayer.Models
{
    public class Customer
    {
        public string? Userid { get; set; }
        public string? Password { get; set; }
        public string? Name { get; set; }

        public DateTime Dob { get; set; }
        public string? Email { get; set; }

        public string? Report_id { get; set; }
        public int Nomination_details_id { get; set; }

        public string? Agent_id { get; set; }

    }
}
