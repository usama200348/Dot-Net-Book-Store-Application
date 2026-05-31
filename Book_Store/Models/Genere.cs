using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Book_Store.Models
{
    //Making Table In Database
    [Table("Genere")]
    public class Genere
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(40)]
        public string GenereName { get; set; }

        //Genere Can Have Multiple Books
        public List <Book> Books { get; set; }
    }
}
