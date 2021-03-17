using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commander.Dtos
{
    public class CommandCreateDto
    {
        //id not required because it automatically gets created by the database
        //public int Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string HowTo { get; set; }
        [Required]
        public string Line { get; set; }
        [Required]
        public string Platform { get; set; }
    }
}
