using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Data
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        [MaxLength(20)]
        [Display(Name ="Category")]
        public string CategoryName { get; set; }

        public virtual ICollection<Note> Notes { get; set; } = new List<Note>();
    }
}
