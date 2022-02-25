using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Logica;
using WindowsFormsApp1.Modelo;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e) //Al cargar el form, mostrar los pictogramas para seleccionarlos y agregarlos al Board
                                                            //Para seleccionar varios ctrl+click
        {
            show_pictograms();
        }

        //Mostrar todo los pictogramas existentes
        public void show_pictograms()
        {
            dgvPictograms.DataSource = null;
            dgvPictograms.DataSource = PictogramsLogica.Instance.Listar();
        }

        //Añadir los pictogramas seleccionados al tablero que corresponde al hacer click en guardar 
        private void btnAddToBoard_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgvPictograms.SelectedRows) //Pasar por cada fila seleccionada, r toma el valor de cada fila.
                                                                      //Por cada fila, se crea un objeto de tipo PictoInBoard con
                                                                      //el ID del Pictograma de la fila en la que se está y el ID del Board que está en la casilla de texto
            {
                PictoInBoard objeto = new PictoInBoard()
                {
                    ID_Pictograms = int.Parse(r.Cells[0].Value.ToString()), //El ID del pictograma correspondiende a la fila que se está recorriendo
                    ID_Boards = int.Parse(BoardToFill.Text.ToString()) //El ID del Board que está en la casilla de texto BoardToFill (este valor se rellena solo dependiendo del Board al que se le hizo doble click)
                };
                bool respuesta = PictoInBoardLogica.Instance.AddPictogramToBoard(objeto);
            }
            show_pictograms();
        }
    }
}
