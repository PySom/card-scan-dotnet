using System.ComponentModel.DataAnnotations;

namespace Vision.ViewModels;

public class FileViewModel
{
    [Required]
    public required IFormFile File { get; set; }
}
