using System.ComponentModel.DataAnnotations;
using ShopDemoV3.Utils;

namespace ShopDemoV3.DTOs
{
    public class AddressRequestDTO
    {
        [Required]
        [MaxLength(length: 20, ErrorMessage = DomainResponseMessages.MaximumOf20CharactersError)]
        public string ZipCode { get; set; }
    }
}