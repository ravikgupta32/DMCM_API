namespace DMCM_API.Models
{
    public class Report
    {
     public string Report_Id { get; set; }
     public string Customer_Name { get; set; }
     
     public DateTime Dob { get; set; }
     
     public string Email_Id { get; set; }   
     
     public long Mobile_Number { get; set; }
     public string Doctor_name { get; set; }
     public string Diagnosis { get; set; }

     public string Result { get; set; }
     public long Nomination_details_id { get; set; }





    }
}
