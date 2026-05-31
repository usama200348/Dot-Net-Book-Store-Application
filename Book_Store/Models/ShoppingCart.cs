using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Book_Store.Models
{

    [Table("ShoppingCart")]
    public class ShoppingCart
    {
        public int Id { get; set; }
        [Required]
        public String UserId { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
