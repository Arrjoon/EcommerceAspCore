using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Myapp.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(25)]
        [DisplayName("Category Name")]
        public string? Name { get; set; }

        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage = "number of the display order must me 1 to 100")]
        public int DisplayOrder { get; set; }
    }
}
