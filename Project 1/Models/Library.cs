using System.ComponentModel.DataAnnotations.Schema;
using Project_1.Models;
namespace Project_1.Models
{
public class Library
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Books>? Book { get; set; }
    }
}
