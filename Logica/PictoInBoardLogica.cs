using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Modelo;

namespace WindowsFormsApp1.Logica
{
    internal class PictoInBoardLogica
    {
        //obtener la cadena de conexion para sqlite
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        private static PictoInBoardLogica _instance = null; 

        public PictoInBoardLogica()
        {

        }

        public static PictoInBoardLogica Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PictoInBoardLogica();
                }

                return _instance;
            }
        }

        //Listar en esta funcion es de tipo Pictograms porque se buscan los pictogramas asociado a un tablero en específico
        public List<Pictograms> Listar(int selectedBoard)
        {
            List<Pictograms> oLista = new List<Pictograms>();

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                //Para la query se hace un Join entre Pictograms y Boards_Pictograms, que es la table intermedia de la relación n:m entre pictograms y boards
                //lo que se busca es mostrar es: los pictogramas que tienen una relación con el board seleccionado, este board se pasa como parámetro al llamar la función 
                string query = "select * from Pictograms p JOIN Boards_Pictograms b on p.ID = b.ID_Pictograms and b.ID_Boards = " + selectedBoard.ToString();
                Console.WriteLine(query);
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

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

        //Metodo para agregar pictogramas a un tablero
        public bool AddPictogramToBoard(PictoInBoard obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "insert into Boards_Pictograms(ID_Pictograms, ID_Boards) values (@ID_Pictograms, @ID_Boards)";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                //Para lograr crear la relación entre pictogramas y tableros, al momento de llamar esta función
                //se envía un objeto de tipo PictoInBoard que trae los ID del pictograma y del tablero al que se quiere agregar
                cmd.Parameters.Add(new SQLiteParameter("@ID_Pictograms", obj.ID_Pictograms));
                cmd.Parameters.Add(new SQLiteParameter("@ID_Boards", obj.ID_Boards));

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
