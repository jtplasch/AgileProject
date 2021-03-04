using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileProject.Data
{
    public enum TypeOfClass
    {
        Barbarian,
        Sorcerer,
        Thief
    }
    public class Character
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public TypeOfClass Class { get; set; }
        [Required]
        [Display(Name = "PlayerName")]
        public Guid UserId { get; set; }
    }
}
    class Character
    {
    }
}
