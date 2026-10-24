using System.ComponentModel.DataAnnotations;
using ShopDemoV3.Utils;

namespace ShopDemoV3.DTOs
{
    public class AddressRequestDTO
    {
        [Required]
        [MaxLength(length: 20, ErrorMessage = DomainResponseMessages.MaximumOf20CharactersError)]
        public string ZipCode { get; set; }
        [Required]
        [MaxLength(length:100, ErrorMessage = DomainResponseMessages.MaximumOf100CharactersError)]
        public string Street { get; set; }
        [Required]
        public int Number { get; set; }
        [Required]
        [MaxLength(length:50, ErrorMessage = DomainResponseMessages.MaximumOf50CharactersError)]
        public string Neighborhood {get; set; }
    }
}