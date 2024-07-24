using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenguajeDB.Utilidad
{
    public class ItemCombo
    {
        public int Id { get; set; }
        public string Texto { get; set; }

        public ItemCombo(int id, string nombre)
        {
            Id = id;
            Texto = nombre;
        }

        public override string ToString()
        {
            return Texto;
        }
    }
}
