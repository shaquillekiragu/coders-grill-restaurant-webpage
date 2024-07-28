using System.ComponentModel.DataAnnotations;

namespace CodersGrill.Models;
public class TextContent {
    [Key]
    public int Id { get; set; }
    [Required]
    public int Section { get; set; }
    [Required]
    public string ContentType { get; set; } = string.Empty;
    [Required]
    public string HtmlContent { get; set; } = string.Empty;

    public TextContent(int section, string contentType = "", string htmlcontent = "")
    {
        Section = section;
        ContentType = contentType ?? throw new ArgumentNullException(nameof(contentType));
        HtmlContent = htmlcontent ?? throw new ArgumentNullException(nameof(htmlcontent));
    }
    public TextContent()
    {
        ContentType = string.Empty;
        HtmlContent = string.Empty;
    }
}