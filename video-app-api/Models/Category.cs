using System.ComponentModel.DataAnnotations.Schema;

namespace video_app_api.Models
{
    [Table("category")]
    public class Category
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }
    }
}
