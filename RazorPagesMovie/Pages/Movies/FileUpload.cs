using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace RazorPagesMovie.Pages.Movies
{
    public class FileUpload
    {
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Public Schedule")]
        public IFormFile UploadPublicSchedule { get; set; }

        [Required]
        [Display(Name = "Private Schedule")]
        public IFormFile UploadPrivateSchedule { get; set; }
    }
}