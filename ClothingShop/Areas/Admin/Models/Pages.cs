using System.ComponentModel.DataAnnotations;

namespace ClothingShop.Areas.Admin.Models
{
    public class Pages
    {
        [Key]
        public int PageId { get; set; }
        [Required]
        public string PageTitle { get; set; }
        [Required]
        public string PageBody { get; set; }
        public string? Published { get; set; }
        public string? PageImage { get; set; }
        public string? PageVideo { get; set; }
        public bool Active { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
