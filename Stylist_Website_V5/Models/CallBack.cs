using System;
using System.ComponentModel.DataAnnotations;

namespace Stylist_Website_V5.Models
{
    public class CallBack
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string Message { get; set; }
    }
}