using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TpFinalGrupo4.Models
{
    public class Noticia
    {
        private int _ID_Articulo;
        private string _Titulo;
        private DateTime _Fecha;
        private string _texto;
        private int _ID_Autor;


        public int ID_Articulo { get => _ID_Articulo; set => _ID_Articulo = value; }
        public string Titulo { get => _Titulo; set => _Titulo = value; }
        public DateTime Fecha { get => _Fecha; set => _Fecha = value; }
        public string texto { get => _texto; set => _texto = value; }
        public int ID_Autor { get => _ID_Autor; set => _ID_Autor = value; }


       
        public Noticia() { }

      
        public Noticia(int ID_Articulo, string Titulo, DateTime Fecha, string texto, int ID_Autor)
        {
            _ID_Articulo = ID_Articulo;
            _Titulo = Titulo;
            _Fecha = Fecha;
            _texto = texto;
            _ID_Autor = ID_Autor;
        }
    }
}