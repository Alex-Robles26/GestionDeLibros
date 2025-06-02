using CapaDatos; //TODO: Las entidades están aquí ahora

namespace CapaNegocio
{
    public class LibroBLL
    {
        //TODO: Acceso a la base de datos
        private readonly LibroDAL libroDAL = new LibroDAL();

        //TODO: Agregar nuevo libro con validación
        public void AgregarLibro(Libro libro)
        {
            if (string.IsNullOrWhiteSpace(libro.Titulo) || string.IsNullOrWhiteSpace(libro.Autor))
            {
                throw new ArgumentException("Título y Autor no pueden estar vacíos.");
            }

            libroDAL.Insertar(libro);
        }

        //TODO: Listar libros
        public List<Libro> ObtenerLibros()
        {
            return libroDAL.Listar();
        }

        //TODO: Editar libro
        public void ModificarLibro(Libro libro)
        {
            if (libro.LibroID <= 0)
                throw new ArgumentException("ID inválido.");

            libroDAL.Actualizar(libro);
        }

        //TODO: Eliminar libro
        public void EliminarLibro(int libroID)
        {
            if (libroID <= 0)
                throw new ArgumentException("ID inválido.");

            libroDAL.Eliminar(libroID);
        }
    }
}