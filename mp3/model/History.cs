using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mp3.model
{
    [Table("History")]
    public class History
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(maximumLength: 50)]
        public string? Code { get; set; }
        [StringLength(maximumLength: 50)]
        public string? SongCode { get; set; } 
        [StringLength(maximumLength: 50)]
        public string? UserCode { get; set; }
        public bool Favourite { get; set; }
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
