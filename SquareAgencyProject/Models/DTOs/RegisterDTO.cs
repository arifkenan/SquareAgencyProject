using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
namespace KareAjans.Models.DTOs
{
    public class RegisterDTO
    {
        //[Required]
        public string Name { get; set; }


        //[Required]
        public string LastName { get; set; }


        [Required]
        public string Username { get; set; }


        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }



        //[Required]
        //[DataType(DataType.Password)]
        //[Compare("Password")]
        public string RePassword { get; set; }

       

       
      

    } 
}
