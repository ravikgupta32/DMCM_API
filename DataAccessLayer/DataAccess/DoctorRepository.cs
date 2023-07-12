

using DataAccessLayer.Contracts;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace DataAccessLayer.DataAccess
{
    public class DoctorRepository: IDoctorRepository
    {
        private readonly string connectionString;
        public DoctorRepository(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }
        
            
        public Doctor AddDoctor(Doctor doctor) {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();                 
                    SqlCommand command = new SqlCommand("InsertDoctorDetails", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Doctor_id", doctor.Doctor_id);
                    command.Parameters.AddWithValue("@Password", doctor.Password);
                    command.Parameters.AddWithValue("@Name", doctor.Name);
                    command.Parameters.AddWithValue("@Dob", doctor.Dob);
                    command.Parameters.AddWithValue("@Email_id", doctor.Email_id);
                    command.Parameters.AddWithValue("@License", doctor.License);
                    command.Parameters.AddWithValue("@Specialization", doctor.Specialization);
                    command.Parameters.AddWithValue("@Mobile", doctor.Mobile);
        
                    command.ExecuteNonQuery();
                }
                return doctor;
            }
         public List<Doctor> GetDoctorDetails()
        {
            List<Doctor> doctors = new List<Doctor>();
            using (var connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Doctor_Details";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())

                    {
                        while (reader.Read())
                        {
                            Doctor doctor = new Doctor
                            {
                                Doctor_id = reader["Doctor_Id"].ToString(),
                                Password = reader["Password"].ToString(),
                                Name = reader["Name"].ToString(),
                                Dob = Convert.ToDateTime(reader["Dob"]),
                                Email_id = reader["Email_Id"].ToString(),
                                Mobile =reader["Mobile"].ToString(),
                                License = reader["License"].ToString(),
                                Specialization = reader["Specialization"].ToString(),

                            };
                            doctors.Add(doctor);
                        }
                    }
                    return doctors;
                }
            }
        }



    }
}
