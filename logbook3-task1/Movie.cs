using System.ComponentModel.DataAnnotations;

namespace logbook3_task1
{
    public class Movie
    {
        public int Id { get; set; } 
        public string Title { get; set; }  = String.Empty;

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [Range(0, 20)]
        public decimal Price { get; set; } = 0;
    }
}
