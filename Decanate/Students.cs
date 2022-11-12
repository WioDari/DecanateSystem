using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decanate
{
    public class Students
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string name { get; set; }
        public int age { get; set; }
        public string number { get; set; }
        //Ссылаемся на номер группы
        public Groups groups_ { get; set; }
        public List<Evaluations> evaluations { get; set; }
        public List<PayFlows> payflows { get; set; }
        public List<Infos> infos { get; set; }
        /*public List<Groups> groups { get; set; }

        public Evaluations Evaluations { get; set; }
        public PayFlows PayFlows { get; set; }
        public Infos Infos { get; set; }*/
    }
}
