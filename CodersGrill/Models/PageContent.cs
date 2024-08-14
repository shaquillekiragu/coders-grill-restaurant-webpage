using System.ComponentModel.DataAnnotations;

namespace CodersGrill.Models
{
    public class TextContent
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Section { get; set; }

        [Required]
        [StringLength(100)]
        public string ContentType { get; set; } = string.Empty;

        [Required]
        public string HtmlContent { get; set; } = string.Empty;

        public TextContent(int section, string contentType = "", string htmlContent = "")
        {
            Section = section;
            ContentType = contentType;
            HtmlContent = htmlContent;
        }

        public TextContent()
        {
        }
    }
}