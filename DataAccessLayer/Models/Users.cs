using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Users
    {
        [Required(ErrorMessage = "User Name is required.")]
        [StringLength(25, ErrorMessage = "Username must be up to 25 characters")]


        public string? Username { get; set; }



        
        [Required]
        [PasswordPropertyText]
        [StringLength(25, ErrorMessage = "Password must be up to 25 characters")]

        public string? Password { get; set; }

    }
}
