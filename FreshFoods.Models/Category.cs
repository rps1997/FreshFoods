using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FreshFoods.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Name")]
        public string name { get; set; }
        [Range(1,100)]
        [DisplayName("Display order")]
        public int DisplayOrder { get; set; }
    }
}
