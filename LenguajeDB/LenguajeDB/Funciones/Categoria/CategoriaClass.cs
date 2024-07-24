using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenguajeDB.Funciones.Categoria
{
    public class CategoriaClass
    {
        public int IdCategoria { get; set; }
        public string Descripcion { get; set; }

        public CategoriaClass(int idCategoria, string descripcion)
        {
            IdCategoria = idCategoria;
            Descripcion = descripcion;
        }

        public override string ToString()
        {
            return Descripcion; // Esto define qué se mostrará en el ComboBox como texto visible
        }
    }

}
