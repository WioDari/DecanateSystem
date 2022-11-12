using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decanate
{
    public class Decanates
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string facultet { get; set; }

        public List<Groups> groups { get; set; }
        public List<PayFlows> payflows { get; set; }
        public List<Infos> infos { get; set; }

        /*public Groups Groups { get; set; }
        public PayFlows PayFlows { get; set; }
        public Infos Infos { get; set; }*/
    }
}
