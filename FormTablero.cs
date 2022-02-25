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

namespace WindowsFormsApp1
{
    public partial class FormTablero : Form
    {
        public int selectedBoard;

        public FormTablero()
        {
            InitializeComponent();
        }

        //Al cargar el Form, mostrar la lista de pictogramas asociados al tablero seleccionado
        private void FormTablero_Load(object sender, EventArgs e)
        {
            show_board_content();
        }

        //se llama al metodo Listar para que muestre el contenido del tablero en la datagrid view "dgvBoardContent"
        public void show_board_content()
        {
            dgvBoardContent.DataSource = null;
            dgvBoardContent.DataSource = PictoInBoardLogica.Instance.Listar(selectedBoard);
        }
    }
}
