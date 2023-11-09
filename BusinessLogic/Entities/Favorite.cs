using System.ComponentModel.DataAnnotations;

namespace BusinessLogic.Entities
{
    public class Favorite
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public string UserId { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
