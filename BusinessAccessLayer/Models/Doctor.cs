namespace DMCM_API.Models
{
    public class Doctor
    {
        public string Doctor_id { get; set; }
        public string? Password { get; set; }
        public string? Name { get; set; }
        public DateTime Dob { get; set; }
        public string? Email_id { get; set; }
        public string? License { get; set; }
        public string? Specialization { get; set; }
        public long  Mobile { get; set; }
    }
}
