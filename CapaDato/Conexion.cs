using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public class Libro
    {
        public int LibroID { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }

        //TODO: Propiedades virtuales para compatibilidad con DataGridView
        public virtual string Editorial => "";
        public virtual decimal Peso => 0;
        public virtual string Formato => "";
        public virtual decimal TamanoMB => 0;

        public virtual string MostrarDescripcion()
        {
            return $"[{LibroID}] \"{Titulo}\" - {Autor}";
        }
    }

    public class LibroImpreso : Libro
    {
        public string EditorialReal { get; set; }
        public decimal PesoReal { get; set; }

        public override string Editorial => EditorialReal;
        public override decimal Peso => PesoReal;

        public override string MostrarDescripcion()
        {
            return base.MostrarDescripcion() + $", Tipo: Impreso, Editorial: {Editorial}, Peso: {Peso} kg";
        }
    }

    public class LibroDigital : Libro
    {
        public string FormatoReal { get; set; }
        public decimal TamanoReal { get; set; }

        public override string Formato => FormatoReal;
        public override decimal TamanoMB => TamanoReal;

        public override string MostrarDescripcion()
        {
            return base.MostrarDescripcion() + $", Tipo: Digital, Formato: {Formato}, Tamaño: {TamanoMB} MB";
        }
    }

    public class LibroDAL
    {
        private readonly string cadenaConexion = "Server=.;Database=BibliotecaDB;Integrated Security=true;TrustServerCertificate=True;";

        public void Insertar(Libro libro)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Libros (Titulo, Autor, Tipo, Editorial, Peso, Formato, TamanoMB) VALUES (@Titulo, @Autor, @Tipo, @Editorial, @Peso, @Formato, @TamanoMB)", conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@Titulo", libro.Titulo);
                cmd.Parameters.AddWithValue("@Autor", libro.Autor);

                if (libro is LibroImpreso li)
                {
                    cmd.Parameters.AddWithValue("@Tipo", "Impreso");
                    cmd.Parameters.AddWithValue("@Editorial", li.Editorial);
                    cmd.Parameters.AddWithValue("@Peso", li.Peso);
                    cmd.Parameters.AddWithValue("@Formato", DBNull.Value);
                    cmd.Parameters.AddWithValue("@TamanoMB", DBNull.Value);
                }
                else if (libro is LibroDigital ld)
                {
                    cmd.Parameters.AddWithValue("@Tipo", "Digital");
                    cmd.Parameters.AddWithValue("@Editorial", DBNull.Value);
                    cmd.Parameters.AddWithValue("@Peso", DBNull.Value);
                    cmd.Parameters.AddWithValue("@Formato", ld.Formato);
                    cmd.Parameters.AddWithValue("@TamanoMB", ld.TamanoMB);
                }

                cmd.ExecuteNonQuery();
            }
        }

        public List<Libro> Listar()
        {
            var lista = new List<Libro>();

            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Libros", conn))
            {
                conn.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        string tipo = dr["Tipo"].ToString();

                        if (tipo == "Impreso")
                        {
                            lista.Add(new LibroImpreso
                            {
                                LibroID = Convert.ToInt32(dr["LibroID"]),
                                Titulo = dr["Titulo"].ToString(),
                                Autor = dr["Autor"].ToString(),
                                EditorialReal = dr.IsDBNull(dr.GetOrdinal("Editorial")) ? "" : dr["Editorial"].ToString(),
                                PesoReal = dr.IsDBNull(dr.GetOrdinal("Peso")) ? 0 : Convert.ToDecimal(dr["Peso"])
                            });
                        }
                        else if (tipo == "Digital")
                        {
                            lista.Add(new LibroDigital
                            {
                                LibroID = Convert.ToInt32(dr["LibroID"]),
                                Titulo = dr["Titulo"].ToString(),
                                Autor = dr["Autor"].ToString(),
                                FormatoReal = dr.IsDBNull(dr.GetOrdinal("Formato")) ? "" : dr["Formato"].ToString(),
                                TamanoReal = dr.IsDBNull(dr.GetOrdinal("TamanoMB")) ? 0 : Convert.ToDecimal(dr["TamanoMB"])
                            });
                        }
                    }
                }
            }

            return lista;
        }

        public void Actualizar(Libro libro)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            using (SqlCommand cmd = new SqlCommand("UPDATE Libros SET Titulo = @Titulo, Autor = @Autor, Tipo = @Tipo, Editorial = @Editorial, Peso = @Peso, Formato = @Formato, TamanoMB = @TamanoMB WHERE LibroID = @LibroID", conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@LibroID", libro.LibroID);
                cmd.Parameters.AddWithValue("@Titulo", libro.Titulo);
                cmd.Parameters.AddWithValue("@Autor", libro.Autor);

                if (libro is LibroImpreso li)
                {
                    cmd.Parameters.AddWithValue("@Tipo", "Impreso");
                    cmd.Parameters.AddWithValue("@Editorial", li.Editorial);
                    cmd.Parameters.AddWithValue("@Peso", li.Peso);
                    cmd.Parameters.AddWithValue("@Formato", DBNull.Value);
                    cmd.Parameters.AddWithValue("@TamanoMB", DBNull.Value);
                }
                else if (libro is LibroDigital ld)
                {
                    cmd.Parameters.AddWithValue("@Tipo", "Digital");
                    cmd.Parameters.AddWithValue("@Editorial", DBNull.Value);
                    cmd.Parameters.AddWithValue("@Peso", DBNull.Value);
                    cmd.Parameters.AddWithValue("@Formato", ld.Formato);
                    cmd.Parameters.AddWithValue("@TamanoMB", ld.TamanoMB);
                }

                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int libroID)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            using (SqlCommand cmd = new SqlCommand("DELETE FROM Libros WHERE LibroID = @LibroID", conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@LibroID", libroID);
                cmd.ExecuteNonQuery();
            }
        }
    }
}