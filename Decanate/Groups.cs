using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decanate
{
    public class Groups
    {
        [Key]
        public int id { get; set; }

        [Required]
        public int group_num { get; set; }
        public int start_year { get; set; }
        public int end_year { get; set; }
        //Ссылаемся на номер деканата
        public Decanates decanates_ { get; set; }
        public List<Students> students { get; set; }
        /*public List<Decanates> decanates { get; set; }

        public Students Students { get; set; }*/
    }
}
