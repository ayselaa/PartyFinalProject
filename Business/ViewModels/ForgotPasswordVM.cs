using System.ComponentModel.DataAnnotations;

namespace Business.ViewModels
{
    public class ForgotPasswordVM
    {
        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
