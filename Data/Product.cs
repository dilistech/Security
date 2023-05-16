using System.ComponentModel.DataAnnotations;

namespace Security.Data
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
