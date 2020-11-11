using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
    public class NoteCreate
    {
        [Required]
        [MaxLength(100, ErrorMessage = "Title is limited to 100 characters.")]
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
