using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decanate
{
    public class Profiles
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string name { get; set; }
        public string login { get; set; }
        public string password { get; set; }
    }
}
