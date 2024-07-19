using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenguajeDB.Utilidad
{
    public class Util
    {
        public static string GenerarCodigoAlfanumerico(int longitud)
        {
            const string caracteresPermitidos = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();

            for (int i = 0; i < longitud; i++)
            {
                int index = rnd.Next(caracteresPermitidos.Length);
                sb.Append(caracteresPermitidos[index]);
            }

            return sb.ToString();
        }
    }
}
