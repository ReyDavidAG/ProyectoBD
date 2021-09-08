using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetodosGit;
using EntidadesGit;

namespace PresentacionesGit
{
    public partial class FrmPrincipal : Form
    {
        Metodos m;
        EntidadProductos ep;
        public FrmPrincipal()
        {
            InitializeComponent();
            m = new Metodos();
            ep = new EntidadProductos();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            

            m.Guardar(new EntidadProductos(int.Parse(TxtID.Text), TxtNombre.Text, TxtDescripcion.Text, double.Parse(TxtPrecio.Text)
                ));
            Actualizar();
        }
        void Actualizar()
        {
            m.Mostrar(DTG, TxtID.Text);
        }
    }
}
