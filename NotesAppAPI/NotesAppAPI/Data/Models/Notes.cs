namespace NotesAppAPI.Models
{
    using System.ComponentModel.DataAnnotations;
    public class Notes
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }
    }
}
