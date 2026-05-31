using Newtonsoft.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Book_Store.Models
{
    [Table("Book")]
    public class Book
    {
        public int id { get; set; }
        [Required]
        [MaxLength(40)]
        public string? BookName { get; set; }   
        public double Price { get; set; } = 0;
        public string? BookImage { get; set; }
        [Required]
//Now Connection the Genere Table With Book Table
            public int GenereId { get; set; }
//One Book Have Only One Genere
        public Genere? Genere { get; set; }
        public List<OrderDetail>? OrderDetails { get; set; }
        public List<CartDetail>? CartDetails { get; set; }
    }
}
