using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Modelo
{
    public class Boards
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string mainImage { get; set; }

        [ManyToMany (typeof(PictoInBoard))]
        public List<Pictograms> Pictograms { get; set; }
    }


}
