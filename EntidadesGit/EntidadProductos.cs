using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesGit
{
    public class EntidadProductos
    {
        public int IDprducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public EntidadProductos(int idproducto, string nombre, string descripcion, double precio)
        {
            IDprducto = idproducto;
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
        }
    
    }
}
