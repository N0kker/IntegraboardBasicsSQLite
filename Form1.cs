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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Metodo para añadir un pictograma al presionar guardar
        private void Guardar_Click(object sender, EventArgs e)
        {
            Pictograms objeto = new Pictograms() //se crea un objeto de tipo Pictograma con los datos entregados en las textbox 2 y 3 (se ignora el ID porque el ID es autoincremental)
            {
                Name = textBox2.Text,
                imageName = textBox3.Text
            };

            bool respuesta = PictogramsLogica.Instance.Guardar(objeto); //se llama a la función Guardar de PictogramsLogica y se envía el objeto recién creado con los datos que se ingresaron en las textboxes

            //si no hubo problemas, cargar los pictogramas de nuevo y limpiar las cajas de texto
            if (respuesta)
            {
                show_pictograms(); //mostrar los pictogramas
                clear_pictograms(); //Limpiar las cajas de texto
            }
        }

        //Método para mostrar la lista de pictogramas
        public void show_pictograms()
        {
            dgvPictograms.DataSource = null;
            dgvPictograms.DataSource = PictogramsLogica.Instance.Listar();
        }

        //Método para mostrar los tableros
        public void show_boards()
        {
            dgvBoards.DataSource = null;
            dgvBoards.DataSource = BoardsLogica.Instance.Listar();
        }

        //Metodo para limpiar las cajas de texto
        public void clear_pictograms()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox1.Focus(); //volver a posicionarse en la primera caja de texto
        }

        //Método para limpiar las cajas de texto en la pestaña boards
        public void clear_boards()
        {
            BoardIDtxt.Text = "";
            BoardNametxt.Text = "";
            BoardImagetxt.Text = "";
            BoardIDtxt.Focus(); //volver a posicionarse en la primera caja de texto
        }

        //Al cargar la ventana, se cargan los pictogramas y los tableros
        private void Form1_Load(object sender, EventArgs e)
        {
            show_pictograms();
            show_boards();
        }

        //Editar un pictograma, se necesita ingresar los datos nuevos e indicar el ID del pictograma a cambiar
        private void Editar_Click(object sender, EventArgs e)
        {
            Pictograms objeto = new Pictograms()
            {
                ID = int.Parse(textBox1.Text), //nota: podría haber hecho aquí lo mismo que en Eliminar donde como ID tomo el ID del pictograma que está seleccionado
                Name = textBox2.Text,
                imageName = textBox3.Text
            };

            bool respuesta = PictogramsLogica.Instance.Editar(objeto);

            //si no hubo problemas, mostrar cargar los pictogramas de nuevo y limpiar las cajas de texto
            if (respuesta)
            {
                show_pictograms();
                clear_pictograms();
            }
        }

        //Eliminar pictograma
        private void Eliminar_Click(object sender, EventArgs e)
        {
            Pictograms objeto = new Pictograms()
            {
                ID = int.Parse(dgvPictograms.CurrentRow.Cells[0].Value.ToString()) //Consigo el ID del pictograma que está seleccionado y lo envío como objeto a la función Eliminar,
                                                                                   //Por qué estoy creando un objeto si es solo 1 dato? podría envíar directamente el dato en vez de crear un objeto? lo averiguaremos en el siguiente episodio
            };

            bool respuesta = PictogramsLogica.Instance.Eliminar(objeto);

            //si no hubo problemas, mostrar cargar los pictogramas de nuevo y limpiar las cajas de texto
            if (respuesta)
            {
                show_pictograms();
                clear_pictograms();
            }
        }

        //Método para guardar un tablero
        private void SaveBoard_Click(object sender, EventArgs e)
        {
            Boards objeto = new Boards()
            {
                Name = BoardNametxt.Text,
                mainImage = BoardImagetxt.Text
            };

            bool respuesta = BoardsLogica.Instance.Guardar(objeto);

            //si no hubo problemas, mostrar cargar los pictogramas de nuevo y limpiar las cajas de texto
            if (respuesta)
            {
                show_boards();
                clear_boards();
            }
        }

        //Metodo para editar un tablero (Hay que escribir el ID del tablero que se quiere editar, el nombre nuevo y la imagen nueva)
        private void EditBoard_Click(object sender, EventArgs e)
        {
            Boards objeto = new Boards()
            {
                ID = int.Parse(BoardIDtxt.Text),
                Name = BoardNametxt.Text,
                mainImage = BoardImagetxt.Text
            };

            bool respuesta = BoardsLogica.Instance.Editar(objeto);

            //si no hubo problemas, cargar los tableros de nuevo y limpiar las cajas de texto
            if (respuesta)
            {
                show_boards();
                clear_boards();
            }
        }

        private void DeleteBoard_Click(object sender, EventArgs e)
        {
            Boards objeto = new Boards()
            {
                ID = int.Parse(dgvBoards.CurrentRow.Cells[0].Value.ToString())// se consigue el ID del tablero seleccionado y se envía como objeto para que se elimine
            };

            bool respuesta = BoardsLogica.Instance.Eliminar(objeto);

            //si no hubo problemas, cargar los tableros de nuevo y limpiar las cajas de texto
            if (respuesta)
            {
                show_boards();
            }
        }

        private void dgvBoards_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form2 f2 = new Form2(); //Mala idea, es mejor tener una variable global para cambiar la vista,
                                    //de esa forma se ocuparía Hide, así como está, se ocupa Close lo cual
                                    //hace que se cargue toda la vista cada vez que se quiera mostrar (o eso entendí)

            f2.BoardToFill.Text = this.dgvBoards.CurrentRow.Cells[0].Value.ToString();  //e.RowIndex.ToString();
            f2.Show();

        }

        private void DisplayBoard_Click(object sender, EventArgs e)
        {
            FormTablero f3 = new FormTablero(); 

            //f2.BoardToFill.Text = this.dgvBoards.CurrentRow.Cells[0].Value.ToString();  //e.RowIndex.ToString();
            
            f3.selectedBoard = int.Parse(this.dgvBoards.CurrentRow.Cells[0].Value.ToString());
            f3.Show();
        }
    }
}
