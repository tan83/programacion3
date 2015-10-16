using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranS.A
{
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
        }

        private void registroDeUsuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Registro_Cliente nuevoCliente = new Registro_Cliente();
            nuevoCliente.Show();
        }

        private void salirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Pct_Car_Click(object sender, EventArgs e)
        {

        }

        private void actualizarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Actualizar_Clientecs nuevoActualizar = new Actualizar_Clientecs();
            nuevoActualizar.Show();
        }
    }
}
