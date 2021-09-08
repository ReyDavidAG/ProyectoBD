using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatosGit;
using EntidadesGit;

namespace MetodosGit
{
    public class Metodos
    {
        Base b = new Base("localhost", "root", "", "Tienda", 3306);
        public string Guardar(EntidadProductos producto)
        {
            return b.Comando(string.Format("insert into Productos values('{0}', '{1}','{2}','{3}')", producto.IDprducto, producto.Nombre, producto.Descripcion, producto.Precio));
        }
        public void Mostrar(DataGridView tabla, string dato)
        {
            tabla.DataSource = b.Mostrar(string.Format("select * from productos where idproducto like '%{0}%'", dato), "productos").Tables["productos"];
            tabla.AutoResizeColumns();
        }
        
    }
}
