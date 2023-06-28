using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace LookBook_razor.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public String Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage = "Display Order 1-100 ko bich ma huna parxa")]
        public int DisplayOrder { get; set; }
    }
}
