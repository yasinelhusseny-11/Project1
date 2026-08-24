using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_1.Models
{
    public class Books
    {
        public int BooksId { get; set; }
        [Required]
        [MinLength(15)]
        public string BooksName { get; set; }
        [Range(10,40)]
        public int Price { get; set; }
        public string Author { get; set; }
        public int PublishedYear { get; set; }
        [ForeignKey("Library")]
        public int LibraryId { get; set; }
        public virtual Library? Library { get; set; }

    }
}
