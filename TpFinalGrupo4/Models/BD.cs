using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using TpFinalGrupo4.Models;

namespace TpFinalGrupo4.Models
{
    public static class BD
    {
        private static string _connectionString = "Server=.;Database=TPFinalGrupo4;Trusted_Connection=True;";

        public static string ConnectionString
        {
            get
            {
                return _connectionString;
            }
        }

        private static SqlConnection Conectar()
        {
            SqlConnection conn = new SqlConnection(_connectionString);
            conn.Open();
            return conn;
        }

        public static void Desconectar(SqlConnection conn)
        {
            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }

        public static List<Noticia> ObtenerTodasLasNoticias()
        {
            List<Noticia> lista = new List<Noticia>();
            SqlConnection conn = Conectar();
            SqlCommand consulta = conn.CreateCommand();
            consulta.CommandText = "SELECT ID_Articulo, Titulo, Fecha, texto, ID_Autor from Articulo";
            consulta.CommandType = System.Data.CommandType.Text;
            SqlDataReader dr = consulta.ExecuteReader();
            while (dr.Read())
            {
                int ID_Articulo = Convert.ToInt32(dr["ID_Articulo"]);
                string Titulo = dr["TItulo"].ToString();
                DateTime Fecha = Convert.ToDateTime(dr["Fecha"]);
                string texto = dr["texto"].ToString();
                int ID_Autor = Convert.ToInt32(dr["ID_Autor"]);
                Noticia unaNoticia = new Noticia(ID_Articulo, Titulo, Fecha, texto, ID_Autor);
                lista.Add(unaNoticia);
            }
            Desconectar(conn);
            
            return lista;
        }
        
    }
}