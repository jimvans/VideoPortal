using System.ComponentModel.DataAnnotations.Schema;

namespace video_app_api.Models
{
    [Table("video")]
    public class Video
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("title")]
        public string Title { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("category")]
        public int Category { get; set; }

        [Column("filename")]
        public string FileName { get; set; }

        [Column("path")]
        public string Path { get; set; }
    }
}
