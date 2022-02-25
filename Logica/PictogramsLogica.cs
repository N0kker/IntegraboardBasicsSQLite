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
    internal class PictogramsLogica
    {
        //obtener la cadena de conexion para sqlite
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        private static PictogramsLogica _instance = null;

        public PictogramsLogica()
        {

        }

        public static PictogramsLogica Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new PictogramsLogica();
                }

                return _instance;
            }
        }

        //metodo para guardar un nuevo pictograma, este metodo ignora el valor entregado en la casilla ID ya que el ID es autoincremental
        public bool Guardar(Pictograms obj)
        {
            bool respuesta = true;

            using(SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "insert into Pictograms(Name, imageName) values (@Name, @imageName)";

                SQLiteCommand cmd = new SQLiteCommand(query,conexion);
                //Se consiguen los parametros por los atributos del obj que se envió al ejecutar la funcion y estos le dan el valor a los parametros de la query
                cmd.Parameters.Add(new SQLiteParameter("@Name", obj.Name));
                cmd.Parameters.Add(new SQLiteParameter("@imageName", obj.imageName));

                cmd.CommandType = System.Data.CommandType.Text;

                if(cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }

        //Metodo que retorna todos los pictogramas que están guardados en la base de datos (en la tabla Pictograms)
        public List<Pictograms> Listar()
        {
            List<Pictograms> oLista = new List<Pictograms>();

            using(SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "select * from Pictograms";

                SQLiteCommand cmd = new SQLiteCommand(query,conexion);

                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oLista.Add(new Pictograms()
                        {
                            ID = int.Parse(dr["ID"].ToString()),
                            Name = dr["Name"].ToString(),
                            imageName = dr["imageName"].ToString()
                        });
                    }
                }
            }

            return oLista;
        }


        //Metodo para editar pictogramas
        public bool Editar(Pictograms obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "Update Pictograms set Name = @Name, imageName = @imageName where ID = @ID";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                //Se consiguen los parametros por los atributos del obj que se envió al ejecutar la funcion y estos le dan el valor a los parametros de la query
                cmd.Parameters.Add(new SQLiteParameter("@ID", obj.ID));
                cmd.Parameters.Add(new SQLiteParameter("@Name", obj.Name));
                cmd.Parameters.Add(new SQLiteParameter("@imageName", obj.imageName));

                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }

        //Metodo para eliminar un pictograma
        public bool Eliminar(Pictograms obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "delete from Pictograms where ID = @ID";

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
