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
    public partial class Registro_Cliente : Form
    {
        public Registro_Cliente()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            Txt_Calendar.Text = monthCalendar1.SelectionStart.ToString();
        }

        private void Btn_Down_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegistroCliente_Load(object sender, EventArgs e)
        {

        }

        private void Pct_Calendar2_Click(object sender, EventArgs e)
        {
            groupBox2.Show();
        }

        private void Txt_FechaCar_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            Txt_FechaCar.Text = monthCalendar2.SelectionStart.ToString();
        }

        private void Btn_Down2_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;

        }

        private void Grb_DatosCliente_Enter(object sender, EventArgs e)
        {

        }
    }
}
