using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decanate
{
    public class Evaluations
    {
        [Key]
        public int id { get; set; }

        [Required]
        public int value { get; set; }
        //Ссылаемся на номер студента
        public Students students_ { get; set; }
        //public List<Students> students { get; set; }
    }
}
