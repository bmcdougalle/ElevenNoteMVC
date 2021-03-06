using System;
using ElevenNote.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
    public class NoteEdit
    {
        public int NoteId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int? CategoryId { get; set; }
        public virtual Category Category { get; set; }

    }
}
