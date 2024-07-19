using System.ComponentModel.DataAnnotations;

namespace CodersGrill.Models;
public class TextContent
{
    public int Id {get;}
    [Required]
    public string Name {get;}
    public string Content {get; set;}
    public TextContent(int id, string name)
        {
            Id = id;
            Name = name;
        }
}