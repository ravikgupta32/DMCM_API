namespace DMCM_API.Models
{
    public class Customer
    {
       public int Userid { get; set; }
       private String? Password { get; set; }
       public  String?  Name { get; set; }

       public  String?  Dob {get; set; }
       public  String? Email { get; set; }
       public  int  mobile { get; set; }

    }
}
