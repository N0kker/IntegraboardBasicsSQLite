using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Modelo
{
    internal class PictoInBoard //PictoInBoard representa la tabla intermedia entre pictograms y boards
    {
        [ForeignKey(typeof(Pictograms))]
        public int ID_Pictograms { get; set; }

        [ForeignKey(typeof(Boards))]
        public int ID_Boards { get; set;}

    }
}
