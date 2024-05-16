using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace registro_mockup.clases
{
    internal class Libro
    {
        string isbn;
        string titulo;
        string autor;
        string categoria;
        double valoracion;

        public string Isbn { get { return isbn; } }
        public string Titulo { get { return titulo; } }
        public string Autor { get { return autor; } }
        public string Categoria { get { return categoria; } }
        public double Valoracion { get { return valoracion; } }

        public Libro(string isbn, string titulo, string autor, string categoria, double valoracion)
        {
            this.isbn = isbn;
            this.titulo = titulo;
            this.autor = autor;
            this.categoria = categoria;
            this.valoracion = valoracion;
        }
    }
}
