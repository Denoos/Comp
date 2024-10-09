using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer
{
    public class Singer
    {
        public int ID {  get; set; }
        public string Name { get; set; }
        public bool IsBoy { get; set; }

        [NotMapped]
        public char IsBoyChar { get => IsBoy ? 'м' : 'ж'; }
        public List<Music> Musics { get; set; }
    }
}
