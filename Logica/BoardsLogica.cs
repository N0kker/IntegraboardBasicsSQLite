using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using WindowsFormsApp1.Modelo;
using System.Data.SQLite;

namespace WindowsFormsApp1.Logica
{
    internal class BoardsLogica
    {
        //cadena se ocupa para la conexión a la DB
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        private static BoardsLogica _instance = null;

        public BoardsLogica()
        {

        }

        public static BoardsLogica Instance //Instance se ocupará para llamar a las funciones de la clase
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BoardsLogica();
                }

                return _instance;
            }
        }

        //Crear un nuevo tablero (solo el tablero, aún no se rellena con los pictogramas)
        public bool Guardar(Boards obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "insert into Boards(Name, mainImage) values (@Name, @mainImage)"; //se crea una query para DB en forma de string

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@Name", obj.Name)); //el @Name que está en la query tomará este valor que viene del objeto que se entrega como parámetro
                cmd.Parameters.Add(new SQLiteParameter("@mainImage", obj.mainImage)); //el @mainImage que está en la query tomará este valor que viene del objeto que se entrega como parámetro

                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1) //Si la query retorna menos de 1 cambio realizado con exito, no hubo respuesta
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }

        //Metodo que retorna todos los tableros que están guardados en la base de datos (en la tabla Boards)
        public List<Boards> Listar()
        {
            List<Boards> oLista = new List<Boards>(); //oLista será la variable que tomará el valor de todos los Boards que existen en la DB

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "select * from Boards";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader()) //El data reader va a pasar leyendo los datos de los Boards en la DB y así se crean los Boards que se añaden a oLista
                {
                    while (dr.Read())
                    {
                        oLista.Add(new Boards()
                        {
                            ID = int.Parse(dr["ID"].ToString()),
                            Name = dr["Name"].ToString(),
                            mainImage = dr["mainImage"].ToString()
                        });
                    }
                }
            }
            return oLista;
        }

        //Metodo para editar Boards
        public bool Editar(Boards obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "Update Boards set Name = @Name, mainImage = @mainImage where ID = @ID";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                //Los parametros le dan el valor a la query
                cmd.Parameters.Add(new SQLiteParameter("@ID", obj.ID));
                cmd.Parameters.Add(new SQLiteParameter("@Name", obj.Name));
                cmd.Parameters.Add(new SQLiteParameter("@mainImage", obj.mainImage));

                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }

        //Metodo para eliminar un Board
        public bool Eliminar(Boards obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open(); //la conexión con sqlite se abre aquí y se cierra cuando se termina de ejecutar la función
                string query = "delete from Boards where ID = @ID";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@ID", obj.ID));

                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }

    }

}
