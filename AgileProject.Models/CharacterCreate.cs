using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileProject.Models
{
    public class CharacterCreate
    {
        [Required]
        [MinLength(2, ErrorMessage = "Thou must have a name...")]
        [MaxLength(16, ErrorMessage = "Whoa, settle down there bud.")]
        public string Name { get; set; }
        [Required]
        public TypeOfClass Class { get; set; }
    }
}
