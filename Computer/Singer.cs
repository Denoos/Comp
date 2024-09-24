using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer
{
    public class Singer
    {
        public int ID {  get; set; }
        public string Name { get; set; }
        public string IsBoy { get; set; }
        public List<Music> Musics { get; set; }
    }
}
