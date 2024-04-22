using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mp3.model
{
    [Table("Genre")]
    public class Genre
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(maximumLength: 50)]
        public string? Code { get; set; } 
        [StringLength(maximumLength: 100)]
        public string? Name { get; set; }
        public int NumberOfSongs { get; set; }
        [StringLength(maximumLength: 100)]
        public string? Avatar { get; set; }
        public bool IsDelete { get; set; }
        [StringLength(maximumLength: 100)]
        public string? CreateBy { get; set; }
        public DateTime CreateTime { get; set; }
        [StringLength(maximumLength: 100)]
        public string? UpdateBy { get; set; }
        public DateTime UpdateTime { get; set; }
        [StringLength(maximumLength: 100)]
        public string? DeleteBy { get; set; }
        public DateTime DeleteTime { get; set; }
    }
}
