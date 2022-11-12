using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decanate
{
    public class Infos
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string info_about { get; set; }
        //Ссылаемся на номер студента
        public Students students_ { get; set; }
        public Decanates decanates_ { get; set; }
        /*public List<Students> students { get; set; }
        //Ссылаемся на номер деканата
        public List<Decanates> decanates { get; set; }*/
    }
}
