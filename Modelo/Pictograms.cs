using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Modelo
{
    public class Pictograms //Se define el objeto de tipo Pictograms, los atributos de este objeto son los mismos que los que tiene en la DB
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string imageName { get; set; }

        [ManyToMany(typeof(PictoInBoard))] //Instalé SQLiteNetExtensions (ver linea 1) para definir la relación n:m, no sé que tan necesario era pero lo hice igual
        public List<Boards> Boards { get; set; }    
        
    }


}
