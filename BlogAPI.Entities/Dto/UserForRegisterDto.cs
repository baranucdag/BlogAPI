using Core.Entities.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Entities.Dto
{
    public class UserRegisterDto : IDto
    {
        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
