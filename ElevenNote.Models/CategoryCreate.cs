using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
    public class CategoryCreate
    {
        [Required]
        [MinLength(2, ErrorMessage ="The name should be at least 2 characters long")]
        [MaxLength(20, ErrorMessage ="There are too many characters in this field")]
        [Display(Name ="Category Name")]
        public string CategoryName { get; set; }
    }
}
